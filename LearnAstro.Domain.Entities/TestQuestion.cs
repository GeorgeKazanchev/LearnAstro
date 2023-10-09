namespace LearnAstro.Domain.Core
{
    public class TestQuestion
    {
        #region Constructors

        public TestQuestion(int id, byte number, string content, byte pointsForCorrectAnswer, byte correctAnswerIndex,
            TestAnswer[] answerVariants)
        {
            if (correctAnswerIndex >= answerVariants.Length)
            {
                throw new Exception("The correct answer is not presented among the answer variants.");
            }

            Id = id;
            Number = number;
            Content = content;
            PointsForCorrectAnswer = pointsForCorrectAnswer;
            CorrectAnswerIndex = correctAnswerIndex;
            AnswerVariants = answerVariants;
        }

        public TestQuestion(TestQuestion source)
        {
            Id = source.Id;
            Number = source.Number;
            Content = source.Content;
            PointsForCorrectAnswer = source.PointsForCorrectAnswer;
            CorrectAnswerIndex = source.CorrectAnswerIndex;
            AnswerVariants = source.AnswerVariants;
        }

        #endregion

        #region Properties

        public int Id { get; protected set; }

        public byte Number { get; }

        public string Content { get; }

        public byte PointsForCorrectAnswer { get; }

        public byte CorrectAnswerIndex { get; }

        public TestAnswer[] AnswerVariants { get; }

        #endregion
    }
}