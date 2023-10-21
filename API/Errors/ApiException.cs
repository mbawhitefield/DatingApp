namespace API.Errors
{
    public class ApiException
    {
        public ApiException(int statusCode, string message, string details)
        {
            Statuscode = statusCode;
            Message = message;
            Details = details;
        }

        public int Statuscode { get; set; }
        public string Message { get; set; }
        public string Details { get; set; }

    }
}