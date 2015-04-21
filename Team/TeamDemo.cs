using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamDemo
{
    class Program
    {
        #region Public Methods

        static void Main(string[] args)
        {

            var team = new Team();

            EnterTeamInfo(team);

            DisplayTeamInfo(team);

            Console.ReadLine();
        }

        #endregion
        
        #region Private Methods

        public static void EnterTeamInfo(Team team)
        {
            Console.WriteLine("Enter information about team");
            Team newTeam = new Team();
            newTeam.EnterInformation();
        }

        private static void DisplayTeamInfo(Team team)
        {
            Console.WriteLine(team.GetFormattedInfo());
        }

        #endregion
    }
}
