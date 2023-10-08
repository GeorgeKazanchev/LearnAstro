﻿namespace LearnAstro.Domain.Core
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