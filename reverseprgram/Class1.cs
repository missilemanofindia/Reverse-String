using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseprgram
{
    public class Class1
    {
        // ही मेथड आपण टेस्ट करणार आहोत
        public int[] ReverseArray(int[] arr)
        {
            if (arr == null) return null;

            int[] output = new int[arr.Length];
            int j = 0;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                output[j] = arr[i];
                j++;
            }

            return output;
        }
    }
}
