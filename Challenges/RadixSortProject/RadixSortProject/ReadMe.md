# Radix Sort
A sorting algorithm challenge intended to help us understand how and when to use sorting algorithms

## Summery
Radix sort is a sorting algorithm that sorts integers by processing individual significant digits. Because integers can represent strings of digits and thus other forms of data, it can sort integers with Worst case performance O(K*N) where K is the number of digits and N is the number of integers being sorted.

You can implement the algorithm from a most significant first approach (MSD) or a least significant first approach (LSD). LSD implementations begin by looking at the lowest order digit and moving up while MSD does the reverse.

## Challenge
Write a function that accepts an array of positive integers, and returns an array sorted by a radix sort algorithm.

## Visual
https://visualgo.net/en/sorting

![RadixSort.jpg](../../assets/RadixSort.jpg)

## Resources
https://visualgo.net/en/sorting
http://sorting.at/
https://en.wikipedia.org/wiki/Radix_sort
http://algorithmsandstuff.blogspot.com/2014/06/radix-sort-in-c-sharp.html