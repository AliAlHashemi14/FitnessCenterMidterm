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


List<Club> clubs = new List<Club>()
{
    new Club("Planet Fitness","123 Sesame Street"),
    new Club("Gold's Gym", "420 Swole Avenue"),
    new Club("Lifetime Fitness",""),
    new Club("Globo-Gym", "52 Discovery, Irvine, CA 92618"),
};

List<SingleClubMember> singleClubMembers = new List<SingleClubMember>()
{
    new SingleClubMember(1, "John", clubs[0])
};
List<MultiClubMember> multiClubMembers = new List<MultiClubMember>();
Validator.GetInput();

bool runProgram = true;
Console.WriteLine("Welcome to this program for gym membership");

do
{
    for (int i = 0; i < clubs.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {clubs[i].Name}");
    }
    Console.WriteLine($"{clubs.Count + 1}. Multi-Club Membership");

    while (true)
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();


        Console.WriteLine("Are you looking to join, leave or info");
        string addremove = Console.ReadLine().ToLower().Trim();
        if (addremove == "join")
        {
            Console.WriteLine("Which club would you like to join?");
            int choice = (int.Parse(Console.ReadLine().ToLower().Trim()));


            if (choice - 1 >= 0 && choice - 1 < clubs.Count())
            {
                Console.WriteLine($"You've chosen {clubs[choice - 1].Name}");
                singleClubMembers.Add(new SingleClubMember(singleClubMembers.Count() + 1, name));
                Console.WriteLine($"ID: {singleClubMembers[0].Id}, Name: {singleClubMembers[0].Name}");
                break;
            }
            else if (choice == clubs.Count + 1)
            {
                Console.WriteLine("You've chosen a Multi-Club Membership");
                break;
            }
            else
            {
                Console.WriteLine($"Incorect number, try again");
            }
        }
        else if (addremove == "leave")
        {
            foreach (SingleClubMember s in singleClubMembers)
            {
                if (s.Name.Equals(name))
                {
                    singleClubMembers.Remove(s);
                    Console.WriteLine("You have been removed.");
                }
            }
        }
        else if (addremove == "info")
        {

        }
        else
        {
            break;
        }







        
    }

}
while (runProgram);