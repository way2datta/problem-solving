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
                case "bishop":
                    return new Bishop();
                case "queen":
                    return new Queen();
                case "king":
                    return new King();
                default:
                    throw new ArgumentException("Invalid args: piece name");
            }
        }
    }
}