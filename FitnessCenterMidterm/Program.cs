/* TO DO: MONDAY
 * ---------------------
 * Clean up code: Place into methods and classes. Move lists into classes.
 * Fix jank order
 * Finish remove method
 * finish info method
 * -----------------------
 * Generate bill of fees, membership points for multiclub
 * Exception error message for checkins
 * Add method, specific single or multi
 * Optionals are optional.
 * 
 * */

using FitnessCenterMidterm;

//Instance of Club list
List<Club> clubs = new List<Club>()
{
    new Club("Planet Fitness","123 Sesame Street"),
    new Club("Gold's Gym", "420 Swole Avenue"),
    new Club("Lifetime Fitness",""),
    new Club("Globo-Gym", "52 Discovery, Irvine, CA 92618"),
};

//Instance of SingleClubMember
List<SingleClubMember> singleClubMembers = new List<SingleClubMember>()
{
};

//Instance of MultiClubMember
List<MultiClubMember> multiClubMembers = new List<MultiClubMember>();
Validator.GetInput();


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
    Console.WriteLine($"{clubs.Count + 1}. Multi-Club Membership");


    //Join, remove, or information functionality
    while (true)
    {


        Console.WriteLine("Are you looking to join, leave, info or quit?");
        string addremove = Console.ReadLine().ToLower().Trim();

        //Add block
        if (addremove == "join")
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
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


    if (choice - 1 >= 0 && choice - 1 < clubs.Count())
    {
        Console.WriteLine($"You've chosen {clubs[choice - 1].Name}");
        singleClubMembers.Add(new SingleClubMember(singleClubMembers.Count() + 1, name, clubs[choice]));
        Console.WriteLine($"ID: {singleClubMembers[0].Id}, Name: {singleClubMembers[0].Name}, Club: {singleClubMembers[0].assignedClub.Name}");
    }
    else if (choice == clubs.Count + 1)
    {
        Console.WriteLine("You've chosen a Multi-Club Membership");
        //.add() needs to be added
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
    Console.WriteLine("1. Single \n2.Multi");
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
                Console.WriteLine($"Name: {s.Name} \nID: {s.Id} \nClub Name: {s.assignedClub.Name} \nClub Address: {s.assignedClub.Address}");
            }
        }
    else if (response == "2")
    {
        foreach (MultiClubMember m in multiClubMembers)
        {
            if (m.Name.Equals(name))
            {
                Console.WriteLine($"Name: \nID: \nClub Name: \nClub Address:");
            }
        }
    }
    else
    {
        Console.WriteLine("Incorrect input.");
    }
}