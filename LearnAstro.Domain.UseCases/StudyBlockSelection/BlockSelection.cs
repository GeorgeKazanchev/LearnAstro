namespace LearnAstro.Domain.UseCases.StudyBlockSelection
{
    public class BlockSelection
    {
        #region Constructors

        public BlockSelection(IBlockSelectionDataAccess dataAccessModel, IBlockSelectionInput inputModel,
            IBlockSelectionOutput outputModel)
        {
            DataAccessModel = dataAccessModel;
            InputModel = inputModel;
            OutputModel = outputModel;
        }

        #endregion

        #region Properties

        public IBlockSelectionDataAccess DataAccessModel { get; set; }

        public IBlockSelectionInput InputModel { get; set; }

        public IBlockSelectionOutput OutputModel { get; set; }

        #endregion

        #region Public methods



        #endregion
    }
}