namespace LearnAstro.Domain.Core
{
    public sealed class StudentTestQuestion : TestQuestion
    {
        #region Constructors
        
        public StudentTestQuestion(int id, TestQuestion testQuestion, byte? givenAnswerIndex = null) 
            : base(testQuestion)
        {
            Id = id;
            GivenAnswerIndex = givenAnswerIndex;
        }

        #endregion

        #region Properties

        public byte? GivenAnswerIndex { get; }

        #endregion
    }
}