using System.Collections.Generic;

namespace ProblemSolving.Chess
{
    internal class Bishop : IPiece
    {
        public IEnumerable<Position> GetPossiblePositions(Position startingPosition)
        {
            var rightDiagonalPositions = GetRightDiagonalPositions(startingPosition);
            var leftDiagonalPositions = GetLeftDiagonalPositions(startingPosition);

            rightDiagonalPositions.AddRange(leftDiagonalPositions);
            return rightDiagonalPositions;
        }

        private static List<Position> GetRightDiagonalPositions(Position startingPosition)
        {
            var rightDiagonalPositions = new List<Position>();

            var currentRankIndex = startingPosition.RankIndex;
            var currentFileIndex = startingPosition.FileIndex;

            while (currentRankIndex < 7 && currentFileIndex < 7)
            {
                currentRankIndex++;
                currentFileIndex++;

                rightDiagonalPositions.Add(new Position { RankIndex = currentRankIndex, FileIndex = currentFileIndex });
            }

            currentRankIndex = startingPosition.RankIndex;
            currentFileIndex = startingPosition.FileIndex;

            while (currentRankIndex > 0 && currentFileIndex > 0)
            {
                currentRankIndex--;
                currentFileIndex--;

                rightDiagonalPositions.Add(new Position { RankIndex = currentRankIndex, FileIndex = currentFileIndex });
            }

            return rightDiagonalPositions;
        }

        private static List<Position> GetLeftDiagonalPositions(Position startingPosition)
        {
            var leftDiagonalPositions = new List<Position>();

            var currentRankIndex = startingPosition.RankIndex;
            var currentFileIndex = startingPosition.FileIndex;

            while (currentRankIndex > 0 && currentFileIndex < 7)
            {
                currentRankIndex--;
                currentFileIndex++;

                leftDiagonalPositions.Add(new Position { RankIndex = currentRankIndex, FileIndex = currentFileIndex });
            }

            currentRankIndex = startingPosition.RankIndex;
            currentFileIndex = startingPosition.FileIndex;

            while (currentRankIndex < 7 && currentFileIndex > 0)
            {
                currentRankIndex++;
                currentFileIndex--;

                leftDiagonalPositions.Add(new Position { RankIndex = currentRankIndex, FileIndex = currentFileIndex });
            }

            return leftDiagonalPositions;
        }
    }
}