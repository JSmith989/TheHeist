using System;
using System.Collections.Generic;

namespace TheHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist! Enter the bank difficulty number:");
            // create a list to store team members
            var teamMembers = new List<TeamMember> { };
            int bankDifficulty = int.Parse(Console.ReadLine());
            int skill = 0;
            var newBank = new Bank(bankDifficulty);
            int success = 0;
            int fail = 0;

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
                Console.WriteLine("Type your new team member's skill level from 0 - 100");
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
            Console.WriteLine("Please enter your trial runs:");

            //takes number of trial runs
            var trialRuns = int.Parse(Console.ReadLine());

            foreach (var member in teamMembers)
            {
                skill += member.SkillLevel;
            };
            //for each trialRun number, do this loop
            for(var i = 0; i < trialRuns; i++)
            {
                newBank.LadyLuck();
                int breakInDifficulty = newBank.Difficulty + newBank.Luck;

                Console.WriteLine($"Total team skill: {skill}");
                Console.WriteLine($"Total bank difficulty: {breakInDifficulty}");


                if (skill >= breakInDifficulty)
                {
                    Console.WriteLine("Success!");
                    success++;
                }
                else
                {
                    Console.WriteLine("Your heist did not work");
                    fail++;
                }
            }
            Console.WriteLine($"Successful runs: {success}. Failed Runs: {fail}.");
            
        }
    }
}
