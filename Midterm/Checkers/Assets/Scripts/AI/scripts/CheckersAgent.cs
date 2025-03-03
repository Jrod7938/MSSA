using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;
using UnityEngine;
using System.Collections.Generic;

public class CheckersAgent : Agent {
    [Header("Agent Settings")]
    [Tooltip("If true, this agent controls the red pieces; if false, it controls black.")]
    public bool isRedAgent = true;

    [Header("Environment Reference")]
    [Tooltip("Reference to the CheckersBoardAI environment.")]
    public CheckersBoardAI board;

    public override void Initialize() {
        if (board == null) {
            board = FindFirstObjectByType<CheckersBoardAI>();
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
        
        sensor.AddObservation(board.isRedTurn == isRedAgent ? 1 : 0); // binary observation indicating agent's turn
    }

    public override void OnActionReceived(ActionBuffers actions) {
        
        if (board.isRedTurn != isRedAgent) return; // Only act if it is this agent's turn

        List<Move> validMoves = board.GetValidMoves(isRedAgent);
        if (validMoves.Count == 0) {
            // No valid moves: penalize and end the episode
            SetReward(-1f);
            EndEpisode();
            return;
        }

        int action = actions.DiscreteActions[0];
        if (action < 0 || action >= validMoves.Count) {
            // Out-of-range action
            AddReward(-0.2f);
            return;
        }

        Move chosenMove = validMoves[action];
        float reward = board.ExecuteMove(chosenMove);
        AddReward(reward);

        int victor = board.CheckVictory();
        if (victor != 0) {
            if ((victor == 1 && isRedAgent) || (victor == -1 && !isRedAgent)) { // victor: 1 means red wins, -1 means black wins
                AddReward(1f);
            } else {
                AddReward(-1f);
            }
            EndEpisode();
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
