namespace Delegates
{
    public class Delegates
    {
        public delegate int TwoIntsDelegator(int a, int b);
        public delegate double DoubleUniqueDelegator(int a);
        public delegate double DoubleIntArrayDelegator(int[] nums);
        public delegate void EvenNumber(int a);
        public delegate int OnlyOneInt(int a);
    }
}
