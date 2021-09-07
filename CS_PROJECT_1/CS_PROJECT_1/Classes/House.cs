using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_PROJECT_1
{
    class House
    {
        private List<IPart> _parts = new List<IPart>();

        public House(sbyte Walls, sbyte Doors, sbyte Windows)
        {
            _parts.Add(new Basement());
            for (int i = 0; i < Walls; i++) _parts.Add(new Wall());
            for (int i = 0; i < Doors; i++) _parts.Add(new Door());
            for (int i = 0; i < Windows; i++) _parts.Add(new Roof());
        }

        internal List<IPart> Parts { get => _parts; set => _parts = value; }

        public bool IsBuilt()
        {
            foreach (var part in _parts)
                if (!part.IsBuilt()) 
                    return false;
            return true;
        }
    }
}
