using System;
using System.Collections.Generic;

namespace ProblemSolving.Chess
{
    internal class Pawn : IPiece
    {
        public IEnumerable<Position> GetPossiblePositions(Position startingPosition)
        {
            ValidatePosition(startingPosition);

            return new Position[] {
                new Position{
                    RankIndex = startingPosition.RankIndex,
                    FileIndex = startingPosition.FileIndex + 1
                }
            };
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