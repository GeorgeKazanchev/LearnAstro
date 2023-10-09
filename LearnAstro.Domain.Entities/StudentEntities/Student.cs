namespace LearnAstro.Domain.Entities.StudentEntities
{
    public sealed class Student
    {
        #region Constructors

        public Student(string username, string email, DateOnly registrationDate, string? phone = null,
            string? firstName = null, string? lastName = null, string? location = null, DateOnly? birthDate = null,
            List<StudentStudyBlock>? blocks = null)
        {
            Username = username;
            Email = email;
            RegistrationDate = registrationDate;
            Phone = phone;
            FirstName = firstName;
            LastName = lastName;
            Location = location;
            BirthDate = birthDate;
            StudyBlocks = blocks;
        }

        #endregion

        #region Properties

        public string Username { get; }

        public string Email { get; }

        public string? Phone { get; }

        public string? FirstName { get; }

        public string? LastName { get; }

        public string? Location { get; }

        public DateOnly RegistrationDate { get; }

        public DateOnly? BirthDate { get; }

        public List<StudentStudyBlock>? StudyBlocks { get; }

        #endregion
    }
}