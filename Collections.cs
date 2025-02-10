// Arrays

/*
- Theyre a fixed size
- All elements must be the same data type
- They have limited built in functionality


ARRAY SYNTAX

string[]arrayName = new string[5];
- declare the array by specifying the data type of its elements 
- use square brackets to declare an array
- name the array
- the 'string[5]' specifies that the array will hold fice elements, all of which will be strings


Storing different datatypes would look like this:
string[] fruits = {"apple", "plum", "banana"};
int[] prices = {1, 2, 6};
bool[] booleanArray = {true, false, true};



LISTS
- Lists automaticallygrow as elements are added
- Have more built in methods, for easy data manipulation
- Better suited for real life scenarios
- All elements must be the same datatype



LISTS SYNTAX

List<string>fruits = new List<string>();
- Declare a list using the List keyword
- Put the data type in angled brackets <>
- Name the list
- Cread a new, empty list using the 'new' keyword
- we dont need to mention the size of the list like we do for arrays
*/
List<string>fruits = new List<string>{"apple", "plum", "banana"};

// Above is the exact syntax youd use for a list of fruits
/*
Later on in out program we can add more values to out list using .Add()

fruits.Add("strawberry");
fruits.Add("Orange");



Add() - adds an elemets to the nd of the list.   fruits.Add("melon");
AddRange() - adds another collection to the list.     fruits.AddRange(myOtherList);
Insert() - inserts an elements at a specific indec.   fruits.Insert(1, "melon");
Remove() - removed the first occurance of a value.    fruits.remove("banana");

RemoveAt() - removed the element at a specific index.   fruits.RemoveAt(1);
Contains() - check if a specific value exists in the list.   fruits.Contains("apple");   would return true or false
IndexOf() - finds the index of a value.   fruits.IndexOf("orange");

Count() - gets the number of elements in the list.    fruits.Count;
Clear() - removed all elements.  fruits.Clear();
Sort() - sort elements in order (ascending order for numbers, or alphabletical order for characters and strings)    fruits.Sort();
Reverse() - reverses the order of the list.    fruits.Reverse();




*/