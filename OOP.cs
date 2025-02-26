Car myCar = new Car();

myCar.Model = "Yaris";
myCar.Make = "Toyota";
myCar.Colour = "Blue";

myCar.Drive();

Console.WriteLine($"My car is a {myCar.Make} {myCar.Model}, and it is {myCar.Colour}");













//OOP
// C# is an object-oriented prgramming language. Object oriented programming is a way or organising code. It focussed on objects that represent real world things
// Objects can have data(properties) and methods(actions)

// CLASS
// A class is like a blueprint for creating objects, where we can define properties nd methods the objects should have
/*
EG: imagines we are making a car:
- we need a blueprint or template to tell us what parts the car needs and how it should look
- we can create a 'car' class to act as the blueprint for all cars
- the class will tell us properites that all cars should have, such as model, make and colour
*/

// OBJECT
// An object is an instance of a class
/*
- an object is what we make from the blueprint
- when we follow the blueprint to amek a car, we get an instance of a car
- if we create a car using the 'car' class, we could make a Toyota Yaris, in blue. This specific car is an object
- we can create as many objects as we want from a class
*/

// PROPERTIES AND METHODS
// Properties hold data about a class
// Methods are actions whch an instance of a class can do
/*
Properties are like variables inside a class:
- a car could have a colour, make and a model
- we use the keyword get and set when we define a property
- get allowes us to retrieve the value of a property
- set allows us to assign a value to a property

Methods are like functions inside a class:
- a car can Drive()
*/



//CREATING A CLASS
/* these are properties
public class Car{
    public string Model {get; set; }
    public string Make {get; set; }
    public string Colour {get; set; }


    public void Drice()                         this is a method

}
*/
/*
- always have to write 'public'
- need to use the 'class' keyword
- 'Car' in this exampple is the name we want to give our class
*/





