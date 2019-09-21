using System.Collections.Generic;

namespace ProblemSolving.Chess
{
    internal class Queen : IPiece
    {
        public IEnumerable<Position> GetPossiblePositions(Position startingPosition)
        {
            var rightDiagonalPositions = GetRightDiagonalPositions(startingPosition);
            var leftDiagonalPositions = GetLeftDiagonalPositions(startingPosition);
            var horizontalPositions = GetHorizontalPositions(startingPosition);
            var verticalPositions = GetVerticalPositions(startingPosition);


            rightDiagonalPositions.AddRange(leftDiagonalPositions);
            rightDiagonalPositions.AddRange(horizontalPositions);
            rightDiagonalPositions.AddRange(verticalPositions);

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

            while (currentRankIndex <7 && currentFileIndex > 0)
            {
                currentRankIndex++;
                currentFileIndex--;

                leftDiagonalPositions.Add(new Position { RankIndex = currentRankIndex, FileIndex = currentFileIndex });
            }

            return leftDiagonalPositions;
        }
        private static List<Position> GetHorizontalPositions(Position startingPosition)
        {
            var horizontalPositions = new List<Position>();
            var currentRankIndex = startingPosition.RankIndex;

            while (currentRankIndex < 7)
            {
                currentRankIndex++;
                horizontalPositions.Add(new Position { FileIndex = startingPosition.FileIndex, RankIndex = currentRankIndex });
            }

            currentRankIndex = startingPosition.RankIndex;

            while (currentRankIndex > 0)
            {
                currentRankIndex--;
                horizontalPositions.Add(new Position { FileIndex = startingPosition.FileIndex, RankIndex = currentRankIndex });
            }
            return horizontalPositions;
        }

        private static List<Position> GetVerticalPositions(Position startingPosition)
        {
            var verticalPositions = new List<Position>();
            var currentFileIndex = startingPosition.FileIndex;

            while (currentFileIndex < 7)
            {
                currentFileIndex++;
                verticalPositions.Add(new Position { FileIndex = currentFileIndex, RankIndex = startingPosition.RankIndex });
            }

            currentFileIndex = startingPosition.RankIndex;

            while (currentFileIndex > 0)
            {
                currentFileIndex--;
                verticalPositions.Add(new Position { FileIndex = currentFileIndex, RankIndex = startingPosition.RankIndex });
            }
            return verticalPositions;
        }
    }
}