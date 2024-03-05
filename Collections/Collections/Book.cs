namespace Collections
{
    public class Book
    {
        const string DEF_TITLE = "DEF TITLE";
        const int DEF_PAGES = 50;

        public int Id { get; set; }
        public string Title { get; set; }
        public int NumPages { get; set; }

        private static int bookCount;

        public Book(int id, string title, int numPages)
        {
            bookCount++;
            Id = id;
            Title = title;
            NumPages = numPages;
        }

        public Book() : this(bookCount, DEF_TITLE, DEF_PAGES + bookCount)
        {
            
        }

        public override string ToString()
        {
            return $"Id: {Id} | Libro: {Title} | NumPaginas: {NumPages}";
        }
    }
}
