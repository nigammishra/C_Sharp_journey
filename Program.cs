﻿
// ==================Hello World===========================//
// using System;
// class HeloWorld{
//     static void Main(string[args]){
//         Console.WriteLine("Hello, World!");
//     }
// }
//======================= End ========================//

//======================= Swapping ========================//
// using System;

// class swapping
// {
//      static void Main (string[]args)
//     {
//         int a = 5;
//         int b = 10;

//         Console.WriteLine($"Before swapping: a = {a}, b = {b}");


//         int temp = a;
//         a = b;
//         b = temp;

//         Console.WriteLine($"After swapping: a = {a}, b = {b}");
//     }
// }

//======================= End ========================//


//======================= Fahrenheit ========================//

// using System;

// class Fahrenheit
// {
//      static void Main (string[]args)
//     {
//         Console.Write("Enter temperature in Fahrenheit: ");
//         double fahrenheit = Convert.ToDouble(Console.ReadLine());

//         double celsius = (fahrenheit - 32) * 5 / 9;

//         Console.WriteLine($"Temperature in Celsius: {celsius:F2}");
//     }                                                                 
// }


//======================= End ========================//

//======================= Find the area and perimeter of a rectangle (using user input) ========================//

// using System;

// class rectangle
// {
//      static void Main (string[]args)
//     {
//         
//         Console.Write("Enter the length of the rectangle: ");
//         double length = Convert.ToDouble(Console.ReadLine());

//         Console.Write("Enter the width of the rectangle: ");
//         double width = Convert.ToDouble(Console.ReadLine());

//         
//         double area = length * width;
//         double perimeter = 2 * (length + width);

//         
//         Console.WriteLine($"Area of the rectangle: {area}");
//         Console.WriteLine($"Perimeter of the rectangle: {perimeter}");
//     }
// }


//======================= End ========================//



//======================= simpleInterest ========================//

// using System;

// class simpleInterest
// {
//      static void Main (string[]args)
//     {

//         Console.Write("Enter the principal amount (P): ");
//         double principal = Convert.ToDouble(Console.ReadLine());

//         Console.Write("Enter the rate of interest (R) in percentage: ");
//         double rate = Convert.ToDouble(Console.ReadLine());

//         Console.Write("Enter the time period (T) in years: ");
//         double time = Convert.ToDouble(Console.ReadLine());


//         double simpleInterest = (principal * rate * time) / 100;


//         Console.WriteLine($"Simple Interest (SI) = {simpleInterest}");
//     }
// }


//======================= End ========================//


//======================= compoundInterest ========================//

// using System;

// class compoundInterest
// {
//      static void Main (string[]args)
//     {

//         Console.Write("Enter the principal amount (P): ");
//         double principal = Convert.ToDouble(Console.ReadLine());

//         Console.Write("Enter the annual interest rate (R) in percentage: ");
//         double rate = Convert.ToDouble(Console.ReadLine());

//         Console.Write("Enter the time period (T) in years: ");
//         double time = Convert.ToDouble(Console.ReadLine());

//         Console.Write("Enter the number of times interest is compounded per year (n): ");
//         double n = Convert.ToDouble(Console.ReadLine());


//         double compoundInterest = principal * Math.Pow((1 + (rate / (n * 100))), (n * time)) - principal;


//         Console.WriteLine($"Compound Interest (CI) = {compoundInterest:F2}");
//     }
// }

//======================= End ========================//


//======================= radiusCircle ========================//

// using System;

// class radiusCircle
// {
//      static void Main (string[]args)
//     {

//         Console.Write("Enter the radius of the circle: ");
//         double radius = Convert.ToDouble(Console.ReadLine());


//         double area = Math.PI * Math.Pow(radius, 2);


//         Console.WriteLine($"Area of the circle: {area:F2}");
//     }
// }

//======================= End ========================//


//======================= positive ========================//



// using System;

// class positive
// {
//      static void Main (string[]args)
//     {
//         Console.Write("Please enter an integer: ");

//         // Try to parse the input as an integer
//         if (int.TryParse(Console.ReadLine(), out int number))
//         {
//             // Check if the number is positive
//             if (number > 0)
//             {
//                 Console.WriteLine($"You entered a positive number: {number}");
//             }
//             else
//             {
//                 Console.WriteLine("The number is not positive.");
//             }
//         }
//         else
//         {
//             Console.WriteLine("Invalid input. Please enter a valid integer.");
//         }
//     }
// }

//======================= End ========================//


//======================= EvenOdd ========================//


// using System;

// class EvenOdd
// {
//      static void Main (string[]args)
//     {
//         Console.WriteLine("Enter a number:");
//         int number = int.Parse(Console.ReadLine());

//         if (number % 2 == 0)
//         {
//             Console.WriteLine($"{number} is even.");
//         }
//         else
//         {
//             Console.WriteLine($"{number} is odd.");
//         }
//     }
// }

//======================= End ========================//


//======================= dayUsingArrary ========================//


// using System;

// class dayUsingArrary
// {
//      static void Main (string[]args)
//     {
//         Console.WriteLine("Enter a sequence of digits (0-6) representing days of the week (0=Sunday, 1=Monday, ..., 6=Saturday):");
//         string input = Console.ReadLine();

//         // Array representing the days of the week
//         string[] daysOfWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

//         Console.WriteLine("Days corresponding to your input:");

//         foreach (char c in input)
//         {
//             if (char.IsDigit(c))
//             {
//                 int index = (int)(c - '0'); // Convert char digit to integer
//                 if (index >= 0 && index < daysOfWeek.Length)
//                 {
//                     Console.WriteLine(daysOfWeek[index]);
//                 }
//                 else
//                 {
//                     Console.WriteLine($"Invalid input: {c} is not a valid day index.");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine($"Invalid character: {c} is not a digit.");
//             }
//         }
//     }
// }

//======================= End ========================//


//======================= DayUsingElseif ========================//

// using System;

// class DayUsingElseif
// {
//      static void Main (string[]args)
//     {
//         Console.WriteLine("Enter a number (0-6) to get the corresponding day of the week:");
//         string input = Console.ReadLine();

//         // Validate input
//         if (input.Length == 1 && char.IsDigit(input[0]))
//         {
//             int dayIndex = int.Parse(input);

//             if (dayIndex >= 0 && dayIndex <= 6)
//             {
//                 // Print the corresponding day of the week
//                 if (dayIndex == 0)
//                 {
//                     Console.WriteLine("Sunday");
//                 }
//                 else if (dayIndex == 1)
//                 {
//                     Console.WriteLine("Monday");
//                 }
//                 else if (dayIndex == 2)
//                 {
//                     Console.WriteLine("Tuesday");
//                 }
//                 else if (dayIndex == 3)
//                 {
//                     Console.WriteLine("Wednesday");
//                 }
//                 else if (dayIndex == 4)
//                 {
//                     Console.WriteLine("Thursday");
//                 }
//                 else if (dayIndex == 5)
//                 {
//                     Console.WriteLine("Friday");
//                 }
//                 else if (dayIndex == 6)
//                 {
//                     Console.WriteLine("Saturday");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Please enter a number between 0 and 6.");
//             }
//         }
//         else
//         {
//             Console.WriteLine("Invalid input. Please enter a single digit (0-6).");
//         }
//     }
// }

//======================= End ========================//


//======================= discriminant ========================//


// using System;

// class discriminant
// {
//      static void Main (string[]args)
//     {
//         Console.WriteLine("Enter coefficients a, b, and c (for ax^2 + bx + c = 0):");

//         Console.Write("a: ");
//         double a = Convert.ToDouble(Console.ReadLine());

//         Console.Write("b: ");
//         double b = Convert.ToDouble(Console.ReadLine());

//         Console.Write("c: ");
//         double c = Convert.ToDouble(Console.ReadLine());

//         // Calculate the discriminant
//         double discriminant = b * b - 4 * a * c;

//         if (discriminant > 0)
//         {
//             // Two real and distinct roots
//             double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
//             double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
//             Console.WriteLine($"Roots are real and distinct: x1 = {root1}, x2 = {root2}");
//         }
//     }
// }

//======================= End ========================//



//======================= greater ========================//

// using System;
// class greater {
//     static void Main (string[]args)
//     {
//         Console.Write("a: ");
//         double a = Convert.ToDouble(Console.ReadLine());

//         Console.Write("b: ");
//         double b = Convert.ToDouble(Console.ReadLine());

//         if (a>b){
//             Console.WriteLine("a is greater");
//         } else{
//             Console.WriteLine("b is greater");
//         }
//     }
// }

//======================= End ========================//

//======================= Vowel ========================//

// using System;

// class Vowel
// {
//      static void Main (string[]args)
//     {
//         Console.WriteLine("Enter a string:");
//         string input = Console.ReadLine();

//         foreach (char c in input.ToLower())
//         {
//             if (char.IsLetter(c))  
//             {
//                 if ("aeiou".Contains(c)) 
//                 {
//                     Console.WriteLine($"'{c}' is a vowel.");
//                 }
//                 else  
//                 {
//                     Console.WriteLine($"'{c}' is a consonant.");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine($"'{c}' is not a letter.");
//             }
//         }
//     }
// }


//======================= End ========================//

//======================= Eligibility ========================//


// using System;
// class Eligibility
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter Your age: ");
//         int age = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Job Status:");
//         String jobstatus = Console.ReadLine().ToLower();

//         if (age >= 21 && jobstatus == "yes")
//         {
//             Console.WriteLine("Eligible for Marriage");
//         }
//         else if(age >= 21 && jobstatus == "no")
//         {
//             Console.WriteLine("Not Eligible for Marriage");
//         }
//         else{
//             Console.WriteLine("Please enter Yes or No Only ");
//         }

//     }
// }

//======================= End ========================//


//======================= rectangletosquare ========================//


// using System;

// class rectangletosquare
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter the length of the rectangle:");
//         double length = Convert.ToDouble(Console.ReadLine());

//         Console.WriteLine("Enter the breadth of the rectangle:");
//         double breadth = Convert.ToDouble(Console.ReadLine());

//         if (length == breadth)
//         {
//             Console.WriteLine("The rectangle is a square.");
//         }
//         else
//         {
//             Console.WriteLine("The rectangle is not a square.");
//         }
//     }
// }

//======================= End ========================//
