using ChessInterview.Entities.Factory;
using ChessInterview.Entities.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChessInterview.API.Controllers
{
    [ApiController]
    [Route("controller")]
    public class MoveEngineController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public string GetValidMoves(PieceType pieceType, string xy)
        {
            return new MoveEngine().GetMovesAsCSV(ChessPieceFactory.GetChessPiece(pieceType, xy));
        }
    }
}
