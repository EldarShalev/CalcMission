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
        public string Name => this.name1;

        public string Type => "Composed";

        public event EventHandler<double> OnCalculate;//all calculate.invoke (this,result) invoke

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

        public ComposedMission Add(singleDeg d)
        {
            this.listOfDelegates.Add(d);
            return this;
        }
    }
}
