using CibertecPractica.Models;
using CibertecPractica.Repositories.Credit;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CibertecPractica.Repositories.EntityFramework.Credit
{
    public class MemberRepository : Repository<Member>, IMemberRepository
    {
        public MemberRepository(DbContext context) : base(context)
        {
        }

        public Member SearchByLastName(string lastName)
        {
            return _context.Set<Member>().FirstOrDefault(x => x.Lastname == lastName);
        }
    }
}
