﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int age = 50;
// age = "fifty"; // can't do this

string name = "Damian";
 
//Console.WriteLine($"your name is  {name} and you're {age} years old");

BankAccount newAccount = new BankAccount("Bobby",-100.99);

//newAccount.Balance = -100.99;
// newAccount.Balance = newAccount.Balance + 100;

Console.WriteLine($"{newAccount.OwnersName} balance is {newAccount.getBalance()}");
