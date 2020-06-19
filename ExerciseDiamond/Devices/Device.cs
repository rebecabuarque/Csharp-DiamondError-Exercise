using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseDiamond.Devices
{
    class Device
    {
        public int SerialNumber { get; set; }
        public abstract void ProcessDoc(string document);
    }
}
