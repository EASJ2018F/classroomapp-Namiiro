using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class KlasseRum
    {
        private string _klasseNavn;
        private List<Students> _studentListe;
        private DateTime _semesterStart; 

        public KlasseRum(string klasseNavn, List<Students> studentListe, DateTime semesterStart)
        {
            _klasseNavn = klasseNavn;
            _studentListe = studentListe;
            _semesterStart = semesterStart;
        }
        public string KlasseNavn
        {
            get { return _klasseNavn; }

        }

        public List<Students> KlasseListe
        {
            get { return _studentListe; }
            
        }

        public DateTime SemesterStart
        {
            get { return _semesterStart; }
           
        }

        public void BirthSeason()
        {
            int winter = 0;
            int spring = 0;
            int summer = 0;
            int autumn = 0;

            foreach (var student in KlasseListe)
            {
                if(student.BirthSeason() == "winter")
                {
                    winter += 1;
                }
                if(student.BirthSeason() == "spring")
                {
                    spring += 1;
                }
                if(student.BirthSeason() == "summer")
                {
                    summer += 1;
                }
                if (student.BirthSeason() == "autumn")
                {
                    autumn += 1;
                }
            }

            Console.WriteLine($"Born in winter: {winter}");
            Console.WriteLine($"Born in spring: {spring}");
            Console.WriteLine($"Born in summer: {summer}");
            Console.WriteLine($"Born in autumn: {autumn}");


        }
    }
}
