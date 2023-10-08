namespace LearnAstro.Domain.Core
{
    public class BlockProject
    {
        #region Constructors

        public BlockProject(int id)
        {
            Id = id;
        }

        public BlockProject(BlockProject source)
        {
            Id = source.Id;
        }

        #endregion

        #region Properties

        public int Id { get; protected set; }

        #endregion
    }
}