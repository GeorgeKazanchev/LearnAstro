using LearnAstro.Domain.Entities.StudentEntities;

namespace LearnAstro.Domain.UseCases.TestPassing
{
    public interface ITestPassingInput
    {
        public List<StudentTestQuestion> GetAnsweredQuestions();
    }
}