namespace gymFitness;

class Program
{
    static void Main(string[] args)
    {
        PremiumMember premiumMember = new PremiumMember("John Doe", 25);
        premiumMember.DisplayMembershipDetails();
    }
}