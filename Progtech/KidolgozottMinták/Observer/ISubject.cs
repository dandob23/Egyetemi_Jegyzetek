using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface ISubject
    {
        // observer regisztrálásra
        void RegisterObserver(IObserver o);
        // observer törlésre
        void RemoveObserver(IObserver o);
        // meghívódik, hogy értesítse az megfigyelőket
        // amikor a Subject állapota megváltozik
        void NotifyObservers();

    }
}
