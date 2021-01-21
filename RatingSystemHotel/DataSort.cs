using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatingSystemHotel
{
    class DataSort
    {
        private int setPivot(List<Serialization> dataList, int lowestIndex, int highestIndex)
        {
            Serialization pivot = dataList[highestIndex];
            int pointer = lowestIndex;

            for (var i = lowestIndex; i < highestIndex; i++)
            {
                
                if (Int32.Parse(dataList[i].QualityFood) <= Int32.Parse(pivot.QualityFood))
                {
                    Serialization tempValue = dataList[pointer];
                    dataList[pointer] = dataList[i];
                    dataList[i] = tempValue;
                    pointer++;
                }
            }
            Serialization tempPivot = dataList[pointer];
            dataList[pointer] = dataList[highestIndex];
            dataList[highestIndex] = tempPivot;
            return pointer;
        }

        public List<Serialization> quickSorter(List<Serialization> list, int lowestIndex, int highestIndex)
        {
            if (highestIndex > lowestIndex)
            {
                int pivotIndex = setPivot(list, lowestIndex, highestIndex);

                quickSorter(list, lowestIndex, pivotIndex - 1);
                quickSorter(list, pivotIndex + 1, highestIndex);
            }
            return list;
        }
    }
}
