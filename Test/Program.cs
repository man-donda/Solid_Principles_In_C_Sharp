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

using Test.src.OopPrinciples.Coupling; 

var order = new Order(new SmsSender());
order.PlaceOrder();


//--------------------------------------------------------------------------------------------------------
