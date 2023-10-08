namespace LearnAstro.Domain.Core
{
    public sealed class StudentStudyCourse : StudyCourse
    {
        #region Constructors

        public StudentStudyCourse(int id, StudyCourse studyCourse, bool isPassed, byte pointsCount,
            StudentCourseProject? project = null, StudentTest? finalTest = null, List<StudentStudySession>? studySessions = null) 
            : base(studyCourse)
        {
            Id = id;
            IsPassed = isPassed;
            PointsCount = pointsCount;
            Project = project;
            FinalTest = finalTest;
            StudySessions = studySessions;
        }

        #endregion

        #region Properties

        public bool IsPassed { get; } = false;

        public byte PointsCount { get; } = 0;

        public new StudentCourseProject? Project { get; }

        public new StudentTest? FinalTest { get; }

        public new List<StudentStudySession>? StudySessions { get; }

        #endregion
    }
}