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
            ValidatePosition(startingPosition);
            IPiece piece = PieceCreator.Create(pieceName);
            return piece.GetPossiblePositions(startingPosition);
        }

        private void ValidatePosition(Position position)
        {
            if (position.RankIndex < 0 || position.RankIndex > 7)
            {
                throw new ApplicationException("Invalid rank index.");
            }
            if (position.FileIndex < 0 || position.FileIndex > 7)
            {
                throw new ApplicationException("Invalid file index.");
            }
        }
    }
}
