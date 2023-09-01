using System.Net;

namespace BikeShop.Infrastructure.Base
{
    public class ResponseBase<T>
    {
        public String Message { get; set; }
        public Boolean IsSuccess { get; set; }
        public HttpStatusCode HTTPCode { set; get; }
        public T DataObject { get; set; }

        public ResponseBase(String message, bool isSuccess, HttpStatusCode httpCode, T dataObject)
        {
            Message = message;
            IsSuccess = isSuccess;
            HTTPCode = httpCode;
            this.DataObject = dataObject;
        }
    }
}
