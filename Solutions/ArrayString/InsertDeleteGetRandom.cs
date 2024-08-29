using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString
{
    public class InsertDeleteGetRandom
    {
        private List<int> list = new();
        private Dictionary <int,int> structure = new();

        public bool Insert(int val)
        {
            if(structure.ContainsKey(val)) {return false;}
            else { list.Add(val); 
                structure.Add(val,list.Count-1);
                return true;
                }
        }

        public bool Remove(int val)
        {
            if(structure.ContainsKey(val)) {
                structure.Remove(val);
                return true;
            }
            else {  return false; }
        }

        public int GetRandom()
        {   int randomNumber = new Random().Next( structure.Count);
            return structure.Keys.ElementAt(randomNumber);
        }
    }
}
