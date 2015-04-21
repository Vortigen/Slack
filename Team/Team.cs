using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamDemo
{
    class Team
    {

        #region Private Fields

        private string name;
        private int yearOfCreation;
        private string stadium;
        private string owner;
        private string headCoach;
        private string webSite;

        #endregion

        public string Name
        {
            get 
            { 
                return name; 
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name is mandatory");
                }
                else
                {
                    name = value;
                }
            }
        }

        public int YearOfCreation
        {
            get
            {
                return yearOfCreation;
            }

            set
            {
                yearOfCreation = value;
            }
        }

        public string Stadium
        {
            get
            {
                return stadium;
            }
            set
            {
                stadium = value;
            }
        }

        public string Owner
        {
            get
            {
                return owner;
            }
            set
            {
                owner = value;
            }
        }

        public string HeadCoach
        {
            get
            {
                return headCoach;
            }
            set
            {
                headCoach = value;
            }
        }

        public string WebSite
        {
            get
            {
                return webSite;
            }
            set
            {
                webSite = value;
            }
        }

        public void EnterInformation()
        {
            Console.Write("Name: ");
            Name = Console.ReadLine();
            
            Console.Write("Year of creation: ");
            YearOfCreation = int.Parse(Console.ReadLine());
            
            Console.Write("Stadium: ");
            Stadium = Console.ReadLine();
            
            Console.Write("Owner: ");
            Owner = Console.ReadLine();
            
            Console.Write("Head Coach: ");
            HeadCoach = Console.ReadLine();

            Console.Write("Web Site: ");
            WebSite = Console.ReadLine();
        }

        public string GetFormattedInfo()
        {
            return
                "Team Name: " + Name +
                " Year of Creation: " + YearOfCreation +
                " Stadium: " + Stadium +
                " Owner: " + Owner +
                " Head Coach: " + HeadCoach +
                " Web Site" + WebSite;
        }

        public override string ToString()
        {
            return GetFormattedInfo();
        }
    }
}
