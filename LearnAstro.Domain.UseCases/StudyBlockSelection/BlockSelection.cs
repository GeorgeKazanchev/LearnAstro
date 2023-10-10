using LearnAstro.Domain.Entities.StudentEntities;

namespace LearnAstro.Domain.UseCases.StudyBlockSelection
{
    public class BlockSelection : IBlockSelectionInput
    {
        #region Constructors

        public BlockSelection(IBlockSelectionDataAccess dataAccessModel, IBlockSelectionOutput outputModel, Student student)
        {
            DataAccessModel = dataAccessModel;
            OutputModel = outputModel;
            Student = student;
        }

        #endregion

        #region Properties

        public IBlockSelectionDataAccess DataAccessModel { get; set; }

        public IBlockSelectionOutput OutputModel { get; set; }

        public Student Student { get; private set; }

        #endregion

        #region Public methods

        public void LoadAndSetAssosiatedData()
        {
            var studyBlocks = DataAccessModel.GetAllStudyBlocks(Student);
            loadAndSetProjectsForBlocks(studyBlocks);
        }

        public void LoadAndSetAssosiatedData(byte levelOfBlocks)
        {
            var studyBlocks = DataAccessModel.GetStudyBlocksWithGivenLevel(Student, levelOfBlocks);
            loadAndSetProjectsForBlocks(studyBlocks);
        }

        public void SendStudyBlocksToStudent()
        {
            OutputModel.SendStudyBlocksToStudent(Student.StudyBlocks!);
        }

        #endregion

        #region Private methods

        private void loadAndSetProjectsForBlocks(List<StudentStudyBlock> studyBlocks)
        {
            DataAccessModel.LoadAndSetProjectsForBlocks(studyBlocks);
            Student.StudyBlocks = studyBlocks;
        }

        #endregion
    }
}