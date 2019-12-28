using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        //Specifies a data type that's more specific than the database intrinsic type.
        //It can enable type specific features, for example a datetime picker
        //or for EmailAddress we can use a mailto: link.
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; } 

        //This is a navigation property. It holds other entities that are related to the entity that
        //owns this property. This property holds all of the Enrollment entities related to the Student. 
        //So if the Student row in the DB has two related Enrollment rows, the property contains those same
        //two Enrollment entities. Don't forget EF Entities are table rows aned EF Entity Sets are tables.
        //By default EF Core creates a HashSet<Enrolment> for this prop by default.
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
