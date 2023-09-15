#region 1
#if false

class Square
{
    static void Main()
    {
        System.Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введите длину стороны квадрата: ");
        int sideLength = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Введите символ для отображения: ");
        char symbol = Char.Parse(Console.ReadLine());

        DisplaySquare(sideLength, symbol);


    }

    static void DisplaySquare(int sideLength, char symbol)
    {
        if (sideLength <= 0)
        {
            Console.WriteLine("Длина стороны квадрата должно быть положительным, повторите попытку! ");
            return;
        }
        for (int i = 0; i < sideLength; i++)
        {
            for (int j = 0; j < sideLength; j++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
    }
}




#endif
#endregion
#region 2
#if false
class Polidrom
{
    static void Main()
    {
        System.Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введите число: ");
        int number = Int32.Parse(Console.ReadLine());
        bool isPalindrome = isPalidrome(number);

        if (isPalindrome)
        {
            Console.WriteLine($"{number} - палиндром");    
        }
        else
        {
            Console.WriteLine($"{number} - не палиндром");
        }
    }

    static bool isPalidrome(int number)
    {
        int originalNumber = number;
        int reverseNumber = 0;

        while (number > 0)
        {
            int digit = number % 10;
            reverseNumber = reverseNumber * 10 + digit;
            number /= 10;
        }
        return originalNumber == reverseNumber;
    }
}




#endif
#endregion
#region 3
#if false

class Array
{
    static void Main()
    {
        System.Console.OutputEncoding = System.Text.Encoding.UTF8;
        int[] originalArray = { 1, 2, 6, 7, 8, 9, 10, 11, 12, };
        int[] filterArray = { 6, 88, 7 };
        int[] resultArray = FilterArray(originalArray, filterArray);

        Console.WriteLine("Результат работы метода: ");
        foreach (int number in resultArray)
        {
            Console.WriteLine(number + " ");
        }
    }

    static int[] FilterArray(int[] originalArray, int[] filterArray)
    {
        HashSet<int> result = new HashSet<int>(filterArray);
        int[] resultArray = originalArray.Where(num => !filterArray.Contains(num)).ToArray();

        return resultArray;
    }


}



#endif
#endregion
#region 4
#if false

class WebSite 
{
    private string _siteName = string.Empty;
    private string _siteURL = string.Empty;
    private string _url = string.Empty;
    private string _ipAdress = string.Empty;

    public void InputData()
    {
        Console.WriteLine("Введите название сайта: ");
        _siteName = Console.ReadLine();

        Console.WriteLine("Введите путь к сайту: ");
        _siteURL = Console.ReadLine();

        Console.WriteLine("Введите описания сайта: ");
        _url = Console.ReadLine();

        Console.WriteLine("Введите IP адрес сайта: ");
        _ipAdress = Console.ReadLine();
    }

    public void OutputData()
    {
        Console.WriteLine("Информация о веб-сайте: ");
        Console.WriteLine($"Название сайта: {_siteName}");
        Console.WriteLine($"Путь к сайту: {_siteURL}");
        Console.WriteLine($"Описания сайта: {_url}");
        Console.WriteLine($"IP адрес сайта: {_ipAdress}");
    }

    class Program
    {
        static void Main()
        {
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            WebSite site = new WebSite();
            site.InputData();
            Console.Clear();
            site.OutputData();
        }
    }
}




#endif
#endregion
#region 5
#if false

using System.Globalization;

class Journal
{
    private string _journalName = string.Empty;
    private DateTime _dateOfFoundation;
    private string _descriptionJournal = string.Empty;
    private string _phoneNumber = string.Empty;
    private string _email = string.Empty;

    public void InputData()
    {
        Console.WriteLine("Введите названия журнала: ");
        _journalName = Console.ReadLine();
        Console.WriteLine("Введите год основания: (год.месяц.день)");
        string dateOfFoundationS = Console.ReadLine();
        if (DateTime.TryParseExact(dateOfFoundationS, "yyyy.MM.dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateOfFoundation))
        {
            _dateOfFoundation = dateOfFoundation;
        }
        else
        {
            Console.WriteLine("Некорректный формат даты. Запустите программу заново, чтобы повторить попытку.");
        }

        Console.WriteLine("Введите описания журнала: ");
        _descriptionJournal = Console.ReadLine();
        Console.WriteLine("Введите контактный телефон: ");
        _phoneNumber = Console.ReadLine();
        Console.WriteLine("Введите контактный e-mail: ");
        _email = Console.ReadLine();

    }

    public void OutputData()
    {
        Console.WriteLine("Информация о журнале: ");
        Console.WriteLine($"Название журнала: {_journalName} ");
        Console.WriteLine($"Год основания журнала: {_dateOfFoundation.ToString()}");
        Console.WriteLine($"Описание журнала: {_descriptionJournal}");
        Console.WriteLine($"Контактный телефон: {_phoneNumber}");
        Console.WriteLine($"Контактный e-mail: {_email}");
    }


    class Program
    {
        static void Main()
        {
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            Journal journal = new Journal();
            journal.InputData();
            Console.Clear();
            journal.OutputData();
        }
    }

}


#endif
#endregion
#region 6
#if false


class Magazine
{
    private string _nameMagazine = string.Empty;
    private string _typeMagazine = string.Empty;
    private int _typeMagazineChoice = 0;
    private string _adressMagazine = string.Empty;
    private string _descriptionMagazine = string.Empty;
    private string _contactPhoneMagazine = string.Empty;
    private string _contactEmailMagazine = string.Empty;

   

    public void inputData()
    {
        Console.WriteLine("Введите имя магазина: ");
        _nameMagazine = Console.ReadLine();

        while (true)
        {
        Console.WriteLine("Выберите тип магазина: ");
        Console.WriteLine("1. Обычный магазин");
        Console.WriteLine("2. Супермаркет");
        Console.WriteLine("3. Гипермаркет");
        _typeMagazineChoice = Int32.Parse(Console.ReadLine());
        if (_typeMagazineChoice == 1)
        {
            _typeMagazine = "Обычный магазин ";
            break;
        }
        else if (_typeMagazineChoice == 2)
        {
            _typeMagazine = "Супермаркет ";
            break;
        }
        else if (_typeMagazineChoice == 3)
        {
            _typeMagazine = "Гипермаркет ";
            break;
        }
        else
        {
            Console.WriteLine("Сделайте правильный выбор! ");
            Console.Clear();
        }
    }

        Console.WriteLine("Введите адрес магазина: ");
        _adressMagazine = Console.ReadLine();

        Console.WriteLine("Введите описания магазина: ");
        _descriptionMagazine = Console.ReadLine();

        Console.WriteLine("Введите контактный номер магазина: ");
        _contactPhoneMagazine = Console.ReadLine();

        Console.WriteLine("Введите контактный e-mail магазина: ");
        _contactEmailMagazine = Console.ReadLine();
    }

    public void outputData()
    {
        Console.WriteLine("Информация о магазине: ");
        Console.WriteLine($"Имя магазина: {_nameMagazine}");
        Console.WriteLine($"Тип магазина: {_typeMagazine}");
        Console.WriteLine($"Адрес магазина: {_adressMagazine}");
        Console.WriteLine($"Описания магазина: {_descriptionMagazine}");
        Console.WriteLine($"Контактный номер магазина: {_contactPhoneMagazine}");
        Console.WriteLine($"Контактный e-mail магазина: {_contactEmailMagazine}");
    }

}
class Program
{
    static void Main()
    {
        System.Console.OutputEncoding = System.Text.Encoding.UTF8;
        Magazine magazine = new Magazine();
        magazine.inputData();
        Console.Clear();
        magazine.outputData();
    }
}



#endif
#endregion
