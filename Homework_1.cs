using System;
using System.Collections.Generic;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            PreparePersonListWhenProgramIsLoad();
            ReturnMenu();
        }
        static void InputtoData()
        {
            string name;
            string address;
            string identityid;
            string number;
            string activity;
            Console.Write("Name:");
            name = Console.ReadLine();
            Console.Write("Address:");
            address = Console.ReadLine();
            Console.Write("Identity ID:");
            identityid = Console.ReadLine();
            Console.Write("Phone number:");
            number = Console.ReadLine();
            Console.Write("Select Activity:");
            activity = Console.ReadLine();
            CheckActivity(activity);

            GetData data = new GetData(name, address, identityid, number, activity);
            Program.GetAddlist.InputToData(data);
            ReturnMenu();
        }
        static public void PreparePersonListWhenProgramIsLoad()
        {
            Program.GetAddlist = new AddlistData();
        }
        static public AddlistData GetAddlist;

        static void ReturnMenu()
        {
            Console.Clear();
            int SelectMenu;
            Console.WriteLine("Welcome to Student activity registration system.");
            Console.WriteLine("-------------------------------------------------------");
            Activity();
            Console.WriteLine("1. Register new student Activity.");
            Console.WriteLine("2. Register new Lecturer Activity.");
            Console.WriteLine("3. Show To Data.");
            Console.Write("Please Select Menu :");

            for (SelectMenu = 0; SelectMenu <= 2; SelectMenu++)
            {
                int.TryParse(Console.ReadLine(), out SelectMenu);

                if (SelectMenu == 1)
                {
                    Console.WriteLine("Register Student.");
                    Console.WriteLine("----------------------");
                    InputtoData();
                }

                else if (SelectMenu == 2)
                {
                    Console.WriteLine("Register Lecturer.");
                    Console.WriteLine("----------------------");
                    InputtoData();
                }

                else if (SelectMenu == 3)
                {
                    Console.WriteLine("Show To Data.");
                    Console.WriteLine("----------------------");
                    Program.GetAddlist.Showdata();
                    returntoMenu();

                }

                else if (SelectMenu > 3)
                {
                    Console.WriteLine("Invalid Menu");
                    returntoMenu();
                }
            }
        }
        static void Activity()
        {
            Console.WriteLine("Activity");
            Console.WriteLine("------------------------");
            Console.WriteLine("1.Town Hall");
            Console.WriteLine("2.INNOVATION");
            Console.WriteLine("3.CORPORATE");
            Console.WriteLine("4.ART");
            Console.WriteLine("5.MAIN");
            Console.WriteLine("------------------------");
        }
        static void CheckActivity(string activity)
        {

            if (activity != "Town Hall" && activity != "INNOVATION" && activity != "CORPORATE" && activity != "ART" && activity != "MAIN")
            {
                Console.WriteLine("No Activity!!!");
                InputtoData();
            }
        }
        static void returntoMenu()
        {

            string select;
            Console.WriteLine("ReturntoMenu--- yes OR no");
            select = Console.ReadLine();
            if (select == "yes")
            {
                ReturnMenu();
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("EXIT....");

            }

        }
    }

    class GetData
    {
        public string name;
        public string address;
        public string identity;
        public string Phonenumber;
        public string activity;
        public GetData(string valuename, string valueaddress, string valueIdentity, string valuePhonenumber, string valueactivity)
        {
            name = valuename;
            address = valueaddress;
            identity = valueIdentity;
            Phonenumber = valuePhonenumber;
            activity = valueactivity;
        }
    }
    class AddlistData
    {

        public List<GetData> Addlist;
        public AddlistData()
        {
            Addlist = new List<GetData>();
        }
        public void InputToData(GetData getData)
        {
            Addlist.Add(getData);
        }
        public void Showdata()
        {

            foreach (GetData show in Addlist)
            {

                Console.WriteLine("Name:" + show.name);
                Console.WriteLine("Address:" + show.address);
                Console.WriteLine("Identity:" + show.identity);
                Console.WriteLine("Phone number:" + show.Phonenumber);
                Console.WriteLine("Activity:" + show.activity);
            }
        }


    }

}