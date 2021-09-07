using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_PROJECT_1.Classes
{
    class Worker : IWorker
    {
        void IWorker.Work(House houseToBuild)
        {
            IPart nextPart = new Basement();
            foreach (var housesPart in houseToBuild.Parts)
                if (housesPart.IsBuilt() == false)
                {
                    nextPart = housesPart;
                    break;
                }
            nextPart.Built();
        }
    }
}
