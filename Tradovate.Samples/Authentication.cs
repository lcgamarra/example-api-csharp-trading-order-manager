/* 
 * 
 * Tradovate API, Samples. 
 * AccessTokenRequest
 *
*/

using System.Diagnostics;
using System.Net;
using Tradovate.Services.Api;
using Tradovate.Services.Model;

namespace Tradovate
{
    class Authentication
    {
        public static AccessTokenResponse GetAccessToken(string basePath, string username, string password)
        {
            var apiInstance = new AuthenticationApi(basePath);
            var body = new AccessTokenRequest(
                name: username, 
                password: password, 
                appId: "Blackrozzy", 
                appVersion: "0.0.1", 
                cid: "1619", 
                sec: "f7f2368e-ebf0-4f5f-907b-65eecd3d2c0d");
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            AccessTokenResponse result = apiInstance.AccessTokenRequest(body);
            Debug.WriteLine(result);
            return result;
        }
    }
}