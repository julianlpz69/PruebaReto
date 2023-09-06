using Aplication.Repository;
using Dominio.Interfaces;
using Persistencia.Data.Configurations;

namespace Aplication.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork , IDisposable
    {
        private readonly PruebaRetoDBContetx _context;
        private  RolRepository _rol;
        private UserRepository _user;
        
        public UnitOfWork(PruebaRetoDBContetx context){
            _context = context;
        }

        public IRol Roles{
            get{
                if(_rol == null)
                {
                    _rol = new RolRepository(_context);
                }
                return _rol;
            }
        }


         public IUser Users{
            get{
                if(_user == null)
                {
                    _user = new UserRepository(_context);
                }
                return _user;
            }
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}