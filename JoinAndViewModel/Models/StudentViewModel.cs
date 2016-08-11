using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JoinAndViewModel.Models
{
    public class StudentViewModel
    {
        public Student StudentVM { get; set; }
        public StudentAdditionalInfo StudentAdditionalInfoVM { get; set; }
    }
}