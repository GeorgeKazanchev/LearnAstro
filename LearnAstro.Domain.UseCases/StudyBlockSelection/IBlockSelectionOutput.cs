using LearnAstro.Domain.Entities.StudentEntities;

namespace LearnAstro.Domain.UseCases.StudyBlockSelection
{
    public interface IBlockSelectionOutput
    {
        public void SendStudyBlocksToStudent(List<StudentStudyBlock> studyBlocks);
    }
}