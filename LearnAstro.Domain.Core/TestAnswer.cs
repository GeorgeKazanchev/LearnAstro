namespace LearnAstro.Domain.Core
{
    public class TestAnswer
    {
        #region Constructors

        public TestAnswer(int id, string content)
        {
            Id = id;
            Content = content;
        }

        public TestAnswer(TestAnswer source)
        {
            Id = source.Id;
            Content = source.Content;
        }

        #endregion

        #region Properties

        public int Id { get; protected set; }

        public string Content { get; }

        #endregion
    }
}