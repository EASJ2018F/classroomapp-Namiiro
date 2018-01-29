using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Students
    {
        private string _name;
        private int _month;
        private int _day;

        public Students(string firstName, int calenderMonth, int calenderDay)
        {
            _name = firstName;
            _month = calenderMonth;
            _day = calenderDay; 
        }

        public string FirstName
        {
            get { return _name; }
           
        }
        
        public int CalenderMonth
        {
            get { return _month; }
            
        }

        public int CalenderDay
        {
            get { return _day; }
            
        }

        public override string ToString()
        {
            return $" {FirstName} born on {CalenderDay} {CalenderMonth}";


        }
        public string BirthSeason()
        {
            if (CalenderMonth == 1 || CalenderMonth == 2 || CalenderMonth == 12)
                return "Winter";


            if (CalenderMonth == 3 || CalenderMonth == 4 || CalenderMonth == 5)
                return "Spring";

            if (CalenderMonth == 6 || CalenderMonth == 7 || CalenderMonth == 8)
                return "Summer";


            if (CalenderMonth == 9 || CalenderMonth == 10 || CalenderMonth == 11)
                return "Autumn";

            return "";
        }

     

        

     
    }
}
