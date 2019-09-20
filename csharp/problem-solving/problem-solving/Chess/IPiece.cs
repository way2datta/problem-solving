using System;
using System.Collections.Generic;

namespace ProblemSolving.Chess
{
    internal interface IPiece
    {
        IEnumerable<Position> GetPossiblePositions(Position startingPosition);
    }
}