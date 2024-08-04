using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // létrehozzuk a weatherData objektumot
            WeatherData weatherData = new WeatherData();
            // létrehozzuk a displayt és odaajuk neki a weatherData-t
            CurrentConditionsDisplay currentDisplay =
                                     new CurrentConditionsDisplay(weatherData);
            // új időjárási mérésértékek szimulálása
            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);
            Console.ReadKey();

        }
    }
}

/*
 Observer (Megfigyelő):

viselkedési tervezési minta, amely lehetővé teszi, hogy egy objektum megváltozása esetén értesíteni tudjon más objektumokat
az alany tárolja a megfigyelőket és értesíti őket a változásokról
két fajtája van: húzó (pull) és toló (push) megfigyelő
amikor alkalmazzuk:
ha az objektumok közötti kapcsolat egy-sok kapcsolat, és a változások figyelésére van szükség
például: hőmérséklet érzékelő, ami kiírja az adatokat a telefon és az ablak displayre

működése:
az alany interfészt biztosít a megfigyelők be- és kiregisztrálására
a megfigyelők interfészt biztosítanak a frissítések fogadására

előnyök:
laza kapcsolódás az alany és a megfigyelők között
könnyen bővíthető új megfigyelőkkel

hátrányok:
nehéz lehet kezelni a sok megfigyelőt és a frissítési folyamatokat
 
 */
