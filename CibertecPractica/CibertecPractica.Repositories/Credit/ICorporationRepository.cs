using CibertecPractica.Models;

namespace CibertecPractica.Repositories.Credit
{
    public interface ICorporationRepository : IRepository<Corporation>
    {
        Corporation SearchByNames(string corpName);

    }
}
