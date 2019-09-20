using System;

namespace ProblemSolving.Chess
{
    internal class PieceCreator
    {
        internal static IPiece Create(string pieceName)
        {
            switch (pieceName.ToLower())
            {
                case "pawn":
                    return new Pawn();
                default:
                    throw new ArgumentException("Invalid args: piece name");
            }
        }
    }
}