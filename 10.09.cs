#region Task1
/*
using System.Diagnostics;

Magazine magazine = new("Test", "2003", "Description test", "50-123-12-12", "example@gmail.com", 2);
magazine += 5;
magazine.ShowInfo();

magazine.InputInfo();
magazine.ShowInfo();



class Magazine
{
    public string Name { get; set; }
    public string FoundingYear { get; set; }
    public string Description { get; set; }
    public string ContactNumber { get; set; }
    public string ContactEmail { get; set; }
    public int Stuff { get; set; }

    public Magazine(string name, string foundingYear, string description, string contactNumber, string contactEmail, int stuff)
    {
        Name = name;
        FoundingYear = foundingYear;
        Description = description;
        ContactNumber = contactNumber;
        ContactEmail = contactEmail;
        Stuff = stuff;
    }
    public void InputInfo()
    {
        Console.WriteLine("Enter name of the journal");
        Name = Console.ReadLine();
        Console.WriteLine("Enter  year of foundation");
        FoundingYear = Console.ReadLine();
        Console.WriteLine("Enter description of the journal");
        Description = Console.ReadLine();
        Console.WriteLine("Enter contact phone number");
        ContactNumber = Console.ReadLine();
        Console.WriteLine("Enter contact e-mail");
        ContactEmail = Console.ReadLine();
        Console.WriteLine("Enter number of employees");
        Stuff = Convert.ToInt32(Console.ReadLine());
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Name of the journal: {Name}");
        Console.WriteLine($"Year of foundation: {FoundingYear}");
        Console.WriteLine($"Description of the journal: {Description}");
        Console.WriteLine($"Contact phone number: {ContactNumber}");
        Console.WriteLine($"Contact e-mail: {ContactEmail}");
        Console.WriteLine($"Employees: {Stuff}");
    }
    public static Magazine operator +(Magazine magazine, int number)
    {
        magazine.Stuff += number;
        return magazine;
    }
    public static Magazine operator -(Magazine magazine, int number)
    {
        magazine.Stuff -= number;
        return magazine;
    }
    public static bool operator ==(Magazine magazine1, Magazine magazine2)
    {
        if (ReferenceEquals(magazine1, null) && ReferenceEquals(null, magazine2)) 
            return true;
        if (ReferenceEquals(magazine1, null) || ReferenceEquals(null, magazine2))
            return false;

        return magazine1.Stuff == magazine2.Stuff;
    }
    public static bool operator !=(Magazine magazine1, Magazine magazine2)
    {
        return !(magazine1 == magazine2);
    }
    public static bool operator >(Magazine magazine1, Magazine magazine2)
    {
        return magazine1 > magazine2;
    }
    public static bool operator <(Magazine magazine1, Magazine magazine2)
    {
        return magazine1 < magazine2;
    }
    public override bool Equals(object obj)
    {
        if (obj is Magazine magazine)
        {
            return this.Stuff == magazine.Stuff;
        }
        return false;
    }
}
*/
#endregion
#region Task2
/*
using System.Runtime.CompilerServices;

Store store = new("Example", "2000", "Description", "050-000-00-00", "example@gmail.com", 80);
store += 1;
store.ShowInfo();
store.InputInfo();
store.ShowInfo();

class Store
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string Description { get; set; }
    public string ContactNumber { get; set; }
    public string ContactEmail { get; set; }
    public int Square { get; set; }

    public Store(string name, string address, string description, string contactNumber, string contactEmail,int square)
    {
        Name = name;
        Address = address;
        Description = description;
        ContactNumber = contactNumber;
        ContactEmail = contactEmail;
        Square = square;
    }
    public void InputInfo()
    {
        Console.WriteLine("Enter name of the store");
        Name = Console.ReadLine();
        Console.WriteLine("Enter store address");
        Address = Console.ReadLine();
        Console.WriteLine("Enter store profile");
        Description = Console.ReadLine();
        Console.WriteLine("Enter contact phone number");
        ContactNumber = Console.ReadLine();
        Console.WriteLine("Enter contact e-mail");
        ContactEmail = Console.ReadLine();
        Console.WriteLine("Enter store square");
        Square = Convert.ToInt32(Console.ReadLine());
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Name of the store: {Name}");
        Console.WriteLine($"Store address: {Address}");
        Console.WriteLine($"Store profile: {Description}");
        Console.WriteLine($"Contact phone number: {ContactNumber}");
        Console.WriteLine($"Contact e-mail: {ContactEmail}");
        Console.WriteLine($"Store square: {Square}");
    }
    
    public static Store operator +(Store store, int number)
    {
        store.Square += number;
        return store;
    }
    public static Store operator -(Store store, int number)
    {
        store.Square -= number;
        return store;
    }
    public static bool operator ==(Store store1, Store store2)
    {
        if (ReferenceEquals(store1, null) && ReferenceEquals(store2, null))
            return true;
        if (ReferenceEquals(store1, null) || ReferenceEquals(store2, null))
            return false;

        return store1.Square == store2.Square;
    }
    public static bool operator !=(Store store1,Store store2)
    {
        return store1 != store2;
    }
    public static bool operator >(Store store1, Store store2)
    {
        return store1.Square > store2.Square;
    }

    public static bool operator <(Store store1, Store store2)
    {
        return store1.Square < store2.Square;
    }
    public override bool Equals(object? obj)
    {
        if(obj is Store store)
        {
            return this.Square == store.Square;
        }
        return false;
    }
}
*/
#endregion
#region Task3
ReadBook readBook = new();
Book book1 = new("Test1", "Autor");
Book book2 = new("Example2", "Autor");

readBook.AddBook(book1);
readBook.AddBook(book2);
for (int i = 0; i < readBook.Count; i++)
    Console.WriteLine($"{i+1}-th book,{readBook[i]}");
Book bookRemove = new("Test1", "Autor");
readBook.RemoveBook(bookRemove);
for (int i = 0; i < readBook.Count; i++)
    Console.WriteLine($"{i + 1}-th book,{readBook[i]}");

class Book
{
    public string BookName { get; set; }
    public string Autor { get; set; }

    public Book(string bookname, string autor)
    {
        BookName = bookname;
        Autor = autor;
    }
    public override string ToString()
    {
        return $"{BookName} by {Autor}";
    }
}
class ReadBook
{
    private List<Book> books = new List<Book>();
    public void AddBook(Book book)
    {
        books.Add(book);
    }
    public bool RemoveBook(Book book)
    {
        return books.Remove(book);
    }
    public bool ContainsBook(Book book)
    {
        return books.Contains(book);
    }
    public Book this[int index]
    {
        get
        {
            if (index >= 0 && index < books.Count)
                return books[index];
            else
                throw new IndexOutOfRangeException("Index is out of range.");
        }
    }
    public int Count
    {
        get { return books.Count; }
    }
}

#endregion