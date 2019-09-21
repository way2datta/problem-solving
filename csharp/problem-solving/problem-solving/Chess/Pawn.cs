using System.Collections.Generic;

namespace ProblemSolving.Chess
{
    internal class Pawn : IPiece
    {
        public IEnumerable<Position> GetPossiblePositions(Position startingPosition)
        {
            return new Position[] {
                new Position{
                    RankIndex = startingPosition.RankIndex,
                    FileIndex = startingPosition.FileIndex + 1
                }
            };
        }
    }
}