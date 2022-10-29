using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Android.Icu.Text.CaseMap;

namespace AndroidBookAPI.Models
{
    public class Books
    {
            public string Title { get; set; }
            public string Price { get; set; }
            public string Image { get; set; }

            public Books(string title,string price,  string image)
            {
                Title = title;
                Price = price;
                Image = image;
            }
        }
}

namespace AndroidBookAPI.Models
{
    public class Response
    {
        public string Total { get; set; }
        public string Page { get; set; }
        public string Error { get; set; }
        public List<Books> Books { get; set; }

    }
}


