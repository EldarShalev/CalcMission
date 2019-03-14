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
        Delegate singleDeg;
        public SingleMission(Delegate func, string name)
        {
            this.singleDeg = func;
            this.name1 = name;
        }

        public string Name =>  this.name1;

        public string Type => throw new NotImplementedException();

        public event EventHandler<double> OnCalculate;

        public double Calculate(double value)
        {
            
        }
        
        
    }
}
