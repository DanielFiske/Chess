using ChessBackend.Domain.Entities;

namespace ChessBackend.Application.Services
{
    public class ChessService
    {
        public ChessGame GetGameState()
        {
            // Return the current state of the chess game
            return new ChessGame();
        }

        public bool MakeMove(MoveDto move)
        {
            // Handle making a move in the chess game
            return true;
        }
    }

    public class MoveDto
    {
        public string From { get; set; }
        public string To { get; set; }
    }
}