using LearnAstro.Domain.Core;

namespace LearnAstro.Domain.Entities.StudentEntities
{
    public sealed class StudentTestQuestion : TestQuestion
    {
        #region Constructors

        public StudentTestQuestion(int id, TestQuestion testQuestion, byte pointsScored = 0, byte? givenAnswerIndex = null)
            : base(testQuestion)
        {
            Id = id;
            PointsScored = pointsScored;
            GivenAnswerIndex = givenAnswerIndex;
        }

        #endregion

        #region Properties

        public byte PointsScored { get; private set; }

        public byte? GivenAnswerIndex { get; }

        #endregion

        #region Public methods

        public void UpdatePointsScored()
        {
            if (GivenAnswerIndex == null) throw new Exception("The question is not answered.");
            PointsScored = GivenAnswerIndex == CorrectAnswerIndex ? PointsForCorrectAnswer : (byte)0;
        }

        #endregion
    }
}