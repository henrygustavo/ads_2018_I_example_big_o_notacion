using System;

namespace big_o_notacion
{
    public class BinarySearch
    {
        public  int Function(int[] arr, int value)
        {
            int countIteration = 0;

            int startIndex = 0;
            int endIndex = arr.Length - 1;

            int mid;

            while (startIndex <= endIndex)
            {
                countIteration++;

                mid = (startIndex + endIndex) / 2;

                if(value == arr[mid])
                {
                    Console.WriteLine(string.Format("iteration:{0}", countIteration));
                    return mid;
                }
                else if ( value < arr[mid] )
                {

                    endIndex = mid - 1;
                }
                else
                {
                    startIndex = mid + 1;
                  
                }
            }
            
            return -1;
        }
    }
}
