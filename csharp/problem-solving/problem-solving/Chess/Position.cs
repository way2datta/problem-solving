namespace ProblemSolving.Chess
{
    public class Position
    {
        public int RankIndex { get; set; }
        public int FileIndex { get; set; }

        public override string ToString()
        {
            return $"Rank: {RankIndex}, File: {FileIndex}";
        }
    }
}