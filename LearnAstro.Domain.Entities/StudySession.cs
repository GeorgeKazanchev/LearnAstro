using LearnAstro.Domain.Entities;

namespace LearnAstro.Domain.Core
{
    public class StudySession
    {
        #region Constructors

        public StudySession(int id, string name, byte number, string description, 
            ITheoreticalMaterial? theoreticalMaterial = null, Test? test = null)
        {
            Id = id;
            Name = name;
            Number = number;
            Description = description;
            TheoreticalMaterial = theoreticalMaterial;
            Test = test;
        }

        public StudySession(StudySession source)
        {
            Id = source.Id;
            Name = source.Name;
            Number = source.Number;
            Description = source.Description;
            TheoreticalMaterial = source.TheoreticalMaterial;
            Test = source.Test;
        }

        #endregion

        #region Properties

        public int Id { get; protected set; }

        public string Name { get; }

        public byte Number { get; }

        public string Description { get; }

        public ITheoreticalMaterial? TheoreticalMaterial { get; }

        public Test? Test { get; }

        #endregion
    }
}