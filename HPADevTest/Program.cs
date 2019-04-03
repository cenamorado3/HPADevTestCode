using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HPADevTest
{
    class Program : HPA
    {
        static void Main(string[] args)
        {

            var test = new HPA();

            test.stepOne();
            test.stepTwo();
            test.stepThree();
            test.stepFour();
            test.stepFive();
            test.stepSix();
            test.OverloadStep(7);
            test.OverloadStep(8);
            test.OverloadStep(9);
            test.OverloadStep(10);
        }
    }
}

