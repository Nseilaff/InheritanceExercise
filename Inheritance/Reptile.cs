using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Reptile : Animal

    {
        public string Scales { get; set; }
        public string EnviromentType { get; set; }
        public bool IsAmphibious { get; set; }
        public bool IsPoisonous { get; set; }
    }
}
