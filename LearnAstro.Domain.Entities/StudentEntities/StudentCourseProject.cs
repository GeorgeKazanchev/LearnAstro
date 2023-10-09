using LearnAstro.Domain.Core;

namespace LearnAstro.Domain.Entities.StudentEntities
{
    public sealed class StudentCourseProject : CourseProject
    {
        #region Constructors

        public StudentCourseProject(int id, CourseProject project) : base(project)
        {
            Id = id;
        }

        #endregion
    }
}