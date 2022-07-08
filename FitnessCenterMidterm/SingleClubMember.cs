using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenterMidterm
{
    internal class SingleClubMember : Members
    {
        public override void CheckIn(Club club)
        {
            
            throw new NotImplementedException();
        }

        public SingleClubMember(int _id, string _name)
        {
            Id = _id;
            Name = _name;
        }

    }
}
