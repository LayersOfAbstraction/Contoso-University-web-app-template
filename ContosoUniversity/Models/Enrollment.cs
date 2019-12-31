using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        //If the value is null then the output is similar to a default constraint.
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade {get;set;}
        
        public Course Course { get; set; }
        public Student Students { get; set; }
    }
}
