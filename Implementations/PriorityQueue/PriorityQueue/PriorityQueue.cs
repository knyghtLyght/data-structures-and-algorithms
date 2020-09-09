using System;
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
            if (item == null) throw new ArgumentNullException();

            heap.Add(item);

            // Try to add the item and it's index to the map
            if (!map.TryAdd(item, new List<int> { heapSize }))
            {
                // If the itew already exists add another location to the list
                map[item].Add(heapSize);
            }

            Swim(heapSize);
            heapSize++;
        }

        /// <summary>
        /// Helper method for removing spesific nodes
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private T RemoveAt(int i)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Top down node Sink
        /// Helper method that orders the heap by moving a node down the tree
        /// </summary>
        /// <param name="i"></param>
        private void Sink(int i)
        {
            while (true)
            {
                int left = 2 * i + 1; // Left node
                int right = 2 * i + 2; // Right node
                int smallest = left; // Assume keft is the smallest

                // Check smallest assumption and correct if needed
                if (right < heapSize && Less(right, left))
                {
                    smallest = right;
                }

                // Stop if we are outside the bounds of the tree 
                // or if we cannot sink i anymore
                if (left >= heapSize || Less(i, smallest)) break;

                // Move down the tree following the smallest node
                swap(smallest, i);
                i = smallest;
            }
        }

        /// <summary>
        /// Helper method that orders the heap by moving a node up the tree
        /// </summary>
        /// <param name="i"></param>
        private void Swim(int i)
        {
            // Grab the index of the next parent node WRT to k
            int parent = (i - 1) / 2;

            // Keep swimming while we have not reached the
            // root and while we're klless than our parent
            while (i > 0 && Less(i, parent))
            {
                // Exchange i with the parent
                Swap(parent, i);
                i = parent;

                // Grab the index of the next node
                parent = (i - 1) / 2;
            }
        }

        /// <summary>
        /// Helper method to swap in the heap and the map
        /// </summary>
        private void Swap(int i, int j)
        {
            T iElement = heap[i];
            T jElement = heap[j];

            heap[i] = jElement;
            heap[j] = iElement;
        }


        /// <summary>
        /// Helper method intended to determin if node i is less than node j
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        private bool Less(int i, int j)
        {
            T node1 = heap[i];
            T node2 = heap[j];
            return node1.CompareTo(node2) <= 0;
        }
    }
}
