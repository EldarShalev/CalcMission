using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class SingleMission : IMission
    {
        // Members
        
        private string name1;
        private singleDeg single;
        public SingleMission(singleDeg func, string name)
        {
            single = new singleDeg(func);
            this.name1 = name;
        }

        public string Name =>  this.name1;

        public string Type => "Single";

        public event EventHandler<double> OnCalculate;

        public double Calculate(double value1)
        {
            OnCalculate?.Invoke(this, single(value1));
            return single(value1);
        }
        
        
    }
}
