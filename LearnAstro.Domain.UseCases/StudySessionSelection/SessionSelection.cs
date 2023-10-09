namespace LearnAstro.Domain.UseCases.StudySessionSelection
{
    public class SessionSelection
    {
        #region Constructors

        public SessionSelection(ISessionSelectionDataAccess dataAccessModel, ISessionSelectionInput inputModel,
            ISessionSelectionOutput outputModel)
        {
            DataAccessModel = dataAccessModel;
            InputModel = inputModel;
            OutputModel = outputModel;
        }

        #endregion

        #region Properties

        public ISessionSelectionDataAccess DataAccessModel { get; set; }

        public ISessionSelectionInput InputModel { get; set; }

        public ISessionSelectionOutput OutputModel { get; set; }

        #endregion

        #region Public methods



        #endregion
    }
}