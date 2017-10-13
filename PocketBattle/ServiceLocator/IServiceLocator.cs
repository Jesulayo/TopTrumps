using System;
using System.Collections.Generic;
using System.Text;

namespace PocketBattle.ServiceLocator
{
    public interface IServiceLocator
    {
        T GetService<T>();
    }
}
