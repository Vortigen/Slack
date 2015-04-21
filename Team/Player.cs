using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayerDemo
{
    class Player
    {

        #region Private Fields

        private string name;
        private DateTime birthDate;
        private string egn;
        private string birthPlace;
        private string number;
        private string height;
        private decimal salary;

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

            Console.Write("Head coach: ");
            HeadCoach = Console.ReadLine();

            Console.Write("Web site: ");
            WebSite = Console.ReadLine();
        }

        public string GetFormattedInfo()
        {
            return
                "Name: " + Name + Environment.NewLine +
                "Year of creation: " + YearOfCreation.ToString() + Environment.NewLine +
                "Stadium: " + Stadium + Environment.NewLine +
                "Owner: " + Owner + Environment.NewLine +
                "Head coach: " + HeadCoach + Environment.NewLine +
                "Web site: " + WebSite;
        }
    }
}
