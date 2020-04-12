using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webgentle.BookStore.Models;

namespace Webgentle.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();               
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(book => book.Id == id).FirstOrDefault();              
        }

        public List<BookModel> SearchBook(string title, string author)
        {
            return DataSource().Where(book => book.Title.Contains(title) || book.Author.Contains(author)).ToList();          
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id = 1, Title = "MVC", Author = "Nitish"},
                new BookModel(){Id = 5, Title = "Dot Net Core", Author = "Nitish"},
                new BookModel(){Id = 2, Title = "C#", Author = "Monika"},
                new BookModel(){Id = 3, Title = "Java", Author = "Webgentle"},
                new BookModel(){Id = 4, Title = "PHP", Author = "Webgentle"}
            };
        }
    }
}
