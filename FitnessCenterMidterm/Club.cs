using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenterMidterm
{
    internal class Club
    {
        string Name { get; set; }
        string Address { get; set; }
        public Club(string name, string address)
        {
            Name = name;
            Address = address;
        }
    }
}
