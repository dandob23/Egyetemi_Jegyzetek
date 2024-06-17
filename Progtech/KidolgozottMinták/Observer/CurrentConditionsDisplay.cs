using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    // a display implementálja az Observert,
    //így fogadhat változásokat a WeatherData objektumtól
    // továbbá implementálja a DisplayElement-et, mivel 
    //minden display element-nek implementálnia kell ezt az interfészt

    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private ISubject weatherData;
        // a konstruktor megkapja a weatherData objektumot
        // (a Subject) és arra használjuk, hogy
        // a display-t observerként regisztráljuk
        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        // amikor az Update() meghívódik, mentjük a temperature-t és a humidity-t
        // majd meghívjuk a Display()-t
        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            Display();
        }
        // Megjelenítjük a legújabb eredményeket
        public void Display()
        {
            Console.WriteLine("Current conditions: " + temperature + "F degrees and " + humidity + "% humidity");
        }

    }
}
