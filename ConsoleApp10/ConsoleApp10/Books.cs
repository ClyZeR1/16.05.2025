using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Books
    {
        protected List<string> BookNames = new List<string>();

        // Делегат
        public delegate void BookHandler(string text);

        // События
        public event BookHandler onAddBook;
        public event BookHandler onDeleteBook;
        public void AddBook(string bookName)
        {
            BookNames.Add(bookName);
            onAddBook?.Invoke("Книга " + bookName + " добавлена");
        }

        public void DeleteBook(string bookName)
        {
            if (BookNames.Contains(bookName))
            {
                BookNames.Remove(bookName);
                onDeleteBook?.Invoke("Книга " + bookName + " УДАЛЕНА!");
            }
            else
            {
                Console.WriteLine("Книга " + bookName + " не найдена.");
            }
        }
    }
}
