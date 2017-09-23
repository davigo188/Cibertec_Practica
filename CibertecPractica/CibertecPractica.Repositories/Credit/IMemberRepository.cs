using CibertecPractica.Models;

namespace CibertecPractica.Repositories.Credit
{
    public interface IMemberRepository : IRepository<Member>
    {
        Member SearchByLastName(string lastName);
    }
}
