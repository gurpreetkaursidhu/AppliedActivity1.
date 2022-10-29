using AndroidBookAPI.Models;
using AndroidBookAPI.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

using System;
namespace AndroidBookAPI.Services
{
	interface IBookDataStore<T>
	{
        Task<IEnumerable<Books>> GetBooksAsync(int count);
    }
}


