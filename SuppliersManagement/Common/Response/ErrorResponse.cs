namespace SuppliersManagement.Common.Response
{
    public class ErrorResponse
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }

        public ErrorResponse()
        {
            this.StatusCode = 500;
            this.Message = "An error occurred";
        }

        public ErrorResponse(int statusCode, string message)
        {
            StatusCode = statusCode;
            Message = message;
        }
    }
}
