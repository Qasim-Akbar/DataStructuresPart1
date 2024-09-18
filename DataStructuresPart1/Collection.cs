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
            int upper = Count() - 1;
            object temp;
            for (int outer = upper; outer >= 1; outer--)
            {
                for (int inner = 0; inner <= outer - 1; inner++)
                {
                    if ((int)InnerList[inner] > (int)InnerList[inner + 1])
                    {
                        temp = InnerList[inner];
                        InnerList[inner] = InnerList[inner + 1];
                        InnerList[inner + 1] = temp;
                    }
                }
            }
        }

        public void SelectionSort()
        {
            int upper = Count() - 1;
            object temp;
            for (int outer = 0; outer <= upper; outer++)
            {
                int min = outer;
                for (int inner = outer + 1; inner <= upper; inner++)
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

            for (int i = 0; i < mid; i++)
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
            while (firstHalf.Count > 0 || secondHalf.Count > 0)
            {
                if (firstHalf.Count > 0 && secondHalf.Count > 0)
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
            string printData = "";
            foreach (int i in list) printData += ", " + i;

            Console.WriteLine(printData);
            Console.WriteLine("----------------------------------");

        }

        internal void InsertionSort()
        {
            for (int i = 1; i < InnerList.Count; i++)
            {
                object temp;
                if ((int)InnerList[i - 1] > (int)InnerList[i])
                {
                    for (int k = i; k >= 0; k--)
                    {
                        temp = InnerList[k];

                        if (k > 0 && (int)temp < (int)InnerList[k - 1])
                        {
                            //  printArray(InnerList);
                            //   Console.WriteLine($"Current temp: {temp}");

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
            for (int i = 0; i < InnerList.Count - 1; i++)
            {
                InnerList[i] = InnerList[i + 1];
            }
            InnerList[InnerList.Count - 1] = temp;
        }

        internal void ShellSort()
        {
            for (int gap = InnerList.Count / 2; gap > 0; gap /= 2)
            {
                for (int i = 0; i < InnerList.Count - gap; i++)
                {

                    object temp;
                    for (int k = i; k >= 0 && (int)InnerList[k] > (int)InnerList[k + gap]; k = k - gap)
                    {
                        temp = InnerList[k];
                        InnerList[k] = InnerList[k + gap];
                        InnerList[k + gap] = temp;
                        //  Console.WriteLine($"gap: {gap}, i: {i}, k: {k}");
                        //   printArray(InnerList);
                    }

                }
            }
        }

        internal void QuickSort()
        {
            int pivot = (int)InnerList[0];
            int start = 0;
            int end = InnerList.Count - 1;
            QuickSort(start, end);
        }

        private void QuickSort(int lower, int upper)
        {
            if (lower < upper)
            {
                int pivot = (int)InnerList[lower];
                int start = lower;
                int end = upper;
                object temp;
                while (start < end)
                {
                    while (start < upper && (int)InnerList[start] <= pivot) start++;
                    while (lower < end && (int)InnerList[end] > pivot) end--;

                    if (start < end)
                    {
                        temp = InnerList[start];
                        InnerList[start] = InnerList[end];
                        InnerList[end] = temp;
                    }
                }

                temp = InnerList[lower];
                InnerList[lower] = InnerList[end];
                InnerList[end] = temp;

                QuickSort(lower, end - 1);

                QuickSort(end + 1, upper);
            }
        }

        internal bool SequentialSerach(int v)
        {
            for(int i=0; i<InnerList.Count; i++)
            {
                if ((int)InnerList[i]==v) return true;
            }
            return false;
        }

        internal bool BinarySearch(int v)
        {
            int lowerBound = 0;
            int upperBound = InnerList.Count - 1;
            int mid = (upperBound+lowerBound)/ 2;

            while (lowerBound <= upperBound)
            {
                mid = (upperBound + lowerBound) / 2;
                if ((int)InnerList[mid] == v) return true;
                else if((int)InnerList[mid]<v) lowerBound=mid+1;
                else if ((int)InnerList[mid] > v) upperBound=mid-1;
            }
            return false;

        }

        internal bool RBinarySearch(int v, int lb, int ub)
        {
            if (lb <= ub)
            {
                int mid = (lb + ub) / 2;
                if ((int)InnerList[mid] == v) return true;
                else if ((int)InnerList[mid] < v ) return RBinarySearch(v, mid + 1, ub);
                else if ((int)InnerList[mid] > v) return RBinarySearch(v, lb, mid - 1);

            }
                return false;
        }
    }
}
