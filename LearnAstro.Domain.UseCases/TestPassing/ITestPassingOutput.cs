using LearnAstro.Domain.Entities.StudentEntities;

namespace LearnAstro.Domain.UseCases.TestPassing
{
    public interface ITestPassingOutput
    {
        public void SendTestQuestions(List<StudentTestQuestion> testQuestions);
        public void SendTestResults(StudentTest test);
    }
}