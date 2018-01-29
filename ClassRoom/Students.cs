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
    }
}
