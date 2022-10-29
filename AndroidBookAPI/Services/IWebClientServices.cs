using System;
namespace AndroidBookAPI.Services
{
	interface IWebClientServices
	{

        Task<string> GetAsync(string uri);
        Task<string> PostAsync(string uri, string body, string type);
        Task<string> PutAsync(string uri, string body, string type);

    }
}

