using CS_PROJECT_1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_PROJECT_1
{
    class Team
    {
        private List<IWorker> _workers = new List<IWorker>();
        public Team(sbyte workersNumber)
        {
            if (workersNumber < 1 || workersNumber > 10)
                throw new Exception("Некорректное количество сотрудников.");
            for (int i = 0; i < workersNumber; i++)
                _workers.Add(new Worker());
            _workers.Add(new TeamLeader());
        }
        public void BuildHouse(House houseToBuild)
        {
            while (true)
            {
                foreach(var worker in _workers)
                {
                    worker.Work(houseToBuild);
                    if (houseToBuild.IsBuilt()) return;
                }
            }
        }
    }
}
