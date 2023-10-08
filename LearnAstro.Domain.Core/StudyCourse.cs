namespace LearnAstro.Domain.Core
{
    public class StudyCourse
    {
        #region Constructors

        public StudyCourse(int id, string name, string description, bool isNecessary,
            CourseProject? project = null, Test? finalTest = null, List<StudySession>? studySessions = null)
        {
            Id = id;
            Name = name;
            Description = description;
            IsNecessary = isNecessary;
            Project = project;
            FinalTest = finalTest;
            StudySessions = studySessions;
        }

        public StudyCourse(StudyCourse source)
        {
            Id = source.Id;
            Name = source.Name;
            Description = source.Description;
            IsNecessary = source.IsNecessary;
            Project = source.Project;
            FinalTest = source.FinalTest;
            StudySessions = source.StudySessions;
        }

        #endregion

        #region Properties

        public int Id { get; protected set; }

        public string Name { get; }

        public string Description { get; }

        public bool IsNecessary { get; }

        public CourseProject? Project { get; }

        public Test? FinalTest { get; }

        public List<StudySession>? StudySessions { get; }

        #endregion
    }
}