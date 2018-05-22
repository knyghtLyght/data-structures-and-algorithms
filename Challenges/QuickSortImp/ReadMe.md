# Quick sort
A whiteboard challenge intended to help us understand sorting algorithms.

## Summery
The algorithm starts by choosing a pivot value. It proceeds by partitioning the elements. Elements larger than the pivot are partitioned on the right side of the pivot and element smaller than the pivot are partitioned on the left side of the pivot. It then recursively applies the algorithm on the partitions.
The algorithm preforms at O(N logN) becuase while we hit every item in the array more than once the pivot points are not moved once their pass is done. Worest case is O(n^2).

## Challenge
Write a function that accepts an array of integers, and returns an array sorted by a recursive quicksort algorithm.

## Solution
![quicksort.jpg](../../assets/quicksort.jpg)

## Resources
https://www.c-sharpcorner.com/blogs/quick-sorting-algorithm-in-c-sharp1
http://snipd.net/quicksort-in-c
https://en.wikipedia.org/wiki/Quicksort