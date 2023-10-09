namespace LearnAstro.Domain.UseCases.StudyCourseSelection
{
    public class CourseSelection
    {
        #region Constructors

        public CourseSelection(ICourseSelectionDataAccess dataAccessModel, ICourseSelectionInput inputModel,
            ICourseSelectionOutput outputModel)
        {
            DataAccessModel = dataAccessModel;
            InputModel = inputModel;
            OutputModel = outputModel;
        }

        #endregion

        #region Properties

        public ICourseSelectionDataAccess DataAccessModel { get; set; }

        public ICourseSelectionInput InputModel { get; set; }

        public ICourseSelectionOutput OutputModel { get; set; }

        #endregion

        #region Public methods



        #endregion
    }
}