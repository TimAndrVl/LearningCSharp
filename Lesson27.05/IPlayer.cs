using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson27._05
{
    internal interface IPlayer
    {
        char Figure { get; set; }
        string Name { get; set; }
        int Step();
    }
}
