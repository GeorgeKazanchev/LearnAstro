using LearnAstro.Domain.Core;

namespace LearnAstro.Domain.Entities.StudentEntities
{
    public sealed class StudentStudyBlock : StudyBlock
    {
        #region Конструкторы

        public StudentStudyBlock(int id, StudyBlock studyBlock, bool isEnabled, bool isPassed,
            StudentStudyBlock? prerequisiteBlock = null, StudentBlockProject? project = null,
            List<StudentStudyCourse>? studyCourses = null) : base(studyBlock)
        {
            Id = id;
            IsEnabled = isEnabled;
            IsPassed = isPassed;
            PrerequisiteBlock = prerequisiteBlock;
            Project = project;
            StudyCourses = studyCourses;
        }

        #endregion

        #region Свойства

        public bool IsEnabled { get; } = false;

        public bool IsPassed { get; } = false;

        public new StudentStudyBlock? PrerequisiteBlock { get; }

        public new StudentBlockProject? Project { get; }

        public new List<StudentStudyCourse>? StudyCourses { get; }

        #endregion
    }
}