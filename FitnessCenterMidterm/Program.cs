/* TO DO: MONDAY
 * ---------------------
 * Clean up code: Place into methods and classes. DONE
 * Fix jank order DONE
 * Finish remove method DONE
 * finish info method DONE
 * -----------------------
 * Generate bill of fees, membership points for multiclub
 * Exception error message for checkins
 * Add method, specific single or multi DONE
 * Optionals are optional.
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
List<SingleClubMember> singleClubMembers = new List<SingleClubMember>()
{
};

//Instance of MultiClubMember
List<MultiClubMember> multiClubMembers = new List<MultiClubMember>();
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
            //Console.WriteLine("Which club would you like to join?");
            //int choice = (int.Parse(Console.ReadLine().ToLower().Trim()));


            //if (choice - 1 >= 0 && choice - 1 < clubs.Count())
            //{
            //    Console.WriteLine($"You've chosen {clubs[choice - 1].Name}");
            //    singleClubMembers.Add(new SingleClubMember(singleClubMembers.Count() + 1, name));
            //    Console.WriteLine($"ID: {singleClubMembers[0].Id}, Name: {singleClubMembers[0].Name}");
            //    break;
            //}
            //else if (choice == clubs.Count + 1)
            //{
            //    Console.WriteLine("You've chosen a Multi-Club Membership");
            //    break;
            //}
            //else
            //{
            //    Console.WriteLine($"Incorect number, try again");
            //}
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
        //else if (addremove =="check in")
        //{
        //    //SingleClubMember.CheckIn();
        //}
        else if (addremove == "enter")
        {

        }
        else
        {
            break;
        }







        
    }

}
while (runProgram);

//Add club method
void Add()
{
    Console.WriteLine("Which club would you like to join?");
    int choice = (int.Parse(Console.ReadLine().ToLower().Trim()));


    if (choice - 1 >= 0 && choice < clubs.Count())
    {
        Console.WriteLine($"You've chosen {clubs[choice - 1].Name}");
        singleClubMembers.Add(new SingleClubMember(singleClubMembers.Count() + 1, name, clubs[choice -1]));
    }
    else if (choice == clubs.Count())
    {
        Console.WriteLine("You've chosen a Multi-Club Membership");
        multiClubMembers.Add(new MultiClubMember(multiClubMembers.Count() + 1, name, clubs[choice - 1]));
    }
    else
    {
        Console.WriteLine($"Incorect number, try again");
    }
}

//Remove club method
void Remove()
{
    Console.WriteLine("Are you a single-club member or a multi-club member?");
    Console.WriteLine("1. Single \n2. Multi");
    string response = Console.ReadLine().ToLower().Trim();
    if( response == "1")
    foreach (SingleClubMember s in singleClubMembers)
    {
        if (s.Name.Equals(name))
        {
            singleClubMembers.Remove(s);
            Console.WriteLine("You have been removed.");
        }
    }
    else if(response == "2")
    {
        foreach (MultiClubMember m in multiClubMembers)
        {
            if (m.Name.Equals(name))
            {
                multiClubMembers.Remove(m);
                Console.WriteLine("You have been removed.");
            }
        }
    }
    else
    {
        Console.WriteLine("Incorrect input.");
    }
}

void Info()
{
    //display member information
    Console.WriteLine("Are you a single-club member or a multi-club member?");
    Console.WriteLine("1. Single \n2.Multi");
    string response = Console.ReadLine().ToLower().Trim();
    if (response == "1")
        foreach (SingleClubMember s in singleClubMembers)
        {
            if (s.Name.Equals(name))
            {
                Console.WriteLine($"Name: {s.Name} \nID: {s.Id} \nClub Name: {s.assignedClub.Name} \nClub Address: {s.assignedClub.Address} \n Fees: {s.assignedClub.MemberFee}");
            }
        }
    else if (response == "2")
    {
        foreach (MultiClubMember m in multiClubMembers)
        {
            if (m.Name.Equals(name))
            {
                Console.WriteLine($"Name: {m.Name} \nID: {m.Id} \nClub Name: {m.assignedClub.Name} \nClub Address: {m.assignedClub.Address} \nMember Points: {m.memberPoints} " +
                    $"\nFees: {m.assignedClub.MemberFee}");
            }
        }
    }
    else
    {
        Console.WriteLine("Incorrect input.");
    }
}