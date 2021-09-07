﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_PROJECT_1
{
    class Wall : IPart
    {
        private bool _built;
        void IPart.Built() { _built = true; }
        bool IPart.IsBuilt() { return _built; }
        public Wall() { _built = false; }
    }
}
