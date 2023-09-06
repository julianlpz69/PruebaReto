namespace Dominio.Entities;

    public class User : BaseEntiti
    {
        public string UserName { get; set; }
        public string UserEmail { get; set;}
        public string UserPassword { get; set;}
        public ICollection<Rol> Rols { get; set; } = new HashSet<Rol>();
        public ICollection<UserRol> UsersRols { get; set;}
    }
