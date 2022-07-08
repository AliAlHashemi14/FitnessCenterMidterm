using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenterMidterm
{
    internal class MultiClubMember : Members
    {
        public override void CheckIn(Club club)
        {
            throw new NotImplementedException();
        }

        public MultiClubMember(int _id,string _name)
        {
            Id = _id;
            Name = _name;
        }

        //checkin should always pass?
        //membership points and fees raise at checkin. 

    }
}
