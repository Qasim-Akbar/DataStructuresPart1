using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPart1
{
    internal class Collection : CollectionBase
    {
        public void Add(object item)
        {
            InnerList.Add(item);
        }

        public void Remove(object item)
        {
            InnerList.Remove(item);
        }

        public new void Clear()
        {
            InnerList.Clear();
        }

        public new int Count()
        {
            return InnerList.Count;
        }

        public void BubbleSort()
        {
            int upper = Count()-1;
            object temp;
            for (int outer = upper; outer >=1; outer--)
            {
                for (int inner = 0; inner <=outer-1; inner++)
                {
                    if ((int)InnerList[inner] > (int)InnerList[inner + 1])
                    {
                        temp = InnerList[inner];
                        InnerList[inner] = InnerList[inner+1];
                        InnerList[inner+1] = temp;
                    }
                }
            }
        }

        public void SelectionSort()
        {
            int upper = Count()-1;
            object temp;
            for(int outer = 0; outer <= upper; outer++)
            {
                int min = outer;
                for(int inner = outer+1; inner <= upper; inner++)
                {
                    if ((int)InnerList[min] > (int)InnerList[inner])
                        min = inner;
                }
                temp = InnerList[outer];
                InnerList[outer] = InnerList[min];
                InnerList[min] = temp;
            }
        }

        public void MergeSort()
        {
            ArrayList sortedList = MergeSort(InnerList);
            for (int i = 0; i < sortedList.Count; i++)
            {
                InnerList[i] = sortedList[i];
            }
        }

        private static ArrayList MergeSort(ArrayList unSortedList)
        {
           // Console.WriteLine("----------------unSortedList------------------");
          //  printArray(unSortedList);
            if (unSortedList.Count <= 1)
            {
                return unSortedList;
            }

            int mid = unSortedList.Count / 2;
            ArrayList firstHalf = new ArrayList();
            ArrayList secondHalf = new ArrayList();

            for (int i = 0;i<mid; i++)
            {
                firstHalf.Add(unSortedList[i]);
            }

            for (int i = mid; i < unSortedList.Count; i++)
            {
                secondHalf.Add(unSortedList[i]);
            }
            firstHalf = MergeSort(firstHalf);
            secondHalf = MergeSort(secondHalf);
            ArrayList list = new ArrayList();
            list = MergeSort(firstHalf, secondHalf);

            return list;

        }

        private static ArrayList MergeSort(ArrayList firstHalf, ArrayList secondHalf)
        {
           

            ArrayList sorted = new ArrayList();
            while (firstHalf.Count > 0 || secondHalf.Count>0)
            {
                if(firstHalf.Count > 0 && secondHalf.Count > 0)
                {
                    if ((int)firstHalf[0] < (int)secondHalf[0])
                    {
                        sorted.Add(firstHalf[0]);
                        firstHalf.RemoveAt(0);
                    }
                    else
                    {
                        sorted.Add(secondHalf[0]);
                        secondHalf.RemoveAt(0);
                    }
                }
                else if (firstHalf.Count > 0)
                {
                    sorted.Add(firstHalf[0]);
                    firstHalf.RemoveAt(0);
                }
                else if (secondHalf.Count > 0)
                {
                    sorted.Add(secondHalf[0]);
                    secondHalf.RemoveAt(0);
                }
               
            }
            
          //  Console.WriteLine("----------------sorted------------------");
          //  printArray(sorted);
            return sorted;
        }
        private static void printArray(ArrayList list)
        {
            Console.WriteLine("----------------------------------");
            string printData = "";
            foreach (int i in list) printData += ", " + i;

            Console.WriteLine(printData);
        }

        internal void InsertionSort()
        {
            for (int i = 1;i<InnerList.Count;i++)
            {
                object temp;
                if ((int)InnerList[i-1] > (int) InnerList[i])
                {
                    for(int k = i; k >= 0; k--)
                    {
                        temp = InnerList[k];
                        
                        if (k > 0 && (int)temp < (int)InnerList[k-1])
                        {
                            printArray(InnerList);
                            Console.WriteLine($"Current temp: {temp}");

                            InnerList[k] = InnerList[k - 1];
                            InnerList[k - 1] = temp;
                        }
                    }
                }
            }
        }

        internal void LeftRotationByOne()
        {
            object temp = InnerList[0];
            for (int i = 0; i<InnerList.Count-1;i++)
            {
                InnerList[i] = InnerList[i+1];
            }
            InnerList[InnerList.Count-1] = temp;
        }
    }
}
