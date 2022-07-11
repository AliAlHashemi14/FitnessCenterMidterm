/* TO DO: MONDAY
 * ---------------------
 * Clean up code: Place into methods and classes. DONE
 * Fix jank order DONE
 * Finish remove method DONE
 * finish info method DONE
 * -----------------------
 * Generate bill of fees, membership points for multiclub DONE
 * Exception error message for checkins DONE
 * Add method, specific single or multi DONE
 * Optionals are optional.
 * -----------------------
 * Delete seperate lists and join them into one DONE
 * Redo prompts that list both DONE
 * ------------------------                    
 * 
 * FIX THE REMOVE FUNCITON!!!!
 * Remove option 6. bullet point
 * 
 * */

//let user choose who they are, what club they want to enter, check to see if that's the club they're in

using FitnessCenterMidterm;

//Instance of Club list
List<Club> clubs = new List<Club>()
{
    new Club("Planet Fitness","123 Sesame Street", 10),
    new Club("Gold's Gym", "420 Swole Avenue", 30),
    new Club("Lifetime Fitness","69420 Qu1cksc0p3 Boulevard", 50),
    new Club("Globo-Gym", "52 Discovery, Irvine, CA 92618", 100),
    new Club("Multi-Club", "Multiple Addresses", 120),
};

//Instance of SingleClubMember
//List<SingleClubMember> singleClubMembers = new List<SingleClubMember>()
//{
//};

////Instance of MultiClubMember
//List<MultiClubMember> multiClubMembers = new List<MultiClubMember>();

List<Members> memberList = new List<Members>()
{
    new SingleClubMember(1, "Jordan", clubs[0], "Single")
};
//{
//    new MultiClubMember(1, "john", clubs[0])
//};
//Validator.GetInput();



//Main loop for menu and initial prompts
bool runProgram = true;
string name = "";

Console.WriteLine("Welcome to this program for gym membership");
do
{

    //Main menu listing
    for (int i = 0; i < clubs.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {clubs[i].Name}");
    }
    Console.WriteLine($"{clubs.Count + 1}.");


    //Join, remove, or information functionality
    while (true)
    {
                
        Console.WriteLine("What is your name?");
        name = Console.ReadLine();
        Console.WriteLine("Are you looking to enter the gym you're at, join, leave, info or quit?");
        string addremove = Console.ReadLine().ToLower().Trim();

        //Add block
        if (addremove == "join")
        {

            Add();
            
        }

        //Remove block
        else if (addremove == "leave")
        {
            Remove();
        }
        //Info block
        else if (addremove == "info")
        {
            Info();
        }
        else if (addremove == "enter")
        {
            Console.WriteLine("What location would you like to visit? (Enter number)");
            int enter = int.Parse(Console.ReadLine());

            if (enter >= 1 && enter <= clubs.Count() + 1)
            {
                memberList.Where(m => m.Name == name).First().CheckIn(clubs[enter - 1]);
                Console.WriteLine("Welcome to ");
            }
            else
            {
                Console.WriteLine("go away then"); 
            }
           
        }
        else
        {
            Console.WriteLine("Okay have a great day");
            runProgram = false;
        }

                        
    }

}
while (runProgram);

//Add club method
void Add()
{
    Console.WriteLine("Which club would you like to join?");
    int choice = (int.Parse(Console.ReadLine().ToLower().Trim()));


    if (choice - 1 >= 0 && choice < clubs.Count + 1)
    {
        Console.WriteLine($"You've chosen {clubs[choice - 1].Name}");

        
        memberList.Add(new SingleClubMember(memberList.Count() + 1, name, clubs[choice -1], "Single"));
    }
    else if (choice == clubs.Count + 1)
    {
        Console.WriteLine($"You've chosen {clubs[choice - 1].Name}");


        memberList.Add(new MultiClubMember(memberList.Count() + 1, name, clubs[choice - 1], "Multi"));
    }
    //else if (choice == clubs.Count())
    //{
    //    Console.WriteLine("You've chosen a Multi-Club Membership");
    //    multiClubMembers.Add(new MultiClubMember(multiClubMembers.Count() + 1, name, clubs[choice - 1]));
    //}
    else
    {
        Console.WriteLine($"Incorect number, try again");
    }
}

//Remove club method
void Remove()
{
    //Console.WriteLine("Are you a single-club member or a multi-club member?");
    //Console.WriteLine("1. Single \n2. Multi");
    //string response = Console.ReadLine().ToLower().Trim();
    //if( response == "1")
    foreach (Members m in memberList)
    {
        if (m.Name.Equals(name))
        {
            /*
             * 
             * 
             * 
             * FIX ME FIX ME
             * IX ME FIX ME
             * 
             * IX ME FIX ME
             * 
             * IX ME FIX ME
             * IX ME FIX ME
             * 
             * 





            if (m.Membership.Equals("Single"))
            {
                SingleClubMember sm = m as SingleClubMember;
                memberList.Remove(sm);
            }
            else
            {
                MultiClubMember mm = m as MultiClubMember;
                memberList.Remove(mm);
            }
            
        }
    }
    //else if(response == "2")
    //{
    //    foreach (MultiClubMember m in multiClubMembers)
    //    {
    //        if (m.Name.Equals(name))
    //        {
    //            multiClubMembers.Remove(m);
    //            Console.WriteLine("You have been removed.");
    //        }
    //    }
    //}
    //else
    //{
    //    Console.WriteLine("Incorrect input.");
    //}
}

void Info()
{
    //display member information
    //Console.WriteLine("Are you a single-club member or a multi-club member?");
    //Console.WriteLine("1. Single \n2.Multi");
    //string response = Console.ReadLine().ToLower().Trim();
    //if (response == "1")

    //this used to be foreach(Members) but it broke. Does this matter?
        foreach (Members m in memberList)
        {
            if (m.Name.Equals(name))
            {
                //if singleclub memeber display else mutli club
                if (m.Membership.Equals("Single"))
                {
                    SingleClubMember sm = m as SingleClubMember;
                    Console.WriteLine($"Name: {sm.Name} \nID: {sm.Id} \nClub Name: {sm.AssignedClub.Name} \nClub Address: {sm.AssignedClub.Address} \n Fees: {sm.AssignedClub.MemberFee}");
                }
                else
                {
                    MultiClubMember mm = m as MultiClubMember;
                    Console.WriteLine($"Name: { mm.Name} \nID: { mm.Id} \nClub Name: { mm.AssignedClub.Name} \nClub Address: { mm.AssignedClub.Address} \nMember Points: { mm.memberPoints}" +
                    $"\nFees: {mm.AssignedClub.MemberFee}"); 
                }

            }
        }
    
    
}