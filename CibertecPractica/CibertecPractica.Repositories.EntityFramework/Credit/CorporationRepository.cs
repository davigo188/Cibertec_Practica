using CibertecPractica.Models;
using CibertecPractica.Repositories.Credit;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CibertecPractica.Repositories.EntityFramework.Credit
{
    public class CorporationRepository : Repository<Corporation>, ICorporationRepository
    {
        public CorporationRepository(DbContext context) : base(context)
        {
        }

        public Corporation SearchByNames(string corpName)
        {
            return _context.Set<Corporation>().FirstOrDefault(x => x.Corp_name == corpName );
        }
    }
}
