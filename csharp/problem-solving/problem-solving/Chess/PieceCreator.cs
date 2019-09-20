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
                case "rook":
                    return new Rook();
                default:
                    throw new ArgumentException("Invalid args: piece name");
            }
        }
    }
}