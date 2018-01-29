﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)

        {
            List<Students> studentsList = new List<Students>();

            studentsList.Add(new Students("Kevin Jensen", 6, 9));
            studentsList.Add(new Students("Gordon Mikkelsen", 7, 6));
            studentsList.Add(new Students("Jackie Rose", 5, 21));


            KlasseRum Klasse = new KlasseRum("3A", studentsList, new DateTime(2017, 8, 28) );

            Console.WriteLine(Klasse.KlasseNavn);
            Console.WriteLine(Klasse.SemesterStart);

            foreach (var student in Klasse.KlasseListe)
            {
                Console.WriteLine(student);
            }

            Klasse.BirthSeason();

            Console.ReadKey();


        }
    }
}
