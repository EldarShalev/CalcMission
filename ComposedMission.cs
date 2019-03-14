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
        private List<Delegate> listOfDelegates=new List<Delegate>();
        public ComposedMission(string name)
        {
            this.name1 = name;
        }
        public string Name => this.name1;

        public string Type => throw new NotImplementedException();

        public event EventHandler<double> OnCalculate;

        public double Calculate(double value)
        {
            throw new NotImplementedException();
        }

        public ComposedMission Add(Delegate d)
        {
            this.listOfDelegates.Add(d);
            return this;
        }
    }
}
