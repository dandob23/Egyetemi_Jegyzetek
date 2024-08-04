using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ital tea = new Tea();
            Ital kávé = new Kávé();
            tea.Elkészít(); // a késői kötés miatt a Tea főz és édesít metódusa fut
            kávé.Elkészít();// a késői kötés miatt a Kávé főz és édesít metódusa fut
            Console.ReadKey();

        }
    }
}

/*
 Template Method (Sablonmetódus):

viselkedési tervezési minta, amely egy általános receptet biztosít, amely alapján több hasonló dolog is gyártható
a recept háromféle lépést tartalmazhat: kötelező és közös, kötelező, de nem közös, opcionális
amikor alkalmazzuk:
ha van egy általános receptünk, amelyet több különböző kontextusban is használhatunk
például: userhez kötött bejegyzések elmentése az adatbázisba

működése:
az ősosztály tartalmazza a sablonmetódust
a gyermekosztályok implementálják a kötelező, de nem közös lépéseket

előnyök:
a sablonmetódus közös lépései az ősosztályban vannak, így könnyen újrahasznosíthatók
az OCP elv betartása

hátrányok:
növeli az osztályok számát és a kód komplexitását
az opcionális lépések felülírása nehézségeket okozhat
 */
