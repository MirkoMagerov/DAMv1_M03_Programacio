namespace Collections
{
    public class BookComparer : IComparer<Book>
    {
        private bool _ascending;

        public BookComparer(bool ascending = true)
        {
            _ascending = ascending;
        }

        public int Compare(Book? x, Book? y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return _ascending ? -1 : 1;
            if (y == null) return _ascending ? 1 : -1;

            int result = x.NumPages.CompareTo(y.NumPages);

            return _ascending ? result : -result;
        }
    }
}
