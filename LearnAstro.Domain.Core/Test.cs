namespace LearnAstro.Domain.Core
{
    public class Test
    {
        #region Constructors

        public Test(int id, List<TestQuestion>? testQuestions = null)
        {
            Id = id;
            TestQuestions = testQuestions;
        }

        public Test(Test source)
        {
            Id = source.Id;
            TestQuestions = source.TestQuestions;
        }

        #endregion

        #region Properties

        public int Id { get; protected set; }

        public List<TestQuestion>? TestQuestions { get; }

        #endregion
    }
}