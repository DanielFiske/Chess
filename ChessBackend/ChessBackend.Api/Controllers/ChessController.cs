using ChessBackend.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace ChessBackend.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChessController : ControllerBase
    {
        private readonly ChessService _chessService;

        public ChessController(ChessService chessService)
        {
            _chessService = chessService;
        }

        [HttpGet]
        public IActionResult GetGameState()
        {
            // Get the current state of the chess game
            var gameState = _chessService.GetGameState();
            return Ok(gameState);
        }

        [HttpPost]
        public IActionResult MakeMove([FromBody] MoveDto move)
        {
            // Make a move in the chess game
            var result = _chessService.MakeMove(move);
            return Ok(result);
        }
    }
}