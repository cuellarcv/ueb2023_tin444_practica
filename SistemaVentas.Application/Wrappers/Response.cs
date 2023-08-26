
namespace SistemaVentas.Application.Wrappers
{
    public class Response<T>
    {
        public bool Succeded { get; set; }

        public string Message { get; set; }

        public T Data { get; set; }

        public List<string> Errors { get; set; } 

        public Response() { }

        public Response(T data, string mensaje = "")
        {
            Succeded = true;
            Message = mensaje;
            Data = data;
        }

        public Response(string mensaje = "")
        {
            Succeded = true;
            Message = mensaje;
        }
    }
}
