using FitnessCenterMidterm;


List<Club> clubs = new List<Club>()
{
    new Club("Planet Fitness","123 Sesame Street"),
    new Club("Gold's Gym", "420 Swole Avenue"),
    new Club("Lifetime Fitness",""),
    new Club("Globo-Gym", "52 Discovery, Irvine, CA 92618"),
};

List<SingleClubMember> singleClubMembers = new List<SingleClubMember>();
List<MultiClubMember> multiClubMembers = new List<MultiClubMember>();
Validator.GetInput();
Console.WriteLine("Which club would you like to join?");
foreach(Club club in clubs)
{
    Console.WriteLine(club);
}
