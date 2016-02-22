using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCalculator
{
    class Facade
    {
        private Numbers numbers;
        private GetOperator go;
        private Display display;

        public Facade()
        {
            numbers = new Numbers();
            go = new GetOperator();
            display = new Display();
        }
        public void Run()
        {
            int one = numbers.One();
            int two = numbers.Two();
            string three = go.Symbol();
            double answer = go.Choice(one, two, three);
            display.Print(answer);
        }

    }
}
