using System;

namespace TheHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            bool input = true;
            do
            {
                Console.WriteLine("Type your new team member's name:");
                var memberName = Console.ReadLine();
                if(memberName == "")
                {
                    input = false;
                    continue;
                }
                Console.WriteLine("Type your new team member's skill level from 0 - 10");
                var memberSkill = Console.ReadLine();
                var skillNumber = int.Parse(memberSkill);
                Console.WriteLine("Type your new team member's courage from 0.0 - 2.0");
                var memberCourage = Console.ReadLine();
                var courageDecimal = double.Parse(memberCourage);

                var teamMember = new TeamMember(memberName, skillNumber, courageDecimal);
                teamMember.showTeamMember();
            } while (input == true);
        }
    }
}
