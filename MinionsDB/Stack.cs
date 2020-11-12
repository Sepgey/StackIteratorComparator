using LinkedList;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DoublyNodeListMinions
{
    public class Stack <T> : IEnumerable<T>
    {
        T[] array;
        int size;
        public Stack(params T[] arr)
        {
            this.array = arr;
            this.size = this.array.Length - 1;
        }

        public T Pop()
        {
            T getItem = array[size];
            array[size] = default(T);
            size--;
            return getItem;
        }

        public void Push(T addItem)
        {
            size++;
            if (size < array.Length)
                array[size] = addItem;
            else
            {
                T[] addedArr = new T[2 * array.Length];
                for (int i = 0; i < array.Length; i++)
                    addedArr[i] = array[i];
                array = addedArr;
                array[size] = addItem;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            int beginSize = this.size;
            for(int i=0; i <= beginSize; i++)
            {
                yield return this.Pop();
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }

    /*class StackIterator<T> : IEnumerator<T>
    {
        private readonly T[] arrayOfStack;
        private int currentIndex;
        public StackIterator(IEnumerable<T> arrayOfStack)
        {
            List<T> listStack = new List<T>(arrayOfStack);
            this.arrayOfStack = new T[listStack.Count];
            for (int i = 0; i < arrayOfStack.Length; i++)
                this.arrayOfStack[i] = listStack[i];

            this.Reset();
        }

        public T Current => this.arrayOfStack[this.currentIndex];

        object IEnumerator.Current => this.Current;

        public void Dispose() { }

        public bool MoveNext() => --this.currentIndex >= 0;

        public void Reset() => this.currentIndex = this.arrayOfStack.Length;
    }*/

    class Program
    {
        static void Main(string[] args)
        {
            Minion minion1 = new Minion(1, "Kevin", 14, 3);
            Minion minion2 = new Minion(2, "Bob", 23, 2);
            Minion minion3 = new Minion(3, "Stuart", 21, 1);

            Stack<Minion> minions = new Stack<Minion>(minion1, minion2, minion3);
            
            minions.Pop();
            minions.Push(new Minion(4, "Adam", 21, 4));
            minions.Push(new Minion(5, "Qwerty", 44, 5));
            minions.Pop();

            foreach (var minion in minions)
            {
                Console.WriteLine(minion);
            }
        }
    }
}
