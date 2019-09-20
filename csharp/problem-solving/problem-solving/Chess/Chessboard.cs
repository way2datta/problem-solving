using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSolving.Chess
{
    public class Chessboard
    {
        public IEnumerable<Position> GetPossiblePositions(Position startingPosition, string pieceName)
        {
            IPiece piece = PieceCreator.Create(pieceName);
            
            return piece.GetPossiblePositions(startingPosition);
        }
    }
}
