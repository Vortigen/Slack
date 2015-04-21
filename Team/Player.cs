using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamDemo
{
    class Player
    {

        #region Private Fields

        private string name;
        private DateTime birthDate;
        private string egn;
        private string birthPlace;
        private byte number;
        private double height;
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

        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }

            private set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("Birth date must be in the past");
                }
                else
                {
                    birthDate = value;
                }

            }
        }

        public string EGN
        {
            get
            {
                return egn;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The EGN is mandatory");
                }
                else
                {
                    egn = value;
                }
            }
        }

        public string BirthPlace
        {
            get
            {
                return birthPlace;
            }

            set
            {
                birthPlace = value;
            }
        }

        public byte Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }

        public decimal Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }


        public void EnterInformation()
        {
            Console.Write("Name: ");
            Name = Console.ReadLine();

            Console.Write("Birth date: ");
            BirthDate = DateTime.Parse(Console.ReadLine());

            Console.Write("EGN: ");
            EGN = Console.ReadLine();

            Console.Write("Birth place: ");
            BirthPlace = Console.ReadLine();

            Console.Write("Number: ");
            Number = byte.Parse(Console.ReadLine());

            Console.Write("Height: ");
            Height = double.Parse(Console.ReadLine());

            Console.Write("Salary: ");
            Salary = decimal.Parse(Console.ReadLine());
        }

        public string GetFormattedInfo()
        {
            return
                "Name: " + Name + Environment.NewLine +
                "Birth date: " + BirthDate + Environment.NewLine +
                "EGN: " + EGN + Environment.NewLine +
                "Birth place: " + BirthPlace + Environment.NewLine +
                "Number: " + Number + Environment.NewLine +
                "Height: " + Height + Environment.NewLine +
                "Salary: " + Salary;
        }
    }
}
