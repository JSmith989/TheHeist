using System;
using System.Collections.Generic;

namespace TheHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            // create a list to store team members
            var teamMembers = new List<TeamMember> { };

            bool input = true;
            do
            {
                Console.WriteLine("Type your new team member's name or hit enter when your team is finished:");
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
                // .Add to the teamMembers list
                teamMembers.Add(teamMember);
            } while (input == true);

            // .Count shows number of team members
            Console.WriteLine($"Number of team members: {teamMembers.Count}");

            foreach (var member in teamMembers)
            {
                member.showTeamMember();
            }
        }
    }
}
