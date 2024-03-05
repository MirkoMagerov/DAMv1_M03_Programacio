using System.Collections;

namespace Collections
{
    class Program
    {
        public static void Main()
        {
            Book libro1 = new Book();
            Book libro2 = new Book();
            Book libro3 = new Book();
            Book libro4 = new Book();
            Book libro5 = new Book();

            List<Book> bookList = new List<Book>();

            bookList.Add(libro1);
            bookList.Add(libro2);
            bookList.Add(libro3);
            bookList.Add(libro4);
            bookList.Add(libro5);

            bookList.Sort(new BookComparer());

            Console.WriteLine("ORDEN ASCENDENTE");
            foreach (Book book in bookList)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine();

            bookList.Sort(new BookComparer(false));

            Console.WriteLine("ORDEN DESCENDENTE");
            foreach (Book book in bookList)
            {
                Console.WriteLine(book);
            }
        }
    }
}