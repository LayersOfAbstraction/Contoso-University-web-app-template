using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Instructor : Person
    {
        //NOTE: We could have done all these attributes on seprate lines. This is another way of doing it.
        [DataType(DataType.Date), Display(Name = "Hire Date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime HireDate { get; set; }
        
        //Navigation properties.
        //One instructor can have many assignments so this property will be a collection.
        public ICollection<CourseAssignment> CourseAssignments { get; set; }
        //One instructor can have one office so this does not need to be a collection.
        public OfficeAssignment OfficeAssignment { get; set; }        
    }
}
