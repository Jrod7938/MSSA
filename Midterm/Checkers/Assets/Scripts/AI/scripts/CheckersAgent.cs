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

    public override void OnEpisodeBegin() {
        board.ResetBoard();
        board.isRedTurn = true; // Always start with red turn
    }

    public override void CollectObservations(VectorSensor sensor) {
        int[,] state = board.GetBoardState(); // Get the board state as an 8x8 integer grid
        for (int y = 0; y < 8; y++) { // Flatten the grid (64 observations)
            for (int x = 0; x < 8; x++) {
                sensor.AddObservation(state[x, y]);
            }
        }
        // Add one extra binary observation indicating if it is this agent's turn
        sensor.AddObservation(board.isRedTurn == isRedAgent ? 1 : 0);
    }

    public override void OnActionReceived(ActionBuffers actions) {
        if (board.isRedTurn != isRedAgent) return; // Only act if it is this agent's turn

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

    public override void Heuristic(in ActionBuffers actionsOut) {
        // For manual testing, choose a random valid move
        List<Move> validMoves = board.GetValidMoves(isRedAgent);
        int randomAction = validMoves.Count > 0 ? Random.Range(0, validMoves.Count) : 0;
        actionsOut.DiscreteActions.Array[0] = randomAction;
    }
}
