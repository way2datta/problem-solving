using System;
using System.Collections.Generic;

namespace ProblemSolving.Chess
{
    internal class Rook : IPiece
    {
        public IEnumerable<Position> GetPossiblePositions(Position startingPosition)
        {
            var horizontalPositions =  GetHorizontalPositions(startingPosition);
            var verticalPositions = GetVerticalPositions(startingPosition);

            horizontalPositions.AddRange(verticalPositions);
            return horizontalPositions;
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