using AndroidBookAPI.Models;
using AndroidBookAPI.Services;
using MvvmHelpers;
using MvvmHelpers.Commands;


using System;
namespace AndroidBookAPI.ViewModels
{
    internal class BooksListViewModels
    {
        public IBookDataStore<Books> DataStore => DependencyService.Get<IBookDataStore<Books>>();
        public ObservableRangeCollection<Books> Books { get; set; }
        public AsyncCommand PageAppearingCommand { get; }

        public BooksListViewModels()
        {
            Books = new ObservableRangeCollection<Books>();
            PageAppearingCommand = new AsyncCommand(PageAppearing);
        }

        public async Task Refresh()
        {
            var books = await DataStore.GetBooksAsync(10);

           Books.AddRange(books);
        }

        async Task PageAppearing()
        {
            await Refresh();
        }
    }
}

    


