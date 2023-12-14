using State.Abstract_Classes;
using State.Classes.Entity;
using State.Classes.States;

HomeWork homeWork = new HomeWork();

homeWork.State.DoHomeWork(homeWork); // State поменялся на UnderCheck (Если сделать DoHomeWork снова он ничего не сделает )
homeWork.State.CheckHomeWork(homeWork); // State поменялся на Checked

Console.WriteLine(homeWork);
Console.WriteLine(homeWork.State.ShowMark(homeWork));