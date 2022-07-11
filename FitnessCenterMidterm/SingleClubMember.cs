using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenterMidterm
{
    internal class SingleClubMember : Members
    {
        public Club assignedClub { get; set; }
                      

        public SingleClubMember(int _id, string _name, Club _assignedClub)
        {
            Id = _id;
            Name = _name;
            assignedClub = _assignedClub;
            
        }

        public override void CheckIn(Club club)
        {
            if (club == assignedClub)
            {
                Console.WriteLine("Hi, thanks checking in.");
            }
            else
            {
                Console.WriteLine("Sorry, youre not a member of this club.");
            }
        }
















        //Needs special property that is associate club.
        /* needs method if club name = club name return 
         * Allows members to enter and non members the door
         * throws exception in main
         * 
         * 
         * 
         * 
         * */


    }
}
