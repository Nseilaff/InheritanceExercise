using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public bool UsableWings { get; set; }
        public string Color { get; set; }
        public int LayEggs { get; set; }
        public string BirdSize { get; set; }
    }
}
