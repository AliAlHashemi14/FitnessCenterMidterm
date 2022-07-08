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
for(int i = 0; i < clubs.Count; i++)
{
    Console.WriteLine($"{i +1}. {clubs[i].Name}");
}
Console.WriteLine($"{clubs.Count}. Multi-Club Membership");