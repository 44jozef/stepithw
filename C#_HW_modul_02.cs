
#region 1
#if false

class Program
{
    static void Main(string[] args)
    {
        System.Console.OutputEncoding = System.Text.Encoding.UTF8;
        int[] a = new int[5];
        Console.WriteLine("Введите 5 чисел для массива А: ");
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write($"A[{i}]: ");
            a[i] = int.Parse(Console.ReadLine());
        }
        int[,] b = new int[3, 4];

        Random random = new Random();
        for (int i = 0; i < b.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
            {
                b[i, j] = (int)random.NextDouble();
            }
        }

        Console.WriteLine("Массив А: ");
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write((int)a[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Массив B: ");
        for (int i = 0; i < b.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
            {
                Console.Write(((int)b[i, j]) + " ");
            }
            Console.WriteLine();
        }

        int aMax = a[0];
        int bMax = b[0, 0];

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] > aMax)
            {
                aMax = a[i];
            }
        }

        for (int i = 0; i < b.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
            {
                if (b[i, j] > bMax)
                    bMax = b[i, j];
            }
        }


        Console.WriteLine($"Максимальный элемент: {Math.Max(aMax, bMax)}");

        int aMin = a[0];
        int bMin = b[0, 0];

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] > aMin)
            {
                aMin = a[i];
            }
        }

        for (int i = 0; i < b.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
            {
                if (b[i, j] < bMin)
                {
                    bMin = b[i, j];
                }
            }
        }

        Console.WriteLine($"Минимальный элемент: {Math.Min(aMin, bMin)}");

        int aSum = 0;
        int bSum = 0;

        for (int i = 0; i < a.Length; i++)
        {
            aSum += a[i];
        }

        for (int i = 0; i < b.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
            {
                bSum += b[i, j];
            }
        }

        Console.WriteLine($"Сумма всех элементов: {aSum + bSum}");

        int aProduct = 1;
        int bProduct = 1;

        for (int i = 0; i < a.Length; i++)
        {
            aProduct *= a[i];
        }

        for (int i = 0; i < b.GetLength(0); i++)
        {
            for (int j = 0;j < b.GetLength(1); j++) { 

                bProduct *= b[i, j];
            }
        }
        Console.WriteLine($"Произведение всех элементов: {aProduct * bProduct}");


        int evenSumA = 0;

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] % 2 == 0)
            {
                evenSumA += a[i];
            }
        }
        Console.WriteLine($"Сумма четных элементов массива А: {evenSumA}");

        int oddColumnB = 0;

        for(int j = 0;j < b.GetLength(1); j++)
        {
            if (j % 2 != 0)
            {
                for(int i = 0; i < b.GetLength (0); i++)
                {
                    oddColumnB += b[i, j];
                }
            }
        }

        Console.WriteLine($"Сумма нечётных столбцов массива B: {oddColumnB}");
    }
}
#endif
#endregion
#region 2
#if false

class Array
{
    static void Main()
    {
        System.Console.OutputEncoding = System.Text.Encoding.UTF8;
        int[,] arr = new int[5, 5];
        Random random = new Random();

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                arr[i, j] = random.Next(-100, 101);
            }
        }

        Console.WriteLine("Двухмерный массив: ");
        for (int i = 0;i < 5; i++)
        {
            for (int j = 0;j < 5; j++)
            {
                Console.Write(arr[i, j] + '\t');
            }
            Console.WriteLine();
        }

        int min = arr[0, 0];
        int max = arr[0, 0];
        int minRow = 0;
        int minCol = 0;
        int maxRow = 0;
        int maxRowCol = 0;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (arr[i, j] < min)
                {
                    min = arr[i, j];
                    minRow = i;
                    minCol = j;
                }
                else if (arr[i, j] > max)
                {
                    max = arr[i, j];
                    maxRow = i;
                    maxRowCol = j;
                }
            }
        }

        int sum = 0;
        int startRow = Math.Min(minRow, maxRow) + 1;
        int endRow = Math.Max(minRow, maxRow);
        int startCol = Math.Min(minCol, maxRowCol) + 1;
        int endCol = Math.Max(minCol, maxRowCol);

        for (int i = startRow; i <= endRow; i++)
        {
            for (int j = startCol; j < endCol; j++)
            {
                sum += arr[i, j];
            }
        }

        Console.WriteLine($"Сумма элементов между минимальными ({min})) и максимальным ({max}) элементами: {sum}");
    }
}


#endif
#endregion
#region 3
#if false

class Encrypt
{
    static void Main()
    {
        System.Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введите строку: ");
        string input = Console.ReadLine();

        Console.WriteLine("Введите ключ шифрования (целое число): ");
        int key = Int32.Parse(Console.ReadLine());

        string encryptedText = CaesarEncrypt(input, key);

        Console.WriteLine("Зашифрованная строка: ");
        Console.WriteLine(encryptedText);
    }

    static string CaesarEncrypt(string input, int key)
    {
        key = key % 26;
        char[] chars = input.ToCharArray();

        for (int i = 0; i < chars.Length; i++)
        {
            if (char.IsLetter(chars[i]))
            {
                char baseChar = char.IsUpper(chars[i]) ? 'A' : 'a';
                chars[i] = (char)((chars[i] - baseChar + key) % 26 + baseChar);
            }
        }

        return new string(chars);

    }
}



#endif
#endregion
#region 5
#if false

class Matematic
{
    static void Main()
    {
        System.Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введите первое число: ");
        int number1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        int number2 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Выберите операцию: ");
        Console.WriteLine("1. - ");
        Console.WriteLine("2. + ");
        int operation = Int32.Parse(Console.ReadLine());

        if (operation != 1 && operation != 2)
        {
            Console.WriteLine("Нет такого выбора, повторите попытку! ");
            return;
        }
        else
        {
            double result = Calculate(number1, number2, operation);
            Console.WriteLine($"Результат: {result}");
        }
    }

    static double Calculate(int number1, int number2, int operation)
    {
        switch (operation)
        {
            case 1:
                return number1 - number2;
            case 2:
                return number1 + number2;
        }
        return 0;
    }
    
}


#endif
#endregion
#region 6
#if false

using System.Text;
using System.Text.RegularExpressions;

class Text
{
    static void Main()
    {
        System.Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введите текст: ");
        string inputText = Console.ReadLine(); 

        string resText = CapitalizeSentences(inputText);

        Console.WriteLine("Новый текст: ");
        Console.WriteLine(resText);
    }


    static string CapitalizeSentences(string text)
    {
        StringBuilder result = new StringBuilder(text);

        bool capitalizeNext = true;

        for (int i = 0; i < result.Length; i++)
        {
            if (char.IsLetter(result[i]))
            {
                if (capitalizeNext)
                {
                    result[i] = char.ToUpper(result[i]);
                    capitalizeNext = false;
                }
            }
        }
        return result.ToString();
    }
}




#endif
#endregion"# CSharp" 
"# CSharp" 
"# CSharp" 
