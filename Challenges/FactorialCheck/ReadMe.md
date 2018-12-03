## Factorial check

A simple method intended to find n! where n is any poitive int. This method is intended to give a standard int as a return value so will max out fairly quickly.

The factorial of a number is the product of an intiger and all of the posetive intigers less than it.

## Challenge

Write a method called Factorial that takes in an intiger n and returns its factorial as an int

## Solution

The mothod has two sanity checks intended to catch negetive values, followed by a base case where n = 0, then uses a recursive call to find the product of the previous step passing in (n-1). Then it multiplies the return value by its value of n
