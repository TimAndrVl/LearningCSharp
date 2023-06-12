using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson27._05
{
    internal interface IPlayer
    {
        string Name { get; }
        char Figure { get; set; }
        int Sequence { get; set; }
        int Step();
    }
}
