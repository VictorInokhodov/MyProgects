using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arrays.Interfaces;

namespace Arrays
{
    public class DynamicArray<T> : IIndexable<T>
    {
        int length;
        int capacity;
        T[] array;

        public int Capacity
        {
            get
            {
                return capacity;
            }
        }

        public int Length
        {
            get
            {
                return length;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= length)
                {
                    throw new IndexOutOfRangeException();
                }

                return array[index];
            }
            set
            {
                if (index < 0 || index >= capacity)
                {
                    throw new ArgumentOutOfRangeException("Argument out of range.");
                }

                array[index] = value;
            }
        }

        public DynamicArray()
        {
            length = 0;
            capacity = 8;
            array = new T[8];
        }

        public DynamicArray(int i)
        {
            length = 0;
            capacity = i;
            array = new T[i];
        }

        public DynamicArray(T[] array)
        {
            length = array.Length;
            capacity = array.Count();
            this.array = array;
        }

        public void Add(T el)
        {
            length++;

            if (IsFull())
            {
                capacity *= 2;
                CreateNewArray();
            }

            array[length - 1] = el;
        }

        public void AddRange(T[] arr)
        {
            while(capacity < length + arr.Length)
            {
                capacity *= 2;
            }

            CreateNewArray();

            foreach(T el in arr)
            {
                Add(el);
            }
        }

        public bool Remove(int i)
        {
            if(i < 0 || i >= length)
            {
                return false;
            }
            else
            {
                var newArray = new T[capacity];

                int index = 0;

                for (int x = 0; x < length; x++)
                {
                    if(x != i)
                    {
                        newArray[index] = array[x];
                        index++;
                    }
                }

                array = newArray;

                length--;

                return true;
            }
        }

        public void Insert(int index, T el)
        {
            if (index < 0 || index >= length)
            {
                throw new IndexOutOfRangeException();
            }

            length++;

            if (IsFull())
            {
                capacity *= 2;
                CreateNewArray();
            }

            var newArray = new T[capacity];

            for(int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }

            newArray[index] = el;

            for(int i = index; i < length; i++)
            {
                newArray[i + 1] = array[i];
            }

            array = newArray;
        }

        void CreateNewArray()
        {

            var newArray = new T[capacity];

            array.CopyTo(newArray, 0);

            array = newArray;
        }

        bool IsFull()
        {
            if (length >= capacity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
