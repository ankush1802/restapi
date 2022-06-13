namespace ShoppingWebApi.Model
{
    public class ResponseHandler
    {
        public static ApiResponse GetExceptionResponse(Exception ex)
        {
            ApiResponse response = new ApiResponse();
            response.Code = "1";
            response.ResponseData = ex.Message;
            return response;
        }
        public static ApiResponse GetAppResponse(ResponseType type, object? contract)
        {
            ApiResponse response;

            response = new ApiResponse { ResponseData = contract };
            switch (type)
            {
                case ResponseType.Success:
                    response.Code = "0";
                    response.Message = "Success";

                    break;
                case ResponseType.NotFound:
                    response.Code = "2";
                    response.Message = "No record available";
                    break;
            }
            return response;
        }
    }
}
