using State.Abstract_Classes;
using State.Classes.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Classes.Entity;

internal class HomeWork
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int Mark { get; set; }
    public StateNow State { get; set; }

    public HomeWork()
    {
        State = new NotReady();
    }

    public override string ToString()
    {
        return $"Title : {Title}\nDescription : {Description}";
    }
}
