namespace LearnAstro.Domain.Core
{
    public class StudyBlock
    {
        #region Constructors

        public StudyBlock(int id, string name, string description, byte level, StudyBlock? prerequisiteBlock = null,
            BlockProject? project = null, List<StudyCourse>? studyCourses = null)
        {
            Id = id;
            Name = name;
            Description = description;
            Level = level;
            PrerequisiteBlock = prerequisiteBlock;
            Project = project;
            StudyCourses = studyCourses;
        }

        public StudyBlock(StudyBlock source)
        {
            Id = source.Id;
            Name = source.Name;
            Description = source.Description;
            Level = source.Level;
            PrerequisiteBlock = source.PrerequisiteBlock;
            Project = source.Project;
            StudyCourses = source.StudyCourses;
        }

        #endregion

        #region Properties

        public int Id { get; protected set; }

        public string Name { get; }

        public string Description { get; }

        public byte Level { get; }

        public StudyBlock? PrerequisiteBlock { get; }

        public BlockProject? Project { get; }

        public List<StudyCourse>? StudyCourses { get; }

        #endregion
    }
}