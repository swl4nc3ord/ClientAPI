namespace ClienteAPI.Models.Result
{
    public class Response
    {
        public bool Sucess { get; set; }

        public dynamic? Data { get; set; }

        public string? Message { get; set; }
    }
}
