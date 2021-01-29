using System;
using System.Collections.Generic;
using System.Text;

namespace TheHeist
{
    class TeamMember
    {
        public string Name { get; set;}
        public int SkillLevel { get; set; }
        public double Courage { get; set; }

        public TeamMember(string name, int skillLevel, double courage)
        {
            Name = name;
            SkillLevel = skillLevel;
            Courage = courage;
        }

        public void showTeamMember()
        {
            Console.WriteLine($"Name: {Name}, Skill Level: {SkillLevel} out of 10, Courage: {Courage} out of 5.0");
        }
    }
}
