using System.Collections.Generic;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;
using UnityEngine;

public class CheckersAgent : Agent {
    [Header("Agent Settings")]
    [Tooltip("If true, this agent controls the red pieces; if false, it controls black.")]
    public bool isRedAgent = true;

    [Header("Environment Reference")]
    [Tooltip("Reference to the CheckersBoard environment implementing ICheckersBoard.")]
    public MonoBehaviour boardComponent;

    [Header("Mode Settings")]
    [Tooltip("Set to true during training (episodes will end on victory); set to false for inference/solo play.")]
    public bool trainingMode = false;

    private ICheckersBoard board;

    /// <summary>
    /// Initializes the agent by acquiring a reference to the checkers board environment
    /// It first checks the provided boardComponent, and if not found, attempts to locate 
    /// one in the scene
    /// </summary>
    public override void Initialize() {
        if (boardComponent != null) {
            board = boardComponent as ICheckersBoard;
        }
        if (board == null) {
            board = FindFirstObjectByType<CheckersBoardAI>() as ICheckersBoard;
            if (board == null) {
                board = FindFirstObjectByType<CheckersBoard>() as ICheckersBoard;
            }
        }
    }

    /// <summary>
    /// Resets the board and sets the turn to red at the beginning of each episode
    /// </summary>
    public override void OnEpisodeBegin() {
        board.ResetBoard();
        board.isRedTurn = true; // Always start with red turn
    }

    /// <summary>
    /// Collects observations from the environment by flattening the board state into 64 
    /// integer observations, followed by a binary observation indicating if it is the 
    /// agent's turn
    /// </summary>
    /// <param name="sensor">The sensor that collects observations</param>
    public override void CollectObservations(VectorSensor sensor) {
        int[,] state = board.GetBoardState(); // Get the board state as an 8x8 integer grid
        for (int y = 0; y < 8; y++) { // Flatten the grid (64 observations)
            for (int x = 0; x < 8; x++) {
                sensor.AddObservation(state[x, y]);
            }
        }
        // agent's turn
        sensor.AddObservation(board.isRedTurn == isRedAgent ? 1 : 0);
    }

    /// <summary>
    /// Processes the agent's chosen action by verifying if it's the agent's turn, selecting 
    /// a move from the list of valid moves, executing the move, awarding rewards, and 
    /// checking for victory conditions
    /// </summary>
    /// <param name="actions">The actions received from the policy</param>
    public override void OnActionReceived(ActionBuffers actions) {
        if (board.isRedTurn != isRedAgent) return; // Only act on agent's turn

        List<Move> validMoves = board.GetValidMoves(isRedAgent);
        if (validMoves.Count == 0) {
            // No valid moves: penalize and end the episode
            if (trainingMode) {
                SetReward(-1f);
                EndEpisode();
            }
            return;
        }

        int action = actions.DiscreteActions[0];
        if (action < 0 || action >= validMoves.Count) {
            // Out-of-range action: penalize and end the episode
            if (trainingMode) {
                AddReward(-0.2f);
                EndEpisode();
            }
            return;
        }

        Move chosenMove = validMoves[action];
        float reward = board.ExecuteMove(chosenMove);
        AddReward(reward);

        int victor = board.CheckVictory();
        if (victor != 0) {
            if ((victor == 1 && isRedAgent) || (victor == -1 && !isRedAgent)) {
                // Correct victory
                AddReward(1f);
            } else {
                AddReward(-1f);
            }
            if (trainingMode) {
                EndEpisode();
            }
            return;
        }
    }

    /// <summary>
    /// Provides a heuristic for manual testing by selecting a random valid move
    /// </summary>
    /// <param name="actionsOut">The output action buffer where the chosen action is stored</param>
    public override void Heuristic(in ActionBuffers actionsOut) {
        // For manual testing, choose a random valid move
        List<Move> validMoves = board.GetValidMoves(isRedAgent);
        int randomAction = validMoves.Count > 0 ? Random.Range(0, validMoves.Count) : 0;
        actionsOut.DiscreteActions.Array[0] = randomAction;
    }

}
