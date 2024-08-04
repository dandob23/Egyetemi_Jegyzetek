using Konyvek_03_08;

internal class Program
{
    static void Main(string[] args)
    {
        //Konyv konyv = new Konyv();
        //konyv.Id = 1;
        //konyv.Szerzo = "Robert C. Martin";
        //konyv.Cim = "Tiszta kód";
        //konyv.Ar = 4500;
        //konyv.Isbn = "I-45678214-3";

        //Konyv tisztaKod = new Konyv("Robert C. Martin", "Tiszta kód", 4500, "I-45678214-3");
        //Konyv tuleloKonyv = new Konyv("Robert C. Martin", "Túlélőkönyv", 2350, "I-764235-3");
        //Konyv HarryPotter = new Konyv("J.K. Rowling", "Harry Potter és a bölcsek köve");
        //Konyv headFirst = new Konyv("J.K. Rowling", "HeadFirst Desing Patterns", 3300);

        List<Konyv> konyvek = new List<Konyv>();

        konyvek.Add(new Konyv("Robert C. Martin", "HeadFirst Desing Patterns", 2876));
        konyvek.Add(new Konyv("Robert C. Martin", "Tiszta kód", 4500, "I-45678214-3"));
        konyvek.Add(new Konyv("Robert C. Martin", "Túlélőkönyv", 2350, "I-764235-3"));
        konyvek.Add(new Konyv("J.K. Rowling", "Harry Potter és a bölcsek köve"));


        Console.ReadKey();
    }
}




