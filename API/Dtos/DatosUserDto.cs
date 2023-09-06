namespace API.Dtos
{
    public class DatosUserDto
    {
        public string Mensaje { get; set; }
        public bool EstadoAutenticado { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public List<string> Roles { get; set; }
        public string Token { get; set; }
    }
}