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

            var devTest = new HPA();

            devTest.stepOne();
            devTest.stepTwo();
            devTest.stepThree();
            devTest.stepFour();
            devTest.stepFive();
            devTest.stepSix();
            devTest.OverloadStep(7);
            devTest.OverloadStep(8);
            devTest.OverloadStep(9);
            devTest.OverloadStep(10);
        }
    }
}

