using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class FunctionsContainer
    {
        // Creating CalcDelegate
        public delegate double CalcDelegate(int x);

        // Creating dictionary to map between name to function
        private Dictionary<string, CalcDelegate> dict = new Dictionary<string, CalcDelegate>();

        // Using indexer for overloading square brackets
        public CalcDelegate this [string name]
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
                if (!dict.ContainsKey(name))
                {
                    dict[name] = value;
                }
            }
        }
        

        public void PrintDict()
        {
            Console.WriteLine("All Availble Functions");
            foreach (KeyValuePair<string, CalcDelegate> kvp in this.dict)
            {
                Console.WriteLine(kvp.Key);
            }
            Console.WriteLine("#######################");

        }
    }
}

