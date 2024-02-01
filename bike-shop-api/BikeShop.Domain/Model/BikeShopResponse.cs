using System.Net;

namespace BikeShop.Infrastructure.Abstraction
{
    public class BikeShopResponse<T>
    {
        public String Message { get; set; }
        public Boolean IsSuccess { get; set; }
        public HttpStatusCode HTTPCode { set; get; }
        public T DataObject { get; set; }

        public BikeShopResponse(String message, bool isSuccess, HttpStatusCode httpCode, T dataObject)
        {
            Message = message;
            IsSuccess = isSuccess;
            HTTPCode = httpCode;
            this.DataObject = dataObject;
        }
    }
}
