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
            get;
            set;
        }
        
        public int CalenderMonth
        {
            get;
            set;
        }

        public int CalenderDay
        {
            get;
            set;
        }
    }
}
