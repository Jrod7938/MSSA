public interface ICheckersBoard {
    void ResetBoard();
    int[,] GetBoardState();
    System.Collections.Generic.List<Move> GetValidMoves(bool forRed);
    float ExecuteMove(Move move);
    int CheckVictory();
    bool isRedTurn { get; set; }
}
