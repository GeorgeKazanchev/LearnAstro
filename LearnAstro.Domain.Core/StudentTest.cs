namespace LearnAstro.Domain.Core
{
    public sealed class StudentTest : Test
    {
        #region Constructors

        public StudentTest(int id, Test test, bool isPassed, byte? pointsScored = null,
            List<StudentTestQuestion>? testQuestions = null) : base(test)
        {
            Id = id;
            IsPassed = isPassed;
            PointsScored = pointsScored;
            TestQuestions = testQuestions;
        }

        #endregion

        #region Properties

        public bool IsPassed { get; } = false;

        public byte? PointsScored { get; }

        public new List<StudentTestQuestion>? TestQuestions { get; }

        #endregion
    }
}