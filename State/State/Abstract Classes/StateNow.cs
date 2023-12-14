using State.Classes.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Abstract_Classes;

internal abstract class StateNow
{
    public StateNow()
    {
        
    }

    public virtual void DoHomeWork(HomeWork _HomeWork) { }
    public virtual void CheckHomeWork(HomeWork _HomeWork) { }

    public virtual string ShowMark(HomeWork _HomeWork) { return ""; }
}
