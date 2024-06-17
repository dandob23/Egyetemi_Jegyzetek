using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gate gate = new Gate(); //kapu példányosítása, alapértelmezetten zárva van


            gate.Enter(); //nem tud belépni
            
            gate.Pay(); //fizetés -> OpenGateState-re vált
            
            gate.PayOk(); //fizetést már elfogadtuk
            
            gate.Enter(); //belépés




            Console.ReadKey();
        }
    }
}

/*
 State:

viselkedési tervezési minta
használat ha: több összefüggő változékony metódust akarunk kiemelni és azokat delegációval meghívni
Az objektum viselkedése függ az állapotától -> futás közben változtatja meg
Nagy feltételes ágak (switch/if-else) -> Az aktuális állapottól függően a műveleteknek nagy feltételes ágai vannak

Előnyok:
Egységbe zárja az állapotfüggő viselkedést -> könnyű új állapotokat bevezetni
A kód könnyebben áttekinthetőbb, mivel nincsen annyi if-elseif-switchcase
Az állapot objektumokat meg lehet osztani (újrafelhasználható)

Hátrányok:
osztályok száma megnő
*/
