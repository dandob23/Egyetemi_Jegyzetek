using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1004
{
    internal static class Controller
    {
        public static PowerGrid powerGrid = new PowerGrid();
        static List<Household> households = new List<Household>();
        static List<Core> core = new List<Core>();

        static double logConsumed_mWh = 0;
        static double logProduced_mWh = 0;

        public static void ProducePower(Core core, double mwh)
        {
            Monitor.Enter(powerGrid);
            while (powerGrid.PowerNeed < -3 && powerGrid.MWh > 15)
            {
                core.DecreaseProduction();
                Monitor.Wait(powerGrid);
            }
            if (powerGrid.PowerNeed>5)
            {
                core.IncreaseProduction();
            }
            powerGrid.AddPower(mwh);
            logProduced_mWh += mwh;
            Monitor.PulseAll(powerGrid);
            Monitor.Exit(powerGrid);
        }

        public static void ConsumePower(double mwh)
        {
            Monitor.Enter(powerGrid);

            while (!powerGrid.HasEnoughPower(mwh))
            {
                Monitor.Wait(powerGrid);
            }
            if (powerGrid.HasEnoughPower(mwh))
            {
                powerGrid.GetPower(mwh);
                logConsumed_mWh += mwh;
                Monitor.PulseAll(powerGrid);
                Monitor.Exit(powerGrid);
            }
        }

        public static void CreateHouseholds()
        {
            for (int i = 0; i < 200; i++)
            {
                households.Add(new Household());
            }
        }
        
        public static void CreateCores()
        {
            for (int i = 0; i < 5; i++)
            {
                core.Add(new Core());
            }
        }

        public static void StartCores()
        {
            foreach (var core in core)
            {
                new Thread(core.Work).Start();
            }
        }

        public static void StartHouseholds() 
        {
            foreach (var household in households)
            {
                new Thread(household.Work).Start();
            }    
        }

        public static void StartLogger()
        {
            new Thread(Logger).Start();
        }

        static void Logger()
        {
            while (true)
            {
                Console.Clear();
                Console.Write(
                    "====================================\n" +
                    $"Cores have produced: {logProduced_mWh} MWh\n"+
                    $"Housholds have consumed: {logConsumed_mWh} MWh\n"+
                    $"Current need of power: {powerGrid.PowerNeed} MWh\n"+
                    $"Currently held power: {powerGrid.MWh} MWh\n"+
                    $"====================================");
                logConsumed_mWh = 0;
                logProduced_mWh = 0;
                Thread.Sleep(1000);
            }
        }
    }
}
