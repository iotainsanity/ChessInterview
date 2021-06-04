using ChessInterview.Entities.Factory;
using ChessInterview.Entities.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessInterview.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestKingMoves()
        {
            var king = ChessPieceFactory.GetChessPiece(Entities.Models.PieceType.King, "a1");

            Assert.AreEqual("b2,a2,b1", new MoveEngine().GetMovesAsCSV(king));
        }
    }
}
