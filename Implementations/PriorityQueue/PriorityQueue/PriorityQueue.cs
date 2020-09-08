﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

/// <summary>
/// A min Priority Queue using a Binary Heap implimentation and hashtable mapping
/// @Author Kevin Farrrow
/// Referances:
/// https://www.youtube.com/channel/UCD8yeTczadqdARzQUp29PJw
/// https://visualstudiomagazine.com/articles/2012/11/01/priority-queues-with-c.aspx
/// </summary>
namespace PriorityQueue
{
    class PriorityQueue<T> where T : IComparable<T>
    {
        // The number of elements in the heap
        private int heapSize = 0;
        // The maximum size the heap allows
        private int heapCapacity = 0;
        // Element tracking list
        private List<T> heap;
        // This dictionary keeps track of the indicies of a perticular node value in the heap
        // alolowing us to take advantage of O(log(n)) removals and O(1) containment check at
        // the cost of space and some overhead.
        private Dictionary<T, List<int>> map;

        // Constructors
        public PriorityQueue()
        {
            heap = new List<T>();
        }

        public PriorityQueue( T[] inputData)
        {
            heapSize = heapCapacity = inputData.Length;

            // Place all elements into the map and the heap
            for (int i = 0; i < heapSize; i++)
            {
                heap.Add(inputData[i]);
                // Try to add the key and a new list with the vlaue
                if (!map.TryAdd(heap[i], new List<int> { i }))
                    map[heap[i]].Add(i); // Otherwise grab and add to the keys values
            }

            // Heapify the input data
            for (int i = (int)(MathF.Max(0, (heapSize/2)-1)); i >= 0; i--)
            {
                Sink(i);
            }
        }

        public PriorityQueue(Collection<T> inputData)
        {
            foreach (T item in inputData)
            {
                Add(item);
            }
        }

        /// <summary>
        /// Returns a boolen reflecting if the Priority Queue has anything in it
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return heapSize == 0;
        }

        /// <summary>
        /// Clears all items within the heap and resets all counters
        /// </summary>
        public void Clear()
        {
            heap.Clear();
            heapSize = 0;
            map.Clear();
        }

        /// <summary>
        /// Returns the number of elemets in the PQ
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return heapSize;
        }

        /// <summary>
        /// Returns the value of the element with the highest priority from the queue (the top of the heap).
        /// Returns default if empty.
        /// </summary>
        /// <returns></returns>
        public T Peak()
        {
            if (IsEmpty()) return default;
            return heap[0];
        }

        /// <summary>
        /// Returns the value of the element with the highest priority from the queue and removes it
        /// from the queue
        /// </summary>
        /// <returns></returns>
        public T Poll()
        {
            return RemoveAt(0);
        }

        /// <summary>
        /// Check if an element exists within the queue
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public bool Contains(T element)
        {
            if (element == null) return false;
            return map.ContainsKey(element);
        }

        /// <summary>
        /// Add an element to the queue 
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            
        }

        private T RemoveAt(int v)
        {
            throw new NotImplementedException();
        }

        private void Sink(int i)
        {
            throw new NotImplementedException();
        }
    }
}
