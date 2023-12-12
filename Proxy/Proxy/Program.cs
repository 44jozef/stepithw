//P.S Я не уверенн что я правильно сделал,но я старался 😊

using Proxy.Classes;
using System.Globalization;

Console.WriteLine("Enter movie Title : ");
String title = Console.ReadLine();

ThirdPartyMoviesClass thirdPartyMoviesClass = new(title);
MoviesManager moviesManager = new(thirdPartyMoviesClass);
MovieSeachHistoryClass movieSeachHistoryClass = new(thirdPartyMoviesClass);

moviesManager.ShowTitltes();

moviesManager.ShowAllInfo();

movieSeachHistoryClass.SaveToJson();
