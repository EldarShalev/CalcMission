using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    public delegate double singleDeg(double d);
    class FunctionsContainer
    {
       
        // Members 
        // Creating dictionary to map between name to function
        private Dictionary<string, singleDeg> dict = new Dictionary<string, singleDeg>();

        // Using indexer for overloading square brackets
        public singleDeg this [string name]
        {
            get
            {
                if (dict.ContainsKey(name))
                {
                    return dict[name];
                }
                // If the name doesn't exist- create it, which returns the same value
                else
                {
                    dict[name] = val => val;
                    return dict[name];
                }
            }
            set
            {
                dict[name] = value;
            }
        }
        

        public void PrintDict()
        {
            Console.WriteLine("All Availble Functions");
            foreach (KeyValuePair<string, singleDeg> kvp in this.dict)
            {
                Console.WriteLine(kvp.Key);
            }
            Console.WriteLine("#######################");

        }

        public List<string> getAllMissions()
        {
            List<string> lst = new List<string>();
            foreach (KeyValuePair<string, singleDeg> kvp in this.dict)
            {
                lst.Add(kvp.Key);
            }
            return lst;

        }
    }
}

