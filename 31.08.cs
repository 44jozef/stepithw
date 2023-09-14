#region Task1
/*
Console.WriteLine("1.From decimal to binary\n2.From binary to decimal");
int turn = int.Parse(Console.ReadLine());
switch (turn)
{
    case 1:
        Console.WriteLine("Enter your number");
        if (int.TryParse(Console.ReadLine(), out int decToBin))
        {
            string tmp = Convert.ToString(decToBin, 2);
            Console.WriteLine(tmp);
        }
        else Console.WriteLine("Invalid number");
        break;
    case 2:
        Console.WriteLine("Enter your number");
        string binToDec = Console.ReadLine();
        if (IsBinary(binToDec))
        {
            int num = Convert.ToInt32(binToDec, 2);
            Console.WriteLine(num);
        }
        else Console.WriteLine("Invalid number");
        break;

    default:
        Console.WriteLine("Invalid number");
        break;
}

static bool IsBinary(string numbers)
{
    foreach(char  digit in numbers)
    {
        if (digit != '0' && digit != '1') return false;
    }
    return true;
}
*/
#endregion
#region Task2
/*
string[] numbers = new string[] {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
Console.WriteLine("Enter a word from zero to nine");
string num = Console.ReadLine().ToLower();
int index = Array.IndexOf(numbers, num);
if (index != -1) Console.WriteLine("Your number is: " + index);
else Console.WriteLine("This number is not in the range");
*/
#endregion
#region Task3
/*
using System.Text.RegularExpressions;
InternationalPassport ID1 = new InternationalPassport("Example Example Test","12345","12/45");
ID1.ShowData();

class InternationalPassport
{
    public string FullName { get; set; }
    public string NumPass { get; set; }
    public string IssueDate { get; set; }

    public InternationalPassport(string fullName, string numPass,string issueDate)
    {
        if (IsValidName(fullName))
        {
            FullName = fullName;
            NumPass = numPass;
            IssueDate = issueDate;
        }
        else
            throw new Exception("Invalid input full name");
    }
    public void ShowData()
    {
        Console.WriteLine($"Name: {FullName}");
        Console.WriteLine($"Passport ID: {NumPass}");
        Console.WriteLine($"Issue date: {IssueDate}");
    }
    public void InputData()
    {
        Console.WriteLine("Enter full name");
        FullName = Console.ReadLine();
        Console.WriteLine("Enter passport ID");
        NumPass = Console.ReadLine();
        Console.WriteLine("Enter issue date");
        IssueDate = Console.ReadLine();
    }
    public bool IsValidName(string name)
    {
        string regex = @"^[a-zA-Z]+\s[a-zA-Z]+\s[a-zA-Z]+$";
        return Regex.IsMatch(name, regex);
    }
}
*/
#endregion
#region Task4
/*
try
{
    Console.WriteLine("Enter a logical expression use space example 12 > 10");
    string input = Console.ReadLine();
    string[] parts = input.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
    int leftOperand = int.Parse(parts[0]);
    string op = parts[1];
    int rightOperand = int.Parse(parts[2]);
    int result = op switch
    {
        "<" => leftOperand < rightOperand ? 1 : 0,
        ">" => leftOperand > rightOperand ? 1 : 0,
        "<=" => leftOperand <= rightOperand ? 1 : 0,
        ">=" => leftOperand >= rightOperand ? 1 : 0,
        "==" => leftOperand == rightOperand ? 1 : 0,
        "!=" => leftOperand != rightOperand ? 1 : 0,
        _ => throw new FormatException("Unsupported operator.")
    };
    Console.WriteLine(result == 1 ? "True" : "False");
}
catch (FormatException ex)
{
    Console.WriteLine($"Format error: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
*/
#endregion