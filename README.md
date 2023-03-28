# 5UniqueNumbers
A simple C# program that asks for 5 numbers and if the number has already been input throws an error.
Returns a sorted list of the numbers

## Running
```
dotnet build
dotnet run
```
## Process
* Runs a loop until 5 unique numbers are input
* if a number is repeated, responds "This number has already been entered, please enter a new number"
* after 5 unique numbers are input, the list is sorted and returned

## Output
```
Enter a number: 
5
Enter a number: 
54
Enter a number: 
81
Enter a number: 
54
54 has already been entered, please enter a new number
Enter a number:
12
Enter a number: 
9
The Sorted list of numbers is as follows:
5
9
12
54
81
```
