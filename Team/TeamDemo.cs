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

           //Team
           Team team = new Team();            
           EnterTeamInfo(team);
           DisplayTeamInfo(team);

            //Players
            int playersCount = ReadPlayersCount();
            var players = new Player[playersCount];
            EnterPlayersInfo(players);
            DisplayPlayersInfo(players);

            Console.ReadLine();
        }

        #endregion
        
        #region Private Methods

        private static int ReadPlayersCount()
        {
            Console.WriteLine();
            Console.Write("Enter amount of players: ");
            return int.Parse(Console.ReadLine());
        }

        public static void EnterTeamInfo(Team team)
        {
            Console.WriteLine("Enter information about the team");

            team.EnterInformation();
        }

        private static void DisplayTeamInfo(Team team)
        {
            Console.WriteLine();
            Console.WriteLine(team.GetFormattedInfo());
        }

        public static void EnterPlayersInfo(IList<Player> players)
        {
            for (int playerIndex = 0; playerIndex < players.Count; playerIndex++)
            {
                Console.WriteLine("Enter player infomation " + (playerIndex + 1));
                Player newPlayer = new Player();
                newPlayer.EnterInformation();

                players[playerIndex] = newPlayer;
                Console.WriteLine();
            }
        }

        private static void DisplayPlayersInfo(IList<Player> players)
        {
            foreach (Player player in players)
            {
                Console.WriteLine(player.GetFormattedInfo());
            }
            Console.WriteLine();
        }

        #endregion
    }
}
