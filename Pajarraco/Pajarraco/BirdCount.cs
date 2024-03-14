namespace Pajarraco
{
    public class BirdCount
    {
        public int[] BirdsPerDay { get; set; }

        public BirdCount()
        {
            BirdsPerDay = [ 2, 5, 0, 7, 4, 1 ];
        }

        public static int[] LastWeek()
        {
            return [ 0, 2, 5, 3, 7, 8, 4 ];
        }

        public int Today(int[] birdsPerDay)
        {
            return birdsPerDay[^1];
        }

        public void IncrementTodaysCount()
        {
            Today(BirdsPerDay)++;
        }
    }
}
