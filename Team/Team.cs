using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team
{
    class Team
    {

        #region Private Fields

        private string name;
        private DateTime yearOfCreation;
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

        public DateTime YearOfCreation
        {
            get
            {
                return yearOfCreation;
            }

            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("Year of creation must be in the past");
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
                Stadium = value;
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

        private string name;
        private DateTime yearOfCreation;
        private string stadium;
        private string owner;
        private string headCoach;
        private string webSite;


        public void EnterInformation()
        {
            Console.Write("Name: ");
            Name = Console.ReadLine();
            
            Console.Write("Year of creation: ");
            YearOfCreation = DateTime.Parse(Console.ReadLine());
            
            Console.Write("Stadion: ");
            Stadium = Console.ReadLine();
            
            Console.Write("Owner: ");
            Owner = decimal.Parse(Console.ReadLine());
            
            Console.Write("Head Coach: ");
            HeadCoach = Console.ReadLine();

            Console.Write("Web Site: ");
            webSite = Console.ReadLine();
        }

        public string GetFormattedInfo()
        {
            return Brand + " (" + Model + ") - " +
                    Mileage + " (" + Price + ") " +
                    Color;
        }

        public override string ToString()
        {
            return GetFormattedInfo();
        }
    }
}
