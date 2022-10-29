using AndroidBookAPI.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.Dynamic;

namespace AndroidBookAPI.Services
{
    class BooksDataStoreAPI : IBookDataStore<Books>
    {
        private static string API => "https://api.itbook.store/1.0/search/mongodb";

        public async Task<IEnumerable<Books>> GetBooksAsync(int count)
        {
            var service = DependencyService.Get<IWebClientServices>();
            var json = await service.GetAsync($"{API}?results={count}");

            var books = BookBuilder(json);

            return books;
        }
        private List<Books> BookBuilder(string json)
        {

            Response response = JsonConvert.DeserializeObject<Response>(json);

            var books = new List<Books>();

            foreach (var book in response.Books)
            {
                var title = book.Title.ToString();
                var price = book.Price.ToString();
                var image = book.Image.ToString();
                books.Add(new Books(title, price, image));

            }
            return books;

        }

        public static class UserBuilder
        {

        }
    }
}
