using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia.Data.Configurations;

namespace Aplication.Repository
{
    public class UserRepository : GenericRepository<User>, IUser
    {
        private readonly PruebaRetoDBContetx _context;

        public UserRepository(PruebaRetoDBContetx context):base(context)
        {
            _context = context;
        }

       public async Task<User> GetByUsernameAsync(string userName)
        {
            return await _context.Users
                                    .Include(u => u.Rols)
                                    .FirstOrDefaultAsync(u => u.UserName.ToLower() == userName.ToLower());
        }



    }
}