// WHAT ARE FUNCTIONS?
/*
functions allow programmers to organise a section of code and give them a name related to what they do. they are reusable blocks of code designed to perform a specific task

eg - working on a large programme, with thousands of lines of code. Instead of repreating the same task over and over again, we ca:
1. write code one in a function
2. then callt eh function to get that code to run
*/ 


//whatre methods
//syntax of a method
//what built in methodsare there





// WHAT ARE METHODS?
/*
Methods are functions that belong to a specific class or object
- c# is an object-oriented programming (OOP) language
- a method is a function that belonds to a class or object
- if we are working in a program.cs file, any methods we write will belond to the Program class
*/

// METHODS: SYNTAX
/*
int AddNumbers(int a, int b)
{
    in result = a + b;
    return result;
}

- 'int' is the return type. This is the type of value the method will return
- 'AddNumbers' is the Method name. This is a descriptive way of naming the method
- 'int a, int b' is the parameters. These are variables used to pass data into methods
- 'return' is the return statement. Used to specify the value that the method returns

*/


// Methods


int sum = AddNumbers(510, 25);

//Console.WriteLine(sum);     // this with the variable above is another way
//Console.WriteLine(AddNumbers(10, 5));    this is one way we could writ it
Console.WriteLine($"the result of these two numbers is {sum}");


int AddNumbers (int firstNumber, int secondNumber) {

    int result = firstNumber + secondNumber;

    return result;
}