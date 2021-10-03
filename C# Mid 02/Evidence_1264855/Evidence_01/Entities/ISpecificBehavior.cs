using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_01.Entities
{
    public interface ISpecificBehavior<T>
    {
        string GetSpecificBehavior<T>(T Data) where T : Animal;
    }
}
