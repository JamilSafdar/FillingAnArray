using System;

namespace FillingAnArray
{
    public class ArrayContent
    {
        public static int[] ReturnNumbersFrom0ToNMinus1(int arrayLength)
        {
            int[] output = new int[arrayLength];
            for (int i=0; i<arrayLength; i++) 
            {
                output[i] = i;            
            }
            return output;
        }
        public static int[] ReturnNumbersFromMinusNTo0(int arrayLength)
        {
            var trueArrayLength = (arrayLength * -1) + 1;

            int[] output = new int[arrayLength];

            for (int i = trueArrayLength, z = 0; i < 0; i++, z++)
            {
                output[z] = i;
            }

            return output;
        }
    }
}