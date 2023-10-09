namespace LearnAstro.Domain.Core
{
    public class PracticalTask
    {
        #region Constructors

        public PracticalTask(int id, short number, string description)
        {
            Id = id;
            Number = number;
            Description = description;
        }

        public PracticalTask(PracticalTask source)
        {
            Id = source.Id;
            Number = source.Number;
            Description = source.Description;
        }

        #endregion

        #region Properties

        public int Id { get; protected set; }

        public short Number { get; }

        public string Description { get; }

        #endregion
    }
}