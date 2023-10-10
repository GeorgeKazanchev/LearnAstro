using LearnAstro.Domain.Entities.StudentEntities;

namespace LearnAstro.Domain.UseCases.StudyBlockSelection
{
    public interface IBlockSelectionDataAccess
    {
        public List<StudentStudyBlock> GetAllStudyBlocks(Student student);
        public List<StudentStudyBlock> GetStudyBlocksWithGivenLevel(Student student, byte level);
        public void LoadAndSetProjectsForBlocks(List<StudentStudyBlock> blocks);
    }
}