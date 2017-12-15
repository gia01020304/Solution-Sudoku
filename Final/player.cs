using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class player
    {
        private string name;
        private int time;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Time
        {
            get
            {
                return time;
            }

            set
            {
                time = value;
            }
        }
    }
}
