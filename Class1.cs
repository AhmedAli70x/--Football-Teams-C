using System;
using System.Collections.Generic;
using System.Linq;


namespace Football
{

    public struct Team
    {
        public string TeamName;
        public int NumberOfWins;
        public int NumberOfDraws;
        public int NumberOfLoses;
        public int Points;
    }
     class Class1
    {

        static bool CheckNumber(string data, out int num)
        {
            bool validNumber = int.TryParse(data, out num);
            if (!validNumber)
            {
                Console.WriteLine("Enter a valid number");
                num = 0;
                return false;

            }
            return true;

        }
        static void Main()
        {
            Console.WriteLine("Welcom to Football");

            char loopindex = 'a';

            List<Team> listTeams = new List<Team>();

            while(loopindex != 'e')
            {
                Team myTeam;
                Console.WriteLine("Please Enter Team Name");
                myTeam.TeamName = Console.ReadLine();

                Console.WriteLine("Please Enter number of wins");
                if(!CheckNumber(Console.ReadLine(), out myTeam.NumberOfWins))
                    continue;

                Console.WriteLine("Please Enter number of drwas");
                if (!CheckNumber(Console.ReadLine(), out myTeam.NumberOfDraws))
                    continue;

                Console.WriteLine("Please Enter number of loses");
                if (!CheckNumber(Console.ReadLine(), out myTeam.NumberOfLoses))
                    continue;

                myTeam.Points = (myTeam.NumberOfWins * 3 + myTeam.NumberOfDraws * 1);


                listTeams.Add(myTeam);

                Console.WriteLine("\ne to Exit");
                loopindex = Convert.ToChar(Console.ReadLine());


            }
            int maxPoint = listTeams.Max(x => x.Points);
            Team winner = listTeams.Where(a => a.Points == maxPoint).FirstOrDefault();
            List<Team> listFilterTeam = listTeams.Where(x=>x.Points >20).ToList();

            Console.WriteLine("Winner is : "+ winner.TeamName);

             
        }

    }
}
