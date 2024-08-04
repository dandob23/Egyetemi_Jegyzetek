using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    // implementáljuk a Subject interfészt
    public class WeatherData:ISubject
    {
        // hozzáadunk egy listát amiben observereket tárolunk
        private List<IObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure;
        public WeatherData()
        {
            // létrehozzuk az observereket tároló listát
            observers = new List<IObserver>();
        }
        public void RegisterObserver(IObserver o)
        {
            // amikor egy observer regisztrál, egyszerűen hozzáadjuk a listához
            observers.Add(o);
        }
        public void RemoveObserver(IObserver o)
        {
            // amikor egy observer kéri a törlését, egyszerűen töröljük a listából
            int i = observers.IndexOf(o);
            if (i >= 0)
            {
                observers.Remove(o);
            }
        }
        // itt szólunk az observereknek az állapotról
        // mivel mind observerek, van Update() metódusuk, így tudjuk őket értesíteni
        public void NotifyObservers()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                IObserver observer = observers[i];
                observer.Update(temperature, humidity, pressure); // ez push-os
                // observer.Update(this); // ez pull-os
            }
        }
        // amikor a Weather Station-től megkapjuk a frissített értékeket, 
        //értesítjük az observereket
        public void MeasurementsChanged()
        {
            NotifyObservers();
        }
        // értékek beállítása hogy tesztelhessük a megjelenítést
        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }

    }
}
