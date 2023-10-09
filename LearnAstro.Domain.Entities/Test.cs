namespace LearnAstro.Domain.Core
{
    public class Test
    {
        #region Constructors

        public Test(int id, byte minimumScoreForPassing, List<TestQuestion>? testQuestions = null)
        {
            Id = id;
            MinimumScoreForPassing = minimumScoreForPassing;
            TestQuestions = testQuestions;
        }

        public Test(Test source)
        {
            Id = source.Id;
            MinimumScoreForPassing = source.MinimumScoreForPassing;
            TestQuestions = source.TestQuestions;
        }

        #endregion

        #region Properties

        public int Id { get; protected set; }

        public byte MinimumScoreForPassing { get; }

        public List<TestQuestion>? TestQuestions { get; }

        #endregion
    }
}