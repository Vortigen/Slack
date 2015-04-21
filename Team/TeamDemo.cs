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

            Console.WriteLine();

            DisplayTeamInfo(team);

            Console.ReadLine();
        }

        #endregion
        
        #region Private Methods

        public static void EnterTeamInfo(Team team)
        {
            Console.WriteLine("Enter information about the team");

            team.EnterInformation();
        }

        private static void DisplayTeamInfo(Team team)
        {
            Console.WriteLine(team.GetFormattedInfo());
        }

        #endregion
    }
}
