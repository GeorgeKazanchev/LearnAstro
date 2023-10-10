using LearnAstro.Domain.Entities.StudentEntities;

namespace LearnAstro.Domain.UseCases.TestPassing
{
    public interface ITestPassingInput
    {
        public void LoadAnsweredQuestionsFromStudent(List<StudentTestQuestion> testQuestions);
    }
}