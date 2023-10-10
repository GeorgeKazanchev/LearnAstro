using LearnAstro.Domain.Core;

namespace LearnAstro.Domain.Entities.StudentEntities
{
    public sealed class StudentCourseProject : CourseProject
    {
        #region Constructors

        public StudentCourseProject(int id, CourseProject project, List<StudentPracticalTask>? practicalTasks = null) 
            : base(project)
        {
            Id = id;
            PracticalTasks = practicalTasks;
        }

        #endregion

        #region Properties

        public new List<StudentPracticalTask>? PracticalTasks { get; set; }

        #endregion
    }
}