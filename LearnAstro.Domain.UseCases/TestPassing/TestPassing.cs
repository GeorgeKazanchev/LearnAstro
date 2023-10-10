using LearnAstro.Domain.Entities.StudentEntities;

namespace LearnAstro.Domain.UseCases.TestPassing
{
    public class TestPassing : ITestPassingInput
    {
        #region Constructors

        public TestPassing(ITestPassingDataAccess dataAccessModel, ITestPassingOutput outputModel, StudentTest test)
        {
            DataAccessModel = dataAccessModel;
            OutputModel = outputModel;
            Test = test;
        }

        #endregion

        #region Properties

        public ITestPassingDataAccess DataAccessModel { get; set; }

        public ITestPassingOutput OutputModel { get; set; }

        public StudentTest Test { get; private set; }

        #endregion

        #region Public methods

        #region Implemented methods

        public void LoadAnsweredQuestionsFromStudent(List<StudentTestQuestion> answeredQuestions)
        {
            Test.TestQuestions = answeredQuestions;
        }

        #endregion

        public void LoadQuestions()
        {
            var testQuestions = DataAccessModel.GetTestQuestions(Test);
            Test.TestQuestions = testQuestions;
        }

        public void SaveAnsweredQuestions()
        {
            DataAccessModel.SaveAnsweredTestQuestions(Test.TestQuestions!);
        }

        public void SendQuestionsToStudent()
        {
            OutputModel.SendTestQuestions(Test.TestQuestions!);
        }

        public void SendResultsToStudent()
        {
            OutputModel.SendTestResults(Test);
        }

        public void CheckAnswers()
        {
            Test.UpdateTestResults();
        }

        #endregion
    }
}