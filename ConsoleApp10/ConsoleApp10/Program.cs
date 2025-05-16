using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Books books = new Books();

            books.onAddBook += ShowMessage;
            books.onDeleteBook += ShowMessage;

            books.AddBook("книга1");
            books.AddBook("книга2");

            books.DeleteBook("книга2");
            books.DeleteBook("Новая книга"); // Попытка удаления
        }

        public static void ShowMessage(string text)
        {
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
