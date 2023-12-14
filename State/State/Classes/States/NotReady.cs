using State.Abstract_Classes;
using State.Classes.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Classes.States;

internal class NotReady : StateNow
{
    public NotReady()
    {

    }

    public override void DoHomeWork(HomeWork _HomeWork)
    {
        _HomeWork.Title = "Patterns";
        _HomeWork.Description = "State Pattern";
        _HomeWork.State = new UnderCheck();
    }

}
