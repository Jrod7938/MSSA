using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class CheckersBoard : MonoBehaviour, ICheckersBoard {
    public static CheckersBoard Instance;
    Piece[,] pieces = new Piece[8, 8];

    public GameObject redPiecePrefab;
    public GameObject redKingPiecePrefab;
    public GameObject blackPiecePrefab;
    public GameObject blackKingPiecePrefab;
    public CanvasGroup alertCanvas;
    private float lastAlert;
    private bool alertActive;

    private Vector3 boardOffSet = new Vector3(-4f, 5.411365f, -3.5f);
    private Vector3 pieceOffSet = new Vector3(1.5f, 0, .5f);

    public bool isRed;
    public bool isRedTurn { get; set; } = true;
    private bool hasKilled;
    private Piece selectedPiece;
    private List<Piece> forcedPieces = new List<Piece>();

    private Vector2 mouseOver;
    private Vector2 startDrag;
    private Vector2 endDrag;

    private Client client;

    public CheckersAgent aiAgent;
    private bool aiTurnTriggered = false;
    private Piece chainCapturePiece = null;

    public int redScore = 0;
    public int blackScore = 0;
    public TMP_Text redScoreText;
    public TMP_Text blackScoreText;

    /// <summary>
    /// Initializes the game board, sets up the player/team, and 
    /// generates the board pieces
    /// </summary>
    private void Start() {
        client = FindAnyObjectByType<Client>();
        if (client) {
            isRed = client.isHost;
            Alert(client.players[0].name + " vs " + client.players[1].name);
        } else {
            // Solo play: human is red, AI controls black
            isRed = true;
            Alert("Player vs Big Chungus VII");
        }
        Instance = this;
        forcedPieces = new List<Piece>();
        GenerateBoard();

        if (client == null && aiAgent != null) {
            aiAgent.boardComponent = this;
        }
    }

    /// <summary>
    /// Handles frame updates including alert fading, mouse position 
    /// tracking, player input, and AI decision requests
    /// </summary>
    private void Update() {
        UpdateAlert();
        UpdateMouseOver();

        if (client == null) {
            if ((isRed && isRedTurn) || (!isRed && !isRedTurn)) {
                CheckVictoryInternal();
                int x = (int)mouseOver.x;
                int y = (int)mouseOver.y;

                if (selectedPiece != null) UpdatePieceDrag(selectedPiece);

                if (Input.GetMouseButtonDown(0)) {
                    SelectPiece(x, y);
                }

                if (Input.GetMouseButtonUp(0)) {
                    TryMove((int)startDrag.x, (int)startDrag.y, x, y);
                }
            } else {
                if (aiAgent != null && !aiTurnTriggered) {
                    if (!aiAgent.trainingMode) { CheckVictoryInternal(); }
                    aiTurnTriggered = true;
                    aiAgent.RequestDecision();
                }
            }
        } else {
            aiAgent.gameObject.SetActive(false);
            if ((isRed) ? isRedTurn : !isRedTurn) {
                int x = (int)mouseOver.x;
                int y = (int)mouseOver.y;

                if (selectedPiece != null) UpdatePieceDrag(selectedPiece);

                if (Input.GetMouseButtonDown(0)) {
                    SelectPiece(x, y);
                }

                if (Input.GetMouseButtonUp(0)) {
                    TryMove((int)startDrag.x, (int)startDrag.y, x, y);
                }
            }
        }
    }

    /// <summary>
    /// Cleans up the singleton instance on destruction
    /// </summary>
    private void OnDestroy() {
        if (Instance == this)
            Instance = null;
    }

    /// <summary>
    /// Generates the initial board layout with red and black pieces
    /// in their positions
    /// </summary>
    private void GenerateBoard() {
        for (int y = 0; y < 3; y++) { // red team
            bool oddRow = (y % 2) == 0;
            for (int x = 0; x < 8; x += 2) {
                GeneratePiece((oddRow) ? x : x + 1, y);
            }
        }

        for (int y = 7; y > 4; y--) { // black team
            bool oddRow = (y % 2) == 0;
            for (int x = 0; x < 8; x += 2) {
                GeneratePiece((oddRow) ? x : x + 1, y);
            }
        }
    }

    /// <summary>
    /// Updates the mouse position over the board based on raycast
    /// from the main camera.
    /// </summary>
    private void UpdateMouseOver() {
        if (!Camera.main) {
            Debug.Log("Unable to find Main Camera");
            return;
        }

        RaycastHit hit;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 25.0f, LayerMask.GetMask("Board"))) {
            mouseOver.x = (int)(hit.point.x - boardOffSet.x) - 1;
            mouseOver.y = (int)(hit.point.z - boardOffSet.z);
        } else {
            mouseOver.x = -1;
            mouseOver.y = -1;
        }
    }

    /// <summary>
    /// Updates the dragged piece's position to follow the mouse 
    /// cursor using a raycast
    /// </summary>
    /// <param name="piece"></param>
    private void UpdatePieceDrag(Piece piece) {
        if (!Camera.main) {
            Debug.Log("Unable to find Main Camera");
            return;
        }

        RaycastHit hit;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 25.0f, LayerMask.GetMask("Board"))) {
            piece.transform.position = hit.point + Vector3.up;
        }
    }

    /// <summary>
    /// Selects a piece at the specified board coordinates if it 
    /// belongs to the current player
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    private void SelectPiece(int x, int y) {
        if (x < 0 || x >= 8 || y < 0 || y >= 8) return;

        Piece piece = pieces[x, y];
        if (piece != null && piece.isRed == isRed) {
            if (forcedPieces.Count == 0) {
                selectedPiece = piece;
                startDrag = mouseOver;
            } else {
                if (forcedPieces.Find(fp => fp == piece) == null) return;
                selectedPiece = piece;
                startDrag = mouseOver;
            }
        }
    }

    /// <summary>
    /// Attempts to move a piece from its starting position to a 
    /// target position and handles capture and turn logic
    /// </summary>
    /// <param name="x1">Starting X-coordinate</param>
    /// <param name="y1">Starting Y-coordinate</param>
    /// <param name="x2">Target X-coordinate</param>
    /// <param name="y2">Target Y-coordinate</param>
    public void TryMove(int x1, int y1, int x2, int y2) {
        forcedPieces = ScanForPossibleMove();

        startDrag = new Vector2(x1, y1);
        endDrag = new Vector2(x2, y2);

        selectedPiece = pieces[x1, y1];

        if (x2 < 0 || x2 >= 8 || y2 < 0 || y2 >= 8) {
            if (selectedPiece != null) MovePiece(selectedPiece, x1, y1);
            startDrag = Vector2.zero;
            selectedPiece = null;
            return;
        }
        if (selectedPiece != null) {
            if (endDrag == startDrag) {
                MovePiece(selectedPiece, x1, y1);
                startDrag = Vector2.zero;
                selectedPiece = null;
                return;
            }

            if (selectedPiece.ValidMove(pieces, x1, y1, x2, y2)) {
                if (Mathf.Abs(x2 - x1) == 2) {
                    Piece capturePiece = pieces[(x1 + x2) / 2, (y1 + y2) / 2];
                    if (capturePiece != null) {
                        pieces[(x1 + x2) / 2, (y1 + y2) / 2] = null;
                        DestroyImmediate(capturePiece.gameObject);
                        hasKilled = true;
                    }
                }

                if (forcedPieces.Count != 0 && !hasKilled) {
                    MovePiece(selectedPiece, x1, y1);
                    startDrag = Vector2.zero;
                    selectedPiece = null;
                    return;
                }

                pieces[x2, y2] = selectedPiece;
                pieces[x1, y1] = null;
                MovePiece(selectedPiece, x2, y2);

                EndTurn();
            } else {
                MovePiece(selectedPiece, x1, y1);
                startDrag = Vector2.zero;
                selectedPiece = null;
                return;
            }
        }
    }

    /// <summary>
    /// Instantiates a new piece on the board at the specified 
    /// coordinates based on team
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    private void GeneratePiece(int x, int y) {
        bool pieceIsRed = (y > 3) ? false : true;
        GameObject piece = Instantiate((pieceIsRed) ? redPiecePrefab : blackPiecePrefab, transform);
        Piece p = piece.GetComponent<Piece>();

        pieces[x, y] = p;
        MovePiece(p, x, y);
    }

    /// <summary>
    /// Moves a piece to a specified board coordinate by updating 
    /// its transform position
    /// </summary>
    /// <param name="piece"></param>
    /// <param name="x"></param>
    /// <param name="y"></param>
    private void MovePiece(Piece piece, int x, int y) {
        piece.transform.position = (Vector3.right * x) + (Vector3.forward * y) + boardOffSet + pieceOffSet;
    }

    /// <summary>
    /// Completes the current turn by checking for promotions, 
    /// sending moves in multiplayer, and switching players
    /// </summary>
    private void EndTurn() {
        int x = (int)endDrag.x;
        int y = (int)endDrag.y;

        Piece movingPiece = selectedPiece;

        if (movingPiece != null) { // Promotion check
            if (movingPiece.isRed && !movingPiece.isKing && y == 7) {
                Destroy(movingPiece.gameObject);
                GameObject newKing = Instantiate(redKingPiecePrefab, transform);
                Piece kingComponent = newKing.GetComponent<Piece>();
                kingComponent.isRed = true;
                kingComponent.isKing = true;
                pieces[x, y] = kingComponent;
                MovePiece(kingComponent, x, y);
                movingPiece = kingComponent; // update reference
            } else if (!movingPiece.isRed && !movingPiece.isKing && y == 0) {
                Destroy(movingPiece.gameObject);
                GameObject newKing = Instantiate(blackKingPiecePrefab, transform);
                Piece kingComponent = newKing.GetComponent<Piece>();
                kingComponent.isRed = false;
                kingComponent.isKing = true;
                pieces[x, y] = kingComponent;
                MovePiece(kingComponent, x, y);
                movingPiece = kingComponent;
            }
        }

        if (client) { // Send move to client if in multiplayer
            string msg = "CMOV|";
            msg += startDrag.x.ToString() + "|";
            msg += startDrag.y.ToString() + "|";
            msg += endDrag.x.ToString() + "|";
            msg += endDrag.y.ToString();
            client.Send(msg);
        }

        if (movingPiece != null && hasKilled && ScanForPossibleMove(movingPiece, x, y).Count != 0) {
            // if you can still capture return
            return;
        }

        // change turns
        selectedPiece = null;
        startDrag = Vector2.zero;
        aiTurnTriggered = false; // Reset AI trigger for next turn
        isRedTurn = !isRedTurn;
        hasKilled = false;
        CheckVictoryInternal();

        if (!client) {
            Alert(isRed ? "Red Player's Turn" : "Black Player's Turn");
        } else {
            Alert(isRed ? client.players[0].name + "'s turn" : client.players[1].name + "'s turn");
        }
    }

    /// <summary>
    /// Checks whether either team has won by verifying if one side has
    /// no remaining pieces.
    /// </summary>
    private void CheckVictoryInternal() {
        var ps = FindObjectsByType<Piece>(FindObjectsSortMode.None);
        bool hasRedPieces = false;
        bool hasBlackPieces = false;
        for (int i = 0; i < ps.Length; i++) {
            if (ps[i].isRed) {
                hasRedPieces = true;
            } else {
                hasBlackPieces = true;
            }
        }
        if (!hasRedPieces) Victory(false);
        if (!hasBlackPieces) Victory(true);
    }

    /// <summary>
    /// Handles victory by updating scores, alerting the user, and 
    /// resetting the board
    /// </summary>
    /// <param name="redWon">Indicates if the red team has won</param>
    private void Victory(bool redWon) {
        if (redWon) {
            redScore++;
            Alert("Red Team Won!");
            Debug.Log("Red Team Won.");
        } else {
            blackScore++;
            Alert("Black Team Won!");
            Debug.Log("Black Team Won.");
        }
        UpdateScoreUI();
        ResetBoard();
    }

    /// <summary>
    /// Scans and returns forced moves for a specific piece at the given 
    /// board position
    /// </summary>
    /// <param name="piece"></param>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns>A list of pieces forced to move</returns>
    private List<Piece> ScanForPossibleMove(Piece piece, int x, int y) {
        forcedPieces = new List<Piece>();
        if (pieces[x, y].IsForcedToMove(pieces, x, y)) {
            forcedPieces.Add(pieces[x, y]);
        }
        return forcedPieces;
    }

    /// <summary>
    /// Scans the entire board and returns a list of pieces that are forced 
    /// to move
    /// </summary>
    /// <returns>A list of forced pieces</returns>
    private List<Piece> ScanForPossibleMove() {
        forcedPieces = new List<Piece>();
        for (int i = 0; i < 8; i++) {
            for (int j = 0; j < 8; j++) {
                if (pieces[i, j] != null && pieces[i, j].isRed == isRedTurn) {
                    if (pieces[i, j].IsForcedToMove(pieces, i, j)) {
                        forcedPieces.Add(pieces[i, j]);
                    }
                }
            }
        }
        return forcedPieces;
    }

    /// <summary>
    /// Updates the alert UI, fading out the alert message over time
    /// </summary>
    public void UpdateAlert() {
        if (alertActive) {
            if (Time.time - lastAlert > 1.5f) {
                alertCanvas.alpha = 1 - ((Time.time - lastAlert) - 1.5f);
                if (Time.time - lastAlert > 2.5f) {
                    alertActive = false;
                }
            }
        }
    }

    /// <summary>
    /// Displays an alert message on the UI
    /// </summary>
    /// <param name="message">The message to display</param>
    public void Alert(string message) {
        alertCanvas.GetComponentInChildren<TMP_Text>().text = message;
        alertCanvas.alpha = 1;
        lastAlert = Time.time;
        alertActive = true;
    }

    /// <summary>
    /// Resets the board by destroying existing pieces, clearing state, and 
    /// regenerating the board
    /// </summary>
    public void ResetBoard() {
        for (int x = 0; x < 8; x++) {
            for (int y = 0; y < 8; y++) {
                if (pieces[x, y] != null) {
                    Destroy(pieces[x, y].gameObject);
                    pieces[x, y] = null;
                }
            }
        }
        isRedTurn = true;
        chainCapturePiece = null;
        forcedPieces.Clear();
        selectedPiece = null;
        aiTurnTriggered = false;
        GenerateBoard();
        Alert(isRedTurn ? "Red Player's Turn" : "Black Player's Turn");
    }

    /// <summary>
    /// Retrieves the current state of the board as a 2D array
    /// </summary>
    /// <returns>A two-dimensional array representing the board state</returns>
    public int[,] GetBoardState() {
        int[,] state = new int[8, 8];
        for (int x = 0; x < 8; x++) {
            for (int y = 0; y < 8; y++) {
                if (pieces[x, y] == null) state[x, y] = 0;
                else {
                    state[x, y] = pieces[x, y].isRed ? (pieces[x, y].isKing ? 2 : 1) : (pieces[x, y].isKing ? -2 : -1);
                }
            }
        }
        return state;
    }

    /// <summary>
    /// Computes and returns all valid moves for the specified team, including 
    /// forced and regular moves
    /// </summary>
    /// <param name="forRed">Determines if valid moves for red pieces are 
    /// returned</param>
    /// <returns>A list of valid moves</returns>
    public List<Move> GetValidMoves(bool forRed) {
        List<Move> validMoves = new List<Move>();
        List<Move> forcedMoves = new List<Move>();

        if (chainCapturePiece != null) { // chain capture
            int x = -1, y = -1;
            for (int i = 0; i < 8; i++) { // location of chain capture piece
                for (int j = 0; j < 8; j++) {
                    if (pieces[i, j] == chainCapturePiece) {
                        x = i;
                        y = j;
                        break;
                    }
                }
                if (x != -1) break;
            }
            if (x != -1 && y != -1) {
                int[,] captureDirections = new int[,] { { 2, 2 }, { -2, 2 }, { 2, -2 }, { -2, -2 } };
                for (int d = 0; d < captureDirections.GetLength(0); d++) {
                    int dx = captureDirections[d, 0];
                    int dy = captureDirections[d, 1];
                    int targetX = x + dx;
                    int targetY = y + dy;
                    if (targetX >= 0 && targetX < 8 && targetY >= 0 && targetY < 8) {
                        if (chainCapturePiece.ValidMove(pieces, x, y, targetX, targetY)) {
                            forcedMoves.Add(new Move(x, y, targetX, targetY));
                        }
                    }
                }
            }
            ShuffleList(forcedMoves);
            return forcedMoves;
        }

        for (int x = 0; x < 8; x++) { // forced capture moves
            for (int y = 0; y < 8; y++) {
                Piece piece = pieces[x, y];
                if (piece != null && piece.isRed == forRed) {
                    if (piece.IsForcedToMove(pieces, x, y)) {
                        int[,] captureDirections = new int[,] { { 2, 2 }, { -2, 2 }, { 2, -2 }, { -2, -2 } };
                        for (int d = 0; d < captureDirections.GetLength(0); d++) {
                            int dx = captureDirections[d, 0];
                            int dy = captureDirections[d, 1];
                            int targetX = x + dx;
                            int targetY = y + dy;
                            if (targetX >= 0 && targetX < 8 && targetY >= 0 && targetY < 8) {
                                if (piece.ValidMove(pieces, x, y, targetX, targetY)) {
                                    forcedMoves.Add(new Move(x, y, targetX, targetY));
                                }
                            }
                        }
                    }
                }
            }
        }
        if (forcedMoves.Count > 0) {
            ShuffleList(forcedMoves);
            return forcedMoves;
        }

        for (int x = 0; x < 8; x++) { // all valid moves
            for (int y = 0; y < 8; y++) {
                Piece piece = pieces[x, y];
                if (piece != null && piece.isRed == forRed) {
                    int[,] directions = new int[,] { { 1, 1 }, { -1, 1 }, { 1, -1 }, { -1, -1 } };
                    for (int d = 0; d < directions.GetLength(0); d++) {
                        int dx = directions[d, 0];
                        int dy = directions[d, 1];
                        int targetX = x + dx;
                        int targetY = y + dy;
                        if (targetX >= 0 && targetX < 8 && targetY >= 0 && targetY < 8) {
                            if (piece.ValidMove(pieces, x, y, targetX, targetY)) {
                                validMoves.Add(new Move(x, y, targetX, targetY));
                            }
                        }
                    }
                }
            }
        }
        ShuffleList(validMoves);
        return validMoves;
    }

    /// <summary>
    /// Randomly shuffles the elements of a list
    /// </summary>
    /// <typeparam name="T">The type of the list elements</typeparam>
    /// <param name="list">The list to shuffle</param>
    private void ShuffleList<T>(List<T> list) {
        for (int i = list.Count - 1; i > 0; i--) {
            int rnd = Random.Range(0, i + 1);
            T temp = list[i];
            list[i] = list[rnd];
            list[rnd] = temp;
        }
    }

    /// <summary>
    /// Executes a move, handling piece movement, captures, promotions, and 
    /// turn switching, while returning a reward value
    /// </summary>
    /// <param name="move">The move to execute</param>
    /// <returns>A float representing the reward for the move</returns>
    public float ExecuteMove(Move move) {
        float reward = 0f;
        int x1 = move.startX, y1 = move.startY, x2 = move.targetX, y2 = move.targetY;
        Piece selectedPiece = pieces[x1, y1];
        if (selectedPiece == null)
            return -0.1f;
        if (!selectedPiece.ValidMove(pieces, x1, y1, x2, y2))
            return -0.1f;
        bool wasCapture = false;
        if (Mathf.Abs(x2 - x1) == 2) {
            int capX = (x1 + x2) / 2;
            int capY = (y1 + y2) / 2;
            if (pieces[capX, capY] != null) {
                Destroy(pieces[capX, capY].gameObject);
                pieces[capX, capY] = null;
                reward += 0.5f;
                wasCapture = true;
            }
        }

        pieces[x2, y2] = selectedPiece;
        pieces[x1, y1] = null;
        selectedPiece.transform.position = (Vector3.right * x2) + (Vector3.forward * y2) + boardOffSet + pieceOffSet;

        if (selectedPiece.isRed && !selectedPiece.isKing && y2 == 7) { // Promotion check
            Destroy(selectedPiece.gameObject);
            GameObject newKing = Instantiate(redKingPiecePrefab, transform);
            Piece kingComponent = newKing.GetComponent<Piece>();
            kingComponent.isRed = true;
            kingComponent.isKing = true;
            pieces[x2, y2] = kingComponent;
            kingComponent.transform.position = (Vector3.right * x2) + (Vector3.forward * y2) + boardOffSet + pieceOffSet;
            selectedPiece = kingComponent;
        } else if (!selectedPiece.isRed && !selectedPiece.isKing && y2 == 0) {
            Destroy(selectedPiece.gameObject);
            GameObject newKing = Instantiate(blackKingPiecePrefab, transform);
            Piece kingComponent = newKing.GetComponent<Piece>();
            kingComponent.isRed = false;
            kingComponent.isKing = true;
            pieces[x2, y2] = kingComponent;
            kingComponent.transform.position = (Vector3.right * x2) + (Vector3.forward * y2) + boardOffSet + pieceOffSet;
            selectedPiece = kingComponent;
        }
        reward += 0.1f;

        if (wasCapture && selectedPiece.IsForcedToMove(pieces, x2, y2)) {
            // Remain in chain capture mode
            chainCapturePiece = selectedPiece;
        } else {
            chainCapturePiece = null;
            isRedTurn = !isRedTurn;
        }
        return reward;
    }

    /// <summary>
    /// Checks for victory by verifying if either team has no remaining pieces
    /// </summary>
    /// <returns>Returns -1 if red loses, 1 if black loses, or 0 if no victory 
    /// condition is met</returns>
    public int CheckVictory() {
        bool hasRedPieces = false, hasBlackPieces = false;
        for (int x = 0; x < 8; x++) {
            for (int y = 0; y < 8; y++) {
                if (pieces[x, y] != null) {
                    if (pieces[x, y].isRed) hasRedPieces = true; else hasBlackPieces = true;
                }
            }
        }
        if (!hasRedPieces) return -1;
        if (!hasBlackPieces) return 1;
        return 0;
    }

    /// <summary>
    /// Updates the score UI to reflect the current scores of red and black teams
    /// </summary>
    private void UpdateScoreUI() {
        redScoreText.text = redScore.ToString();
        blackScoreText.text = blackScore.ToString();
    }

    /// <summary>
    /// Resets the game by clearing scores, updating the score UI, and resetting the board
    /// </summary>
    public void ResetButton() {
        redScore = 0;
        blackScore = 0;
        UpdateScoreUI();
        ResetBoard();
    }

}
