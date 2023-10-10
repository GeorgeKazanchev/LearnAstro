namespace LearnAstro.Domain.Core
{
    public class CourseProject
    {
        #region Constructors

        public CourseProject(int id, List<PracticalTask>? practicalTasks = null)
        {
            Id = id;
            PracticalTasks = practicalTasks;
        }

        public CourseProject(CourseProject source)
        {
            Id = source.Id;
            PracticalTasks = source.PracticalTasks;
        }

        #endregion

        #region Properties

        public int Id { get; protected set; }

        public List<PracticalTask>? PracticalTasks { get; }

        #endregion
    }
}