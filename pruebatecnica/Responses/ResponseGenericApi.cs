namespace pruebatecnica.Responses
{
    public class ResponseGenericApi<T>
    {
        public T Data { get; set; }
        public string Error { get; set; }

        public ResponseGenericApi(T data)
        {
            Data = data;
        }
        public ResponseGenericApi(string error)
        {
            Error = error;
        }
    }
}
