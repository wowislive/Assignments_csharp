using System.Collections;

namespace Assignment_3
{
    public class ConcertComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Concert concert1 = (Concert)x;
            Concert concert2 = (Concert)y;
            if (concert1 > concert2) return 1;
            else if (concert1 < concert2) return -1;
            else return 0;
        }
    }
}
