using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_01.Entities
{
    public interface IGenericBehavior<T>
    {
        string GetGenericBehavior<T>(T Data);
    }
}
