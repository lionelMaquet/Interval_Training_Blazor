using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interval_Training
{
    public class Step
    {
        public int CurrentMinutes;
        public int CurrentSpeed;

        public Step()
        {
            CurrentMinutes = 0;
            CurrentSpeed = 1;
        }
    }
}
