﻿using Calculator.nbcraig;

Console.WriteLine("--- WELCOME TO C# CALCULATOR ---");
Console.WriteLine("--------------------------------");

bool calculatorOff = false;

while(!calculatorOff)
{
    // Initialize variables to store user input
    string? num1Input = "";
    string? num2Input = "";

    // Prompt the user to enter the first number
    Console.WriteLine("Enter the first number!");
    num1Input = Console.ReadLine();
    // Use TryParse to handle format exceptions 
    double num1 = 0;
    while (!double.TryParse(num1Input, out num1))
    {
        Console.WriteLine("Enter the first number in the correct format!");
        num1Input = Console.ReadLine();
    }

    // Repeat process for the second number
    Console.WriteLine("Enter the second number!");
    num2Input = Console.ReadLine();
    double num2 = 0;
    while (!double.TryParse(num2Input, out num2))
    {
        Console.WriteLine("Enter the second number in the correct format!");
        num2Input = Console.ReadLine();
    }

    // Prompt the user to choose a operator
    Console.WriteLine("Choose an operator from the list!");
    Console.WriteLine("\ta - Addition");
    Console.WriteLine("\ts - Subtraction");
    Console.WriteLine("\tm - Multiplication");
    Console.WriteLine("\td - Division");
    Console.WriteLine("Your Operator: ");

    string? op = Console.ReadLine().ToLower();

    // Verify enterd operator and perform operation
    string[] allOperators = { "a", "s", "m", "d" };

    while (!allOperators.Contains(op))
    {
        Console.Clear();
        Console.WriteLine("Please enter a suitable operator!");
        Console.WriteLine("Your Operator: ");

        op = Console.ReadLine().ToLower();
    }

    double operationResult = Engine.HandleOperations(num1, num2, op);

    // Show well formatted results
    Console.Clear();
    Console.WriteLine($"RESULT: {num1} + {num2} = {operationResult}");

    // Wait for the user to respond before closing.
    Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
    if (Console.ReadLine() == "n") calculatorOff = true;
}

// Exit the app is calcultorOff is to be set on true
return;