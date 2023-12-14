using State.Abstract_Classes;
using State.Classes.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Classes.States;

internal class Checked : StateNow
{
    public Checked()
    {

    }

    public override string ShowMark(HomeWork _HomeWork)
    {
        return $"Mark : {Convert.ToString (_HomeWork.Mark)}" ;
    }

}
