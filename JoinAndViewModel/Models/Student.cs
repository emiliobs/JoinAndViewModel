using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JoinAndViewModel.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Stream { get; set; }
    }

    public class StudentAdditionalInfo
    {
        public int InfoId { get; set; }
        public int StudentId { get; set; }
        public string FavourateFruit { get; set; }
        public string Hobby { get; set; }
    }
}