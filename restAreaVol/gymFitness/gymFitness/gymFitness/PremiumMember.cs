namespace gymFitness;

internal class PremiumMember : GymMember, IGymMembership
{
    public PremiumMember(string name, int age) : base(name, age) {}

    public override void DisplayMembershipDetails()
    {
        Console.WriteLine($"Premium Membership: {Name}, Age: {Age}");
        Console.WriteLine("Access to all gym facilities");
        Console.WriteLine("Personalized training sessions");
        Console.WriteLine("Specialized classes included");
    }
}