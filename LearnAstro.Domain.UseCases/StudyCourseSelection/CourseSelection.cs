namespace LearnAstro.Domain.UseCases.StudyCourseSelection
{
    public class CourseSelection
    {
        #region Constructors

        public CourseSelection(ICourseSelectionDataAccess dataAccessModel, ICourseSelectionOutput outputModel)
        {
            DataAccessModel = dataAccessModel;
            OutputModel = outputModel;
        }

        #endregion

        #region Properties

        public ICourseSelectionDataAccess DataAccessModel { get; set; }

        public ICourseSelectionOutput OutputModel { get; set; }

        #endregion
    }
}