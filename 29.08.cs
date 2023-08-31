// zadanie 1

//using System.ComponentModel.Design;

//Console.Write("Enter a number between 1 and 100: ");
//int number = int.Parse(Console.ReadLine());

//if (number < 1 || number > 100)
//        {
//            Console.WriteLine("Error: Number is not in the range of 1 to 100.");
//        }
//else if (number % 3 == 0 && number % 5 == 0)
//        {
//            Console.WriteLine("Fizz Buzz");
//        }
//else if (number % 3 == 0)
//        {
//            Console.WriteLine("Fizz");
//        }
//else if (number % 5 == 0)
//        {
//            Console.WriteLine("Buzz");
//        }
//else
//        {
//            Console.WriteLine(number);
//        }

//zadanie 2

//using System.ComponentModel.Design;

//Console.Write("Enter the value: ");
//double value = double.Parse(Console.ReadLine());

//Console.Write("Enter the percentage: ");
//double percentage = double.Parse(Console.ReadLine());

//double result = (percentage / 100) * value;
//Console.WriteLine($"Result: {result}");

// zadanie 3
//using System.ComponentModel.Design;

//Console.Write("Enter the first digit: ");
//int digit1 = int.Parse(Console.ReadLine());

//Console.Write("Enter the second digit: ");
//int digit2 = int.Parse(Console.ReadLine());

//Console.Write("Enter the third digit: ");
//int digit3 = int.Parse(Console.ReadLine());

//Console.Write("Enter the fourth digit: ");
//int digit4 = int.Parse(Console.ReadLine());

//int formedNumber = digit1 * 1000 + digit2 * 100 + digit3 * 10 + digit4;

//Console.WriteLine($"Formed Number: {formedNumber}"); //можно и сделать через стринг но так слишком банально

// zadanie 4

// фиг знает как пытался не получилось тоже формула как я понял но не смог найти

// zadanie 5
//using System.ComponentModel.Design;

//Console.Write("Enter a date (MM/DD/YYYY): ");
//DateTime inputDate = DateTime.Parse(Console.ReadLine());

//string season = GetSeason(inputDate.Month);

//string dayOfWeek = inputDate.DayOfWeek.ToString();

//Console.WriteLine($"Season: {season} {dayOfWeek}");
//string GetSeason(int month)
//{
//    switch (month)
//    {
//        case 12:
//        case 1:
//        case 2:
//            return "Winter";
//        case 3:
//        case 4:
//        case 5:
//            return "Spring";
//        case 6:
//        case 7:
//        case 8:
//            return "Summer";
//        case 9:
//        case 10:
//        case 11:
//            return "Fall";
//        default:
//            return "Unknown";
//    }
//}

// zadanie 5
//using System.ComponentModel.Design;

//Console.WriteLine("Temperature Conversion Program");
//Console.WriteLine("1. Fahrenheit to Celsius");
//Console.WriteLine("2. Celsius to Fahrenheit");
//Console.Write("Enter your choice (1 or 2): ");

//int choice = int.Parse(Console.ReadLine());
//if (choice != 1 && choice != 2)
//{
//    Console.WriteLine("Invalid choice. Please enter 1 or 2.");
//    return;
//}

//Console.Write("Enter the temperature: ");
//double temperature = double.Parse(Console.ReadLine());
//double convertedTemperature;

//if (choice == 1)
//{
//    convertedTemperature = FahrenheitToCelsius(temperature);
//    Console.WriteLine($"Converted temperature: {convertedTemperature:F2}°C");
//}
//else if (choice == 2)
//{
//    convertedTemperature = CelsiusToFahrenheit(temperature);
//    Console.WriteLine($"Converted temperature: {convertedTemperature:F2}°F");
//}

//    double FahrenheitToCelsius(double fahrenheit)
//    {
//        return (fahrenheit - 32) * 5 / 9;
//    }

//    double CelsiusToFahrenheit(double celsius)
//    {
//        return celsius * 9 / 5 + 32;
//    }

// zadanie 7

//using System.ComponentModel.Design;

//Console.Write("Enter the first number: ");
//int number1 = int.Parse(Console.ReadLine());

//Console.Write("Enter the second number: ");
//int number2 = int.Parse(Console.ReadLine());

//int startRange = Math.Min(number1, number2);
//int endRange = Math.Max(number1, number2);

//if (startRange % 2 != 0)
//{
//    startRange++; // Ensure startRange is even
//}

//Console.WriteLine($"Even numbers between {startRange} and {endRange}:");

//for (int i = startRange; i <= endRange; i += 2)
//{
//    Console.WriteLine(i);
//}







