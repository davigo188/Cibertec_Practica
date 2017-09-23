using CibertecPractica.Repositories.Credit;

namespace CibertecPractica.UnitOfWork
{
    public interface IUnitOfWork
    {
        ICorporationRepository Corporations { get; }
        IMemberRepository Members { get; }
    }
}
