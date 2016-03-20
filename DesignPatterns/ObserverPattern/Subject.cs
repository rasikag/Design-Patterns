using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface Subject
    {
        void RegisterObserver(Observer O);
        void RemoveObserver(Observer O);
        void NotifyObserver(Observer O);

    }
}
