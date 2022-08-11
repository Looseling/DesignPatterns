using FactoryMethod_Pattern.Domain;
using FactoryMethod_Pattern.Factory;
using System;


namespace FactoryMethod_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>> Welcome To Fitness Club<<<\n");

            Console.WriteLine("> Enter membership option you want to create: ");

            Console.WriteLine("> G - Gym membership");
            Console.WriteLine("> P - Gym + Pool membership");
            Console.WriteLine("> P - Personal Training Gym membership");

            string membershipType = Console.ReadLine();

            MembershipFactory factory = GetFactory(membershipType);

            IMembership membership = factory.GetMembership();

            Console.WriteLine("\n>> Membership Created: \n");
            Console.WriteLine(
                    $"\tname:\t\t{membership.Name}\n" +
                    $"\tDescription:\t{membership.Description}\n" +
                    $"\tPrice:\t\t{membership.GetPrice()}"
                );


            Console.ReadLine();


        }

        private static MembershipFactory GetFactory(string membershipType) => membershipType.ToLower() switch
        {
            "g" => new GymMembershipFactory(100, "Basic Membership"),
            "p" => new GymPoolMembershipFactory(100, "Basic + Pool Membership"),
            "t" => new PersonalGymMembershipFactory(100, "Best Membership"),
            _ => null,
        };



    }
}
