using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_PROJECT_1
{
    class TeamLeader : IWorker
    {
        void IWorker.Work(House houseToBuild)
        {
            sbyte numberBuildParts = 0;
            foreach (var housesPart in houseToBuild.Parts)
                if (housesPart.IsBuilt())
                    numberBuildParts++;
            double builtPercentes = numberBuildParts / (double)houseToBuild.Parts.Count * 100;
            Console.WriteLine($"Дом завершён на {builtPercentes}%");
        }
    }
}
