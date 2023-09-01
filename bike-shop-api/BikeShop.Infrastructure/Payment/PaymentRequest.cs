using System.Net;
using System.Text;

namespace BikeShop.Infrastructure.Payment
{
    public class PaymentRequest
    {
        public PaymentRequest()
        {
        }
        public static async Task<string> sendPaymentRequest(string endpoint, string postJsonString)
        {

            try
            {
                HttpClient httpClient = new HttpClient();
                var httpRequestMessage = new HttpRequestMessage();
                httpRequestMessage.Method = HttpMethod.Post;
                httpRequestMessage.Content = new StringContent(postJsonString, Encoding.UTF8, "application/json");
                httpRequestMessage.RequestUri = new Uri(endpoint);
                var response = await httpClient.SendAsync(httpRequestMessage);
                var responseContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseContent);
                return responseContent;
            }
            catch (WebException e)
            {
                return e.Message;
            }
        }
    }
}
