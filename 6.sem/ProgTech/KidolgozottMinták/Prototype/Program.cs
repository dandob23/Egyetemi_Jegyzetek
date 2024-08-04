using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a versenyautó és a teherautó prototípus létrehozása
            Gépkocsi prototipus1 = new Versenyauto("Aston Martin", 4, 180, 220);
            Gépkocsi prototipus2 = new Teherauto("Csepel", 3, 200, 1000);
            Gyar gyartosor = new Gyar();
            // legyárt 10 piros versenyautót
            Gépkocsi[] vk = gyartosor.sorozatgyartas(prototipus1, "Piros", 10);
            foreach (Versenyauto v in vk) { Console.WriteLine(v); }
            // legyárt 20 szürke teherautót
            Gépkocsi[] tk = gyartosor.sorozatgyartas(prototipus2, "Szürke", 20);
            foreach (Teherauto t in tk) { Console.WriteLine(t); }
            Console.ReadLine();

        }
    }
}

/*
 Prototype (Prototípus):

létrehozási tervezési minta, amely egy prototípus klónozásával gyárt objektumokat
klónok az eredeti prototípus pontos másolatai, de saját memóriacímmel rendelkeznek
fő technika: klónozás (deep copy)
sekély klónozás (shallow copy): az objektum referencia típusú mezőit csak másoljuk
mély klónozás (deep copy): az objektum referencia típusú mezőit is klónozzuk, így az új klón teljesen független lesz az eredetitől
amikor alkalmazzuk:
ha sok hasonló objektumot kell létrehozni, és az objektumok létrehozása költséges
például: gépkocsigyártás, ahol egy általános gépkocsi osztályból különböző járműtípusokat lehet létrehozni

működése:
az eredeti objektumot klónozzuk, így új objektumot hozunk létre, amely az eredetivel azonos belső állapotú
a klónozáshoz a MemberwiseClone() metódust használjuk

előnyök:
gyorsabb létrehozás, mint a teljes példányosítás
kevesebb memóriahasználat

hátrányok:
néha bonyolult lehet a klónozási folyamat implementálása
a mély klónozás nehézségei
 */
