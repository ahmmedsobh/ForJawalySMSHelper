using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForJawalySMSHelper.Models;

namespace ForJawalySMSHelper
{
    public class ForJawalySMS
    {

        public static string app_key { get; set; }
        public static string app_secret { get; set; }
        public static string sender { get; set; }

        public static async Task<_4jawalyRoot> SendSms(Root root)
        {

            List<string> numberList = root.numbers.Split(',').ToList();
            string appKey = app_key; // from settings
            string appSecret = app_secret; // from settings

            List<message> messages = new List<message>();
            message messageSend = new message();
            messageSend.text = root.text;
            messageSend.numbers = numberList;
            messages.Add(messageSend);


            var message = new message
            {
                text = root.text,
                numbers = numberList
            };

            var sendData = new SendData
            {
                messages = messages,
                globals = new Globals
                {
                    number_iso = "SA",
                    sender = sender
                }
            };

            var url = "https://api-sms.4jawaly.com/api/v1/account/area/sms/send";
            var credentials = appKey + ":" + appSecret;

            using var httpClient = new HttpClient();

            var content = new StringContent(System.Text.Json.JsonSerializer.Serialize(sendData), Encoding.UTF8, "application/json");
            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes(credentials)));
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(sender);

            using var response = await httpClient.PostAsync(url, content);
            var resultJson = await response.Content.ReadAsStringAsync();
            var result = System.Text.Json.JsonSerializer.Deserialize<_4jawalyRoot>(resultJson);

            if (response.IsSuccessStatusCode)
            {
                return result;
            }
            else
            {
                var errorJson = await response.Content.ReadAsStringAsync();
                throw new Exception(errorJson.ToString());
            }

        }
    }
}
