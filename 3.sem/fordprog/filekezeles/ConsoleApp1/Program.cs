using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Authentication.ExtendedProtection;

namespace filekezelo
{
    class csere
    {
        string expression =  @"(1*4)+6((4-3)-2)+4+55";
        Stack<char> St = new Stack<char>();
        public bool check()
        {
            return true;
        } 





        //Ellenorzi a zarojelek helyesseget
        //Kiertekeli a kifejezest
        //stack st....

        /*
         (1*4) + 6
            ((4-3)-2)
        //komment1
        //komment2
        +4
        +55
         */

        //(1*4)+6((4-3)-2)+4+55//

       
        /*
         file
         file beolvasas
         class
         
        stack egy stringen vegig megy megnezi ()
        filekezeles  
        */
    }
    class sourceHandler
    {
        string path;
        public string content;

        
        //TODO property

        StreamReader SR;
        StreamWriter SW;
        bool debug = true;
    protected Dictionary<string, string> openSearchList (
        string path, Dictionary<string, string> D)
            {
            var D2 = D;
            try
            {
                SR = new StreamReader(File.OpenRead(path));
                while (SR.Peek() > -1) 
                {
                    string s = SR.ReadLine();
                    string[] elem = s.Split(',');

                    D2.Add(elem[0], elem[1]);  

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e); 
            }
            return D2;
        }

        //Konstruktorok
        public sourceHandler() { }
        public sourceHandler(string path) {
            this.path = path;
            readDict();
        
        }

        //public sourcehandler (string path,....) {}


        /*protected Dictionary<string, string> readList
           (string path, Dictionary<string, string> D)
        {
            try
            {
                string fileContent = openFile(path);
                string[] elemekList = fileContent("\r\n");
                foreach (string s in elemekList)
                {
                    string[] cserek = s.Split(",");
                    D.Add(cserek[0], cserek[1]);
                }
            }
            catch (IndexOutOfRangeException r)
            {
                Console.WriteLine("Error: {0}", r.Message);
            }
            return D;
        }
        */


        Dictionary<string, string> D;
        protected void readDict()
        {
            D = new Dictionary<string, string>();
                                                                            //DICTIONARY
            D.Add("  ", " ");
            D.Add("123456789", "*rejtett szám*");
            D.Add("!+%", "*random jelek*");
            D.Add("\r\n", "\n");
            D.Add("das", "!");
            D.Add("asd", "ASD");
        }

        
        

        //cserék
        public void replace()
        {
            foreach (var d in D)
            {
                while (content.IndexOf(d.Key) > -1)
                {
                    content = content.Replace(d.Key, d.Value);
                }
            }
            


        }

        //file kezelés
        public void openFile(string path) {
            SR = new StreamReader(File.OpenRead(path));

            try
            {
                content = SR.ReadToEnd();

                /*while (SR.Peek() > -1)
                {
                    string s = SR.ReadLine();
                }*/

                SR.Close();
            }
            catch (IOException IOE)
            {
                Console.WriteLine("IO error: {0}",IOE.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("IO error: {0}", e.Message);
            }
        }
        public void openFile() {
            openFile(this.path);
        
        }
        public void writeFile(string path) {
            
            try
            {
                SW = new StreamWriter(File.OpenWrite(path));
                SW.WriteLine(content);
                SW.Flush();
                SW.Close();
                
            }
            catch (IOException IOE)
            {
                Console.WriteLine("IO error: {0}", IOE.Message);

            }
            catch(Exception e)
            {
                Console.WriteLine("IO error: {0}", e.Message);
            }
        }
        public void writeFile() {
            writeFile(this.path);
        }

        
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("-----------");
            Console.WriteLine("EGYIK.TXT");
            Console.WriteLine("-----------");
            sourceHandler SHR = new sourceHandler(@"C:\Users\Lenovo\Desktop\Egyetem\orai\fordprog\filekezeles\egyik.txt");
            SHR.openFile();
            Console.WriteLine(SHR.content);
            SHR.replace();
            Console.WriteLine("-----------\r\n");


            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("-----------");
            Console.WriteLine("DICT.TXT");                          
            Console.WriteLine("-----------");
            sourceHandler D = new sourceHandler(@"C:\Users\Lenovo\Desktop\Egyetem\orai\fordprog\filekezeles\dict.txt");
            D.openFile();
            Console.WriteLine(D.content);
            SHR.replace();
            Console.WriteLine("-----------\r\n");


            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("-----------");
            Console.WriteLine("MASIK.TXT");
            Console.WriteLine("-----------");
            Console.WriteLine(SHR.content);
            SHR.writeFile(@"C:\Users\Lenovo\Desktop\Egyetem\orai\fordprog\filekezeles\masik.txt");
            D.writeFile(@"C:\Users\Lenovo\Desktop\Egyetem\orai\fordprog\filekezeles\masik.txt");
            Console.WriteLine("-----------");


            Console.Read();
        }
    }
}













/*
 dict.txt
 a,b
...
-------------
tömb["asd", "asd2"]
split(",", "lista[i])   lista[i].split("")
string "mit, mire" ,. ... . . .. . .
-------------
while (Peek () > -1 )
{
string elem1 = SR.Readline();
string[] elem 2= elem.split(",");

D.Add(elem2[0], ... . .)
}
-------------
 */