//Encapsulation : Hides the data into single unit to protect it from outside access.
/*
using Test.src.OopPrinciples.Encapsulation;

BankAccount bankAccount = new BankAccount(100);
Console.WriteLine(bankAccount.GetBalance());

bankAccount.Deposit(50);
Console.WriteLine(bankAccount.GetBalance());

bankAccount.Withdraw(200);
Console.WriteLine(bankAccount.GetBalance());
*/

//--------------------------------------------------------------------------------------------------------

// Abstraction : Reduce complexity by hiding unnecessary details from the user.
/*
using Test.src.OopPrinciples.Abstraction;

EmailService emailService = new EmailService();
emailService.SendEmail();
*/

//--------------------------------------------------------------------------------------------------------

// Inheritance : Inheritance involving new classes (sub classes or derived classes) based on existing classes (base classes or parent classes). Sub classes inherit properties and behaviors from their super classes and can also add new features or override existing ones. Inheritance is often described in terms of an "is-a" relationship.
/*
using Test.src.OopPrinciples.Inheritance; 

var car = new Car();

// Shared properties
car.Brand = "Ford";
car.Start();
car.Stop();

// Unique properties
car.NumberOfDoors = 4;
car.NumberOfWheels = 4;
*/

//--------------------------------------------------------------------------------------------------------

// Polymorphism : Polymorphism is the ability of an object to take on many forms.
// Poly = Many   |   Morph = Forms 
/*
using Test.src.OopPrinciples.Polymorphism; 

List<Vehicle> vehicles = new List<Vehicle>();
vehicles.Add(new Car { Brand = "Toyota", Model = "Camry", Year = 2020, NumberOfDoors = 4 });
vehicles.Add(new Motorcycle { Brand = "Harley Davidson", Model = "Sportster", Year = 2021 });

// Vehicle Inspection
foreach(var vehicle in vehicles)
{
   vehicle.Start();
}
*/

//--------------------------------------------------------------------------------------------------------

// Coupling - The degree of dependency between different classes.
/*
using Test.src.OopPrinciples.Coupling; 

var order = new Order(new SmsSender());
order.PlaceOrder();
*/

//--------------------------------------------------------------------------------------------------------

// Composition - Composition involves creating complex objects by combining simpler objects or components. In composition, objects are assembled together to form larger structures, with each component object maintaining its own state and behavior. Composition is often described in terms of a "has-a" relationship.

/*
using Test.src.OopPrinciples.Composition;

var car = new Car();
car.StartCar();
*/

// Composition vs Inheritance

// When to Use Composition:-
// When you need more flexibility in constructing objects by assembling smaller, reusable components. I
// When there is no clear "is-a" relationship between classes, and a "has-a" relationship is more appropriate.
// When you want to avoid the limitations of inheritance, such as tight coupling and the fragile base class probles which we will look into shortly.

// When to Use Inheritance:-
// When there is a clear "is-a" relationship between classes, and subclass objects can be treated as instances of their superclass.
// When you want to promote code reuse by inheriting properties and behaviors from existing classes.
// When you want to leverage polymorphism to allow objects of different subclasses to be treated uniformly through their common superclass interface.

//--------------------------------------------------------------------------------------------------------

// Solid Principles :-

// (S) Single Responsibility principle (SRP) - a class should have only one reason to change, meaning that it should have only responsibility or purpose. 

// (O) Open/Close Principle (OCP) - Software entities (classes, modules, functions, etc.) should be open for extension but closed for modification.

// (L) liskow Substitution Principle (LSP) - Objects of a superclass should be replaceable with objects of a subclass without affecting the correctness of the program.
/*
using Test.src.Solid.L;

var rectangle = new Rectangle { Width = 5, Height = 4 };
Console.WriteLine($"Area of Rectangle: {rectangle.Area}");

var square = new Square { SideLength = 4 };
Console.WriteLine($"Area of Square: {square.Area}");
*/

// (I) Interface Segregation Principle (ISP) - Clients should not be forced to depend on interfaces they do not use. 
/*
using Test.src.Solid.I;

var circle = new Circle();
circle.Radius = 10;
Console.WriteLine($"Area of Circle: {circle.Area}");
*/

// (D) Dependency Inversion Principle (DIP) - High-level modules should not depend on low-level modules. Both should depend on abstractions.

using Test.src.Solid.D;

var car = new Car();
car.StartCar();
