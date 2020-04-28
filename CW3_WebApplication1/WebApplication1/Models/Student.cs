using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Student
    {
        public string IndexNumber { get; set; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string Studies { get; set; }

        internal DateTime getStartDate()
        {
            throw new NotImplementedException();
        }

        internal int getSemester()
        {
            throw new NotImplementedException();
        }
    }
}
