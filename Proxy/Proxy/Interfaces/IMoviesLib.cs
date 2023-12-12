using Proxy.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Interfaces;

internal interface IMoviesLib
{

    public Movies GetTitles();
    public Movies GetAllInfo();
}
