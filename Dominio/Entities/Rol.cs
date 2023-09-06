namespace Dominio.Entities;

    public class Rol : BaseEntiti
    {
        public string NombreRol { get; set; }
        public ICollection<User> Users { get; set; } = new HashSet<User>();
        public ICollection<UserRol> UsersRols { get; set;}
    }
