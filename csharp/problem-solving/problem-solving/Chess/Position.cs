namespace ProblemSolving.Chess
{
    public class Position
    {
        private static string rankDisplayText = "ABCDEFGH";
        private static string fileDisplayText = "12345678";

        public int RankIndex { get; set; }
        public int FileIndex { get; set; }

        public override string ToString()
        {
            return $"{rankDisplayText[RankIndex]}{fileDisplayText[FileIndex]}";
        }
    }
}