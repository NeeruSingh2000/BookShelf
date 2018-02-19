using System;
using System.Collections.Generic;
using BuisnessObjects;
using DataLayer;


namespace BuisnessLayer
{
    /// <summary>
    /// Interface Representing Bookshelf functions
    /// </summary>
    public interface IBookshelf
    {
        IEnumerable<Book> GetBooks();

        bool Loan(Book book);
        bool Return(Book book);
    }


    /// <summary>
    /// Implementing Bookshelf functions
    /// </summary>

    public class BookShelf : IBookshelf
    {
        /// <summary>
        /// Loan a single book
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public bool Loan(Book book)
        {
            return DataLayer.BookShelf.Loan(book);
        }

        /// <summary>
        /// Get  all books
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Book> GetBooks()
        {
            IEnumerable<Book> books = DataLayer.BookShelf.GetAllBooks();
            return books;
        }

        /// <summary>
        /// Return a single book
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        /// 
        public bool Return(Book book)
        {
            return DataLayer.BookShelf.Return(book);
        }

    }

   
}
