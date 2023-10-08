namespace LearnAstro.Domain.Core
{
    public class CourseProject
    {
        #region Constructors

        public CourseProject(int id)
        {
            Id = id;
        }

        public CourseProject(CourseProject source)
        {
            Id = source.Id;
        }

        #endregion

        #region Properties

        public int Id { get; protected set; }

        #endregion
    }
}