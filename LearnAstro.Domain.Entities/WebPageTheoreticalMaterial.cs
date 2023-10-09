using LearnAstro.Domain.Entities;

namespace LearnAstro.Domain.Core
{
    public sealed class WebPageTheoreticalMaterial : ITheoreticalMaterial
    {
        #region Constructors

        public WebPageTheoreticalMaterial(int id)
        {
            Id = id;
        }

        #endregion

        #region Properties

        public int Id { get; }

        #endregion
    }
}