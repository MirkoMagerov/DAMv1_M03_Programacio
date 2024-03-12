namespace Pajarraco
{
    public class BirdCount
    {
        int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };

        public static int[] LastWeek()
        {
            return [ 0, 2, 5, 3, 7, 8, 4 ];
        }

        public int Today() => birdsPerDay[^1];
    }
}
