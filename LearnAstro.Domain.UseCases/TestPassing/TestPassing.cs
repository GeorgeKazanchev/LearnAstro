using LearnAstro.Domain.Entities.StudentEntities;

namespace LearnAstro.Domain.UseCases.TestPassing
{
    public class TestPassing
    {
        #region Constructors

        public TestPassing(ITestPassingDataAccess dataAccessModel, ITestPassingInput inputModel,
            ITestPassingOutput outputModel, StudentTest test)
        {
            DataAccessModel = dataAccessModel;
            InputModel = inputModel;
            OutputModel = outputModel;
            Test = test;
        }

        #endregion

        #region Properties

        public ITestPassingDataAccess DataAccessModel { get; set; }

        public ITestPassingInput InputModel { get; set; }

        public ITestPassingOutput OutputModel { get; set; }

        public StudentTest Test { get; private set; }

        #endregion

        #region Public methods

        public void LoadQuestions()
        {
            try
            {
                var testQuestions = DataAccessModel.GetTestQuestions(Test);
                Test.TestQuestions = testQuestions;
            }
            catch (Exception exception)
            {
                
            }
        }

        public void SaveAnsweredQuestions()
        {
            checkForTestQuestions();

            try
            {
                DataAccessModel.SaveAnsweredTestQuestions(Test.TestQuestions!);
            }
            catch (Exception exception)
            {

            }
        }

        public void SendQuestionsToStudent()
        {
            checkForTestQuestions();
            OutputModel.SendTestQuestions(Test.TestQuestions!);
        }

        public void SendResultsToStudents()
        {
            OutputModel.SendTestResults(Test);
        }

        public void GetAnsweredQuestionsFromStudent()
        {
            checkForTestQuestions();
            var answeredQuestions = InputModel.GetAnsweredQuestions();
            Test.TestQuestions = answeredQuestions;
        }

        public void CheckAnswers()
        {
            Test.UpdateTestResults();
        }

        #endregion

        #region Private methods

        private void checkForTestQuestions()
        {
            if (Test.TestQuestions == null)
            {
                throw new Exception("Test questions are missing.");
            }
        }

        #endregion
    }
}