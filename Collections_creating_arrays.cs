
//string[] fruits = new string[5]; 
//new keyword is used to allocate some memory

//fruits[0] = "apple";
//fruits[1] = "apple";
//fruits[2] = "apple";


/*
- we'd use this approach when you know the size of the array in advance, but dont know the values yet and you want to fill the array later.
- or when you'd want to set the size of the array explicitly but initialis values later (perhaps in a loop, or based on user input) 
FOR EXAMPLE:

string[] fruits = new string[5];

for (int i = 0; i < fruits.Length; i++)
{
    Console.WriteLine($"Enter your fave fruit #{i + 1}:");
    fruits[i] = console.ReadLine();
    }

(breakdown:
- the program will initise an empty srray of fruits with 5 slots
- the for loop with iterate 5 times (because fruits.Length is 5), and for each iteration, it will:
> prompt the user to enter their fave fruit
> take the user's input and store it in the corresponding slot in the fruits array

console would look like:
Enter your fave fruit #1:
apple
Enter your fave fruit #1:
banana
Enter your fave fruit #1:
orange
Enter your fave fruit #1:
mango
Enter your fave fruit #1:
grapes

After the loop runs, the array fruits will contain the following values:
fruits = {"apple", "banana", "orange", "mango", "grapes"};


)

*/

string[] fruits = new string[5];

for (int i = 0; i < fruits.Length; i++)
{
    Console.WriteLine($"Enter your fave fruit #{i + 1}:");
    fruits[i] = Console.ReadLine();
    }

Console.WriteLine("\nYour fave fruits are:");
for (int i = 0; i < fruits.Length; i++)
{

    Console.WriteLine($"Fruit #{i + 1}: {fruits[i]}");

}

/*
output:

Enter your fave fruit #1:
apple
Enter your fave fruit #2:
banana
Enter your fave fruit #3:

Enter your fave fruit #4:
mango
Enter your fave fruit #5:
lime

Your fave fruits are:
Fruit #1: apple
Fruit #2: banana
Fruit #3: 
Fruit #4: mango
Fruit #5: lime

*/




// -----------------------------------

string[] fruitss = {"apple", "plum", "cherry"};

console.WriteLine{fruitss[2]};

//output would be cherry