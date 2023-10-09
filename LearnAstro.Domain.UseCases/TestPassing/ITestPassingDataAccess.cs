using LearnAstro.Domain.Entities.StudentEntities;

namespace LearnAstro.Domain.UseCases.TestPassing
{
    public interface ITestPassingDataAccess
    {
        public List<StudentTestQuestion> GetTestQuestions(StudentTest test);
        public void SaveAnsweredTestQuestions(List<StudentTestQuestion> testQuestions);
    }
}