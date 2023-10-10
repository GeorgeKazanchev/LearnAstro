namespace LearnAstro.Domain.UseCases.StudySessionSelection
{
    public class SessionSelection
    {
        #region Constructors

        public SessionSelection(ISessionSelectionDataAccess dataAccessModel, ISessionSelectionOutput outputModel)
        {
            DataAccessModel = dataAccessModel;
            OutputModel = outputModel;
        }

        #endregion

        #region Properties

        public ISessionSelectionDataAccess DataAccessModel { get; set; }

        public ISessionSelectionOutput OutputModel { get; set; }

        #endregion
    }
}