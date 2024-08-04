using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL7VQV
{
    internal class SzallitoVallalat:IComparable,IEnumerable
    {

        private List<KuldemenyAlap> kuldemenyek = new List<KuldemenyAlap>();

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            throw new NotImplementedException();
        }

        public void Rogzit(KuldemenyAlap kuldemeny)
        {
            if (kuldemenyek.Contains(kuldemeny))
            {
                throw new Exception("A küldemény már szerepel a listában!");
            }
            else
            {
                kuldemenyek.Add(kuldemeny);
            }
        }

        public IEnumerator GetEnumerator()
        {
            return kuldemenyek.Select(kuldemeny => kuldemeny.Clone()).GetEnumerator();
        }

        public List<KuldemenyAlap> EunKivuliKuldemenyek 
            => kuldemenyek.Where(kuldemeny => kuldemeny.Cim.OrszagKod != "EU").ToList();

        
        public delegate int KuldemenyDelegate(KuldemenyAlap kuldemeny);
        
        
        
        public int Min(KuldemenyDelegate fuggveny)
        {
            int min = int.MaxValue;

            foreach (var kuldemeny in kuldemenyek)
            {
                int ertek = fuggveny(kuldemeny);
                if (ertek < min)
                {
                    min = ertek;
                }
            }
            return min;
        }
    
    }



}

