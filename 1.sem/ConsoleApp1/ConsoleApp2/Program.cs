using System;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //feladat: kasszagép

            
        // _________TERMÉKEK___________ //
                                      
            int kenyer = 365;           
            int tej = 255;              
            int cipo = 2500;            
            int dzseki = 4555;          
            int gyumolcs = 673;         
            int zoldseg = 455;          
            int edesseg = 1200;         
            int viz = 125;              
            int jatek = 2110;           
            int gabonapehely = 700;



            //______________________________//

            float euro = 350;
            double fizetendo = 0;
            double fizetett = 0;
            int kedvezmenyar=10000;
            double kedvezmeny = 20;  //%//



            fizetendo =2*kenyer+5*cipo+3*zoldseg+4*dzseki+viz;
            Console.WriteLine("Az adott ár forintban: {0} Ft", fizetendo);
            Console.WriteLine("Az adott ár euróban: {0} euro" ,fizetendo/euro);

            if (fizetendo >= kedvezmenyar) 
            {
                fizetendo = fizetendo - (kedvezmeny*(fizetendo/100));
                Console.WriteLine("A termékek összege meghaladja a {0} Ft-ot, így {1}% kedvezményt kaptak!", kedvezmenyar, kedvezmeny);
                Console.WriteLine("Az új ár: {0} Ft!",fizetendo);
            }

            Console.Write("Kérjük adja meg az összeget: ");
            fizetett = int.Parse(Console.ReadLine());

            double utopenz;

            while (fizetett < fizetendo)
            {
                Console.Write("A megadott pénz nem elegendő! {0} Ft kell még, kérjük adjon még hozzá! ", fizetendo - fizetett);
                utopenz = int.Parse(Console.ReadLine());
                fizetendo = fizetendo - utopenz;
            }
            

            double visszajaro;

            if (fizetett>fizetendo)
            {
                visszajaro=fizetett - fizetendo;
                Console.WriteLine("A pénz túl sok, így adunk visszajárót!");
                Console.WriteLine("A visszajáró: {0}",visszajaro);

            }
           
                Console.WriteLine(" _______");
                Console.WriteLine("|       |");
                Console.WriteLine("| -   - |");
                Console.WriteLine("|   ˘   |");
                Console.WriteLine("|_______|");
                Console.WriteLine("Köszönjük, hogy nálunk vásárolt! ");
            
            
            
            
            
            Console.ReadKey();
        }
    }
}
