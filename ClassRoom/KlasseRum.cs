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
    }
}
