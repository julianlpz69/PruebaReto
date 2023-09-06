using Dominio.Entities;

namespace Dominio.Interfaces
{
    public interface IUser : IGenericRepository<User>
    {
         Task<User> GetByUserbameAsync(string Username);
    }
}