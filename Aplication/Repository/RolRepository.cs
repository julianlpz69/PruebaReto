using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data.Configurations;

namespace Aplication.Repository
{
    public class RolRepository : GenericRepository<Rol>, IRol
    {
        public readonly PruebaRetoDBContetx _context;
        public  RolRepository(PruebaRetoDBContetx context) : base(context)
        {
            _context = context;
        }

    }
}