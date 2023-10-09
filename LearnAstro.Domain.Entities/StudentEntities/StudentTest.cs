using LearnAstro.Domain.Core;

namespace LearnAstro.Domain.Entities.StudentEntities
{
    public sealed class StudentTest : Test
    {
        #region Constructors

        public StudentTest(int id, Test test, bool isPassed = false, byte pointsScored = 0,
            List<StudentTestQuestion>? testQuestions = null) : base(test)
        {
            Id = id;
            IsPassed = isPassed;
            PointsScored = pointsScored;
            TestQuestions = testQuestions;
        }

        #endregion

        #region Properties

        public bool IsPassed { get; private set; }

        public byte PointsScored { get; private set; }

        public new List<StudentTestQuestion>? TestQuestions { get; set; }

        #endregion

        #region Public methods

        public void UpdateTestResults()
        {
            if (TestQuestions == null) throw new Exception("Test questions are not loaded.");
            updatePointsScored(TestQuestions);
            updateIsPassed();
        }

        #endregion

        #region Private methods

        private void updatePointsScored(List<StudentTestQuestion> testQuestions)
        {
            byte pointsScored = 0;
            testQuestions.ForEach(q => pointsScored += q.PointsScored);
            PointsScored = pointsScored;
        }

        private void updateIsPassed()
        {
            IsPassed = PointsScored >= MinimumScoreForPassing;
        }

        #endregion
    }
}