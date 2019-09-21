using System.Collections.Generic;

namespace ProblemSolving.Chess
{
    internal class Horse : IPiece
    {
        public IEnumerable<Position> GetPossiblePositions(Position startingPosition)
        {
            var possiblePositionsByRank = GetPossiblePositionsByRank(startingPosition);

            var possiblePositionsByFile = GetPossiblePositionsByFile(startingPosition);

            possiblePositionsByRank.AddRange(possiblePositionsByFile);

            return possiblePositionsByRank;
        }

        private static List<Position> GetPossiblePositionsByFile(Position startingPosition)
        {
            var currentRankIndex = startingPosition.RankIndex;
            var currentFileIndex = startingPosition.FileIndex;

            var possibleFileIndex = currentRankIndex + 2;
            var possiblePositions = new List<Position>();

            if (0 <= possibleFileIndex && possibleFileIndex <= 7)
            {
                if (0 <= currentRankIndex + 1 && currentRankIndex + 1 <= 7)
                {
                    possiblePositions.Add(new Position { RankIndex = currentRankIndex + 1, FileIndex = possibleFileIndex });
                }
                if (0 <= currentRankIndex - 1 && currentRankIndex - 1 <= 7)
                {
                    possiblePositions.Add(new Position { RankIndex = currentRankIndex - 1, FileIndex = possibleFileIndex });
                }
            }

            possibleFileIndex = currentFileIndex - 2;

            if (0 <= possibleFileIndex && possibleFileIndex <= 7)
            {
                if (0 <= currentRankIndex + 1 && currentRankIndex + 1 <= 7)
                {
                    possiblePositions.Add(new Position { RankIndex = currentRankIndex + 1, FileIndex = possibleFileIndex });
                }
                if (0 <= currentRankIndex - 1 && currentRankIndex - 1 <= 7)
                {
                    possiblePositions.Add(new Position { RankIndex = currentRankIndex - 1, FileIndex = possibleFileIndex });
                }
            }

            return possiblePositions;
        }

        private static List<Position> GetPossiblePositionsByRank(Position startingPosition)
        {
            var currentRankIndex = startingPosition.RankIndex;
            var currentFileIndex = startingPosition.FileIndex;

            var possibleRankIndex = currentRankIndex + 2;
            var possiblePositions = new List<Position>();

            if (0 <= possibleRankIndex && possibleRankIndex <= 7)
            {
                if (0 <= currentFileIndex + 1 && currentFileIndex + 1 <= 7)
                {
                    possiblePositions.Add(new Position { RankIndex = possibleRankIndex, FileIndex = currentFileIndex + 1 });
                }
                if (0 <= currentFileIndex - 1 && currentFileIndex - 1 <= 7)
                {
                    possiblePositions.Add(new Position { RankIndex = possibleRankIndex, FileIndex = currentFileIndex - 1 });
                }
            }

            possibleRankIndex = currentRankIndex - 2;

            if (0 <= possibleRankIndex && possibleRankIndex <= 7)
            {
                if (0 <= currentFileIndex + 1 && currentFileIndex + 1 <= 7)
                {
                    possiblePositions.Add(new Position { RankIndex = possibleRankIndex, FileIndex = currentFileIndex + 1 });
                }
                if (0 <= currentFileIndex - 1 && currentFileIndex - 1 <= 7)
                {
                    possiblePositions.Add(new Position { RankIndex = possibleRankIndex, FileIndex = currentFileIndex - 1 });
                }
            }

            return possiblePositions;
        }
    }
}