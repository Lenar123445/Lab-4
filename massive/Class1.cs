using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamic_massive
{
    internal class DynamicArray
    {
        public int[] array;
        public int size;
        public int capacity;

        public DynamicArray(int initialcapacity = 4)
        {
            array = new int[initialcapacity];
            size = 0;
            capacity = initialcapacity;
        }

        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public void Add_End(int value)
        {
            if (size == capacity)
            {
                Resize(capacity * 2);
            }
            array[size] = value;
            size++;
        }
        public void Delete_End()
        {
            size--;
        }

        public void Insert(int index, int value)
        {
            if (size == capacity)
            {
                Resize(capacity * 2);
            }
            for (int i = size; i > index; i--)
            {
                array[i] = array[i - 1];
            }
            array[index] = value;
            size++;
        }

        public void Remove(int index)
        {
            for (int i = index; i < size - 1; i++)
            {
                array[i] = array[i + 1];
            }
            size--;

            if (size < capacity / 2)
            {
                Resize(capacity / 2);
            }
        }

        public void Remove_Value(int value)
        {
            for (int i = 0; i < size; i++)
            {
                if (array[i] == value)
                {
                    Remove(i);
                }
            }
        }
        public int Max()
        {
            int maxindex = 0;
            for (int i = 0; i < size; i++)
            {
                if (array[i] > array[maxindex])
                {
                    maxindex = i;
                }
            }
            return maxindex;
        }
        public bool Full()
        {
            return size == capacity;
        }

        public int Count()
        {
            return size;
        }

        public void Resize(int NewCapacity)
        {
            int[] newArray = new int[NewCapacity];
            for (int i = 0; i < size; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
            capacity = NewCapacity;
        }

        public void Print()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
