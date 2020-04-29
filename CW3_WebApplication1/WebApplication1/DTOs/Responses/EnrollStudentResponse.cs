using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.DTOs.Responses
{
    public class EnrollStudentResponse
    {
        private int status;
        private string message = "";
        public string LastName { get; set; }
        public int Semester { get; set; }
        public string StartDate { get; set; }
        public string Studies { get; set; }

        public void setStatus(int v, string m)
        {
           this.status = v;
           this.message = m;
        }

        public int getStatus()
        {
           return status;
        }

        public string getMessage()
        {
           return message;
        }
    }
}
