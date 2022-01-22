﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheHeist.Models;

namespace TheHeist
{
    internal class HeistSimulator
    {
        public List<TeamMember> TeamMembers = new List<TeamMember>();

        //difficulty - a way of setting it
        private int _bankDifficulty = 100;
        private TeamMemberFactory _teamMemberFactory = new TeamMemberFactory();
        private int _numberOfHeists;

        public void DetermineHeistDifficulty()
        {
            var successfulInput = false;

            while (!successfulInput)
            {
                Console.WriteLine("Enter the difficulty of your bank heist: ");
                var difficulty = Console.ReadLine();
                successfulInput = int.TryParse(difficulty, out _bankDifficulty);
            }
        }

        public void CreateTeam()
        {
            var buildingTeam = true;

            while (buildingTeam)
            {
                var newTeamMember = _teamMemberFactory.BuildNewTeamMember();
                if (newTeamMember.Name != "")
                {
                    TeamMembers.Add(newTeamMember);
                }
                else
                {
                    buildingTeam = false;
                }
            }
        }

        public void DetermineNumberOfTests() //Abstraction - hiding a complicated process behind a simple facade
        {
            //Determine number of heists
            var successfulInput = false;
            while (!successfulInput)
            {
                Console.WriteLine("How many heist simulations do you want to run?");
                var numberOfHeists = Console.ReadLine();
                successfulInput = int.TryParse(numberOfHeists, out _numberOfHeists);

            }
        }

        internal void ShowResults()
        {
            var successCount = 0;
            var failureCount = 0;

            for (int i = 0; i < _numberOfHeists; i++)
            {
                var luck = new Random().Next(-10, 10);
                var sum = 0;

                foreach (var member in TeamMembers)
                {
                    sum += member.SkillLevel;
                }

                var modifiedDifficulty = _bankDifficulty + luck;
                var heistResult = sum >= modifiedDifficulty;
                if (heistResult)
                {
                    successCount += 1;
                }
                else
                {
                    failureCount++;
                }
                //Console.WriteLine($"Your skill level is {sum} and the difficulty is {modifiedDifficulty}.");
                //Console.WriteLine($"The heist was a {(heistResult ? "success" : "failure")}!");
            }

            foreach (TeamMember member in TeamMembers)
            {
                Console.WriteLine(member);
            }
            Console.WriteLine($"There were {successCount} successful heists and {failureCount} failures.");
        }
    }
}
