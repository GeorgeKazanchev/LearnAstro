using LearnAstro.Domain.Core;

namespace LearnAstro.Domain.Entities.StudentEntities
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