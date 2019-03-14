using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class ComposedMission : IMission
    {
        private string name1;
        private List<singleDeg> listOfDelegates=new List<singleDeg>();
        // event handler 
        public ComposedMission(string name)
        {
            this.name1 = name;
        }

        // Return the name
        public string Name => this.name1;

        // Return the type of mission
        public string Type => "Composed";

        public event EventHandler<double> OnCalculate;


        /**
         * Calculate the result using all delegates, invoking to event handler.
         * Return the result
         */
        public double Calculate(double value1)
        {
            double result = value1; 
            for (int i = 0; i < listOfDelegates.Count; i++)
            {
                result =listOfDelegates[i].Invoke(result);
            }
            OnCalculate?.Invoke(this, result);
            return result;
        }

        /**
         * This function gets a delegate and add it to the list of delegates.
         * It returns this, in order to allow multiply adding of delegates.
         */
        public ComposedMission Add(singleDeg d)
        {
            // Adding to list of delegates
            this.listOfDelegates.Add(d);
            // Return this to allow multiply adding
            return this;
        }
    }
}
