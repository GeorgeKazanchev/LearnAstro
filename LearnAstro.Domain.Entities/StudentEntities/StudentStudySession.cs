﻿using LearnAstro.Domain.Core;

namespace LearnAstro.Domain.Entities.StudentEntities
{
    public sealed class StudentStudySession : StudySession
    {
        #region Constructors

        public StudentStudySession(int id, StudySession studySession, bool isEnabled, StudentTest? test = null)
            : base(studySession)
        {
            Id = id;
            IsEnabled = isEnabled;
            Test = test;
        }

        #endregion

        #region Properties

        public bool IsEnabled { get; } = false;

        public new StudentTest? Test { get; set; }

        #endregion
    }
}