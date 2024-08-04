/*
A szervernek támogatni kell az alábbi funkciókat:

DONE    HELP: kilistázza az elérhető parancsok neveit és funkcióit
DONE    LISTA : filmek listázása
DONE    LOGIN|<nev>|<pass>: Bejelentkezteti az adott felhasználót.
DONE    LOGOUT: kijelentkezteti az adott klienst a szerverrol
    KOLCSONZES|<id>: A választott id-ju film kikölcsönzése <értelemszerűen ellenőrízni kell, hogy a film nincs jelenleg kikölcsönözve, és csak login után adhatjuk ki.
    VISSZAVISZ|<id>: Jelezük, hogy a választott id-ju filmet visszavisszük <ellenőrízni kell hogy az adott film nálunk van-e kölcsönözve, login után>
    ADDUSER|<acc>|<pass>: Új felhasználó felvétele, csak admin teheti meg
    USERDEL|<acc>: Felhasználó törlése, csak admin teheti meg
    USERLIST: Userek listázása, nevek és jelszavak, csak admin teheti meg
    ONLINEUSERLIST: Online userek listázása. Kiírja kik vannak aktuálisan bejelentkezve a szerverre <login utáni állapot>.
DONE    EXIT: kommunikáció befejezése, kliens kilép.
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KolcsonzoServer
{
    class Product
    {
        string name, code, user = null;
        int curr_price;
        public string User
        {
            get { return user; }
            set { user = value; }
        }
        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Curr_price
        {
            get { return curr_price; }
            set { curr_price = value; }
        }
        public Product(string name, string code, int curr_price, string user)
        {
            this.name = name; this.code = code; this.curr_price = curr_price; this.user = user;
        }
    }

    class User
    {
        string user, passw;

        public string User
        {
            get { return user; }
            set { user = value; }
        }

        public string Passw
        {
            get { return passw; }
            set { passw = value; }
        }

        public User(string User, string Passw)
        {
            this.User = user; this.Passw = passw;
        }
    }
    class Protocol
    {
        static List<string> Users = File.ReadAllLines("userek.txt").ToList();
        static List<User> ActiveUsers = new List<User>();
        static List<string> Films = File.ReadAllLines("lista.txt").ToList();
        public StreamReader r;
        public StreamWriter w;
        public string user = null;
        List<string> ReadFile = File.ReadAllLines("User.txt").ToList();
        public Protocol(TcpClient c)
        {
            this.r = new StreamReader(c.GetStream(), Encoding.UTF8);
            this.w = new StreamWriter(c.GetStream(), Encoding.UTF8);
        }

        public void StartKomm()
        {
            w.WriteLine("Auction 1.0 beta");
            w.Flush();
            bool ok = true;
            while (ok)
            {
                string command = null;
                try
                {
                    string message = r.ReadLine();// add|1212|1212|1212
                    string[] param = message.Split('|');
                    command = param[0].ToUpper();
                    switch (command)
                    {
                        case "HELP": Help(); break;
                        case "LIST": List(); break;
                        case "LOGIN": Login(param[1], param[2]); break;
                        case "ADD": int price = int.Parse(param[3]); Add(param[1], param[2], price); break;
                        case "BID": int price2 = int.Parse(param[2]); Bid(param[1], price2); break;
                        case "EXIT": w.WriteLine("BYE"); ok = false; break;
                        default: w.WriteLine("ERR|Unknown command"); break;
                    }
                }
                catch (Exception e)
                {
                    w.WriteLine("ERR|{0}", e.Message);
                }
                w.Flush();
            }
            Console.WriteLine("The client disconnected");
        }

        void AddUser(string name, string passw)
        {
            if (this.user == null)
            {
                w.WriteLine("ERR|Please, log in.");
            }
            else if (this.user != "Admin")
            {
                w.WriteLine("ERR|Only admins can do that.");
            }
            else
            {
                using (StreamWriter writer = new StreamWriter("User.txt"))
                {
                    writer.WriteLine("{0}|{1}", name, passw);
                }
            }
            w.WriteLine("OK");
        }
        void Login(string name, string passw)
        {
            for (int i = 0; i < Users.Count(); i++)
            {
                string actuser = Users[i];
                string[] userdata = actuser.Split('|');
                if (name == userdata[0] && passw == userdata[1])
                {
                    user = name;
                    User temp = new User(name, passw);
                    ActiveUsers.Add(temp);
                }
            }
            w.WriteLine("OK");
        }

        void Logout()
        {
            if (user != null)
            {
                user = null;
                for (int i = 0; i < Users.Count; i++)
                {
                    if(ActiveUsers[i].User == user)
                    {
                        ActiveUsers.RemoveAt(i);
                    }
                }
            }
            else
            {
                w.WriteLine("ERR|You need to log in, to log out.");
            }
        }
        void List()
        {
            w.WriteLine("OK*");
            lock (Films)
            {
                foreach (Product item in Films)
                    w.WriteLine(item.Code + ", " + item.Name + ", " + item.Curr_price + ", " + item.User);
            }
            w.WriteLine("OK!");
        }

        void Help()
        {
            w.WriteLine("LISTA : Filmek kilistázása\nLOGIN|<nev>|<passw> : Bejelentkezteti az adott felhasználót\nLOGOUT : Kijelentkezteti az adott felhasználót.\nKOLCSONZES|<id> : A választott id-jű film kikölcsönzése.\nVISSZAVISZ|<id> : A választott id-jű film visszavitele.\nADDUSER|<acc>|<pass> : Új felhasználó felvétele.\nUSERDEL|<acc> : Felhasználó törlése.\n USERLIST : Létező Userek kilistázása\n ONLINEUSERLIST : Az online Userek kilistázása.\nEXIT : Kommunikáció befejezése.");
        }

        void Bid(string code, int price)
        {
            if (user == null)
            {
                w.WriteLine("ERR|Log in, please!"); //only after login
            }
            else
            {
                lock (Products)
                {
                    int j = 0;
                    for (j = 0; j < Products.Count && Products[j].Code != code; j++) ;  //exisiting code?
                    if (j >= Products.Count) //no, unknown product
                    {
                        w.WriteLine("ERR|This code is not found");
                    }
                    else
                        if (Products[j].Curr_price < price)  //the offere price is larger then the curr?
                        {
                            Products[j].Curr_price = price;  //change it!
                            Products[j].User = user;
                            w.WriteLine("OK");
                        }
                        else
                            w.WriteLine("ERR|Low price");
                }
            }
        }
    }


    class Program
    {

        static void Main(string[] args)
        {

            IPAddress ip = IPAddress.Parse("127.0.0.1");
            TcpListener listener = new TcpListener(ip, 12345);
            listener.Start();
            bool ende = false;
            while (!ende)
            {
                Console.WriteLine("The server is waiting for an incoming connection...");
                TcpClient client = listener.AcceptTcpClient();
                Protocol pr = new Protocol(client);
                Thread th = new Thread(pr.StartKomm);
                th.Start();
            }
        }
    }
}
