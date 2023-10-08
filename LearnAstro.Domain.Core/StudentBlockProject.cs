namespace LearnAstro.Domain.Core
{
    public sealed class StudentBlockProject : BlockProject
    {
        #region Constructors

        public StudentBlockProject(int id, BlockProject project) : base(project)
        {
            Id = id;
        }

        #endregion
    }
}