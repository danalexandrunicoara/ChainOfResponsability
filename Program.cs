// See https://aka.ms/new-console-template for more information
using ChainOfResponsability;
using ChainOfResponsability.Handlers;

Console.WriteLine("Hello, World!");
var monkey = new MonkeyHandler();
var dog = new DogHandler();
monkey.SetNext(dog);

Client.CallingHandler(monkey);