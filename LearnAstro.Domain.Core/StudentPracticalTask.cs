﻿namespace LearnAstro.Domain.Core
{
    public sealed class StudentPracticalTask : PracticalTask
    {
        #region Constructors

        public StudentPracticalTask(int id, PracticalTask practicalTask, bool isCompleted) : base(practicalTask)
        {
            Id = id;
            IsCompleted = isCompleted;
        }

        #endregion

        #region Properties

        public bool IsCompleted { get; } = false;

        #endregion
    }
}