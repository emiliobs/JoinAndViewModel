using JoinAndViewModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JoinAndViewModel.Controllers
{
    public class HomeController : Controller
    {
        List<Student> students = new List<Student>();
        List<StudentAdditionalInfo> StudentAdditionalInfos = new List<StudentAdditionalInfo>();

        // GET: Home
        public ActionResult Index()
        {
            InsertDummyData();

            var studentViewModel = from s in students
                                   join st in StudentAdditionalInfos on s.StudentId equals st.StudentId
                                   into st2
                                   from st in st2.DefaultIfEmpty()
                                   select new StudentViewModel
                                   {
                                       StudentVM = s,
                                       StudentAdditionalInfoVM = st
                                   };

            return View(studentViewModel);
        }

        private void InsertDummyData()
        {
            students.Add(new Student { StudentId = 1, Name= "Max",   Stream = "Computer science"});
            students.Add(new Student { StudentId = 2, Name = "Tony", Stream = "Life Sciences" });
            students.Add(new Student { StudentId = 3, Name = "Jhon", Stream = "Robotics" });
            students.Add(new Student { StudentId = 4, Name = "Jack", Stream = "Computer Science" });
            students.Add(new Student { StudentId = 5, Name = "Dominic", Stream = "Avaiation" });

            StudentAdditionalInfos.Add(new StudentAdditionalInfo { InfoId = 100, StudentId = 1, FavourateFruit ="Apple", Hobby="Driving" });
            StudentAdditionalInfos.Add(new StudentAdditionalInfo { InfoId = 101, StudentId = 2, FavourateFruit = "Mango", Hobby = "Hunting" });
            StudentAdditionalInfos.Add(new StudentAdditionalInfo { InfoId = 102, StudentId = 3, FavourateFruit = "Bannana", Hobby = "Fishing" });
            StudentAdditionalInfos.Add(new StudentAdditionalInfo { InfoId = 103, StudentId = 4, FavourateFruit = "Pine Apple", Hobby = "Sailing" });
            StudentAdditionalInfos.Add(new StudentAdditionalInfo { InfoId = 104, StudentId = 5, FavourateFruit = "Grapes", Hobby = "Street Racing" });


        }
    }
}