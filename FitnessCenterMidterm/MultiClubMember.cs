using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenterMidterm
{
    internal class MultiClubMember : Members
    {
        public Club assignedClub { get; set; }
        public int memberPoints { get; set; }
        

        public override void CheckIn(Club club)
        {
            if (club == assignedClub) //only gives points
            {
                Console.WriteLine("Hi, thanks checking in.");
                memberPoints += 10;
            }
            else
            {
                Console.WriteLine("Sorry, youre not a member of this club.");
            }
        }


        public MultiClubMember(int _id,string _name, Club _assignedClub)
        {
            Id = _id;
            Name = _name;
            assignedClub = _assignedClub;
           
        }

        //checkin should always pass?
        //membership points and fees raise at checkin. 

    }
}
