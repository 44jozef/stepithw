using State.Abstract_Classes;
using State.Classes.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Classes.States;

internal class UnderCheck : StateNow
{
    public UnderCheck()
    {

    }

  

    public override void CheckHomeWork(HomeWork _HomeWork)
    {
        if (_HomeWork.Title != null && _HomeWork.Description != null) 
        {
            Random random = new Random();
            _HomeWork.Mark = random.Next(0,5);
            _HomeWork.State = new Checked();
        }
        else
        {
            throw new Exception("HomeWork is empty");
        }
    }

}
