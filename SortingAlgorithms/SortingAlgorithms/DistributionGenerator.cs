using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public enum Distribution
    {
        Ascending,
        Descending
    }
    public class DistributionGenerator
    {
        public DistributionGenerator()
        {

        }

        public int[] GenerateDistribution(int size, Distribution distribution)
        {
            switch (distribution)
            {
                case Distribution.Ascending:
                    return GenerateAscendingDistribution(size);
                case Distribution.Descending:
                    return GenerateDescendingDistribution(size);
                default:
                    return GenerateAscendingDistribution(size);
            }
        }

        public int[] GenerateAscendingDistribution(int size)
        {
            int[] array = new int[size];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            return array;
        }
        public int[] GenerateDescendingDistribution(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = size - i;
            }
            return array;
        }

        public int[] GenerateVShapeDistribution(int size)
        {
            int[] firstPart = GenerateDescendingDistribution(size / 2);
            int[] secondPart = GenerateAscendingDistribution(size / 2);

            // Array concatenation. firstArray + secondArray
            int[] array = new int[firstPart.Length + secondPart.Length];
            firstPart.CopyTo(array, 0);
            secondPart.CopyTo(array, firstPart.Length);

            return array;
        }
    }
}
