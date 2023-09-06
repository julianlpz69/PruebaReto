namespace API.Helpers
{
    public class JWT
    {
        public string Key { get; set; }
        public string Ussuer { get; set; }
        public string Audience { get; set; }
        public double DurationInMinutes { get; set; }
    }
}