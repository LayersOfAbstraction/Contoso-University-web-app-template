using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string LastName { get; set; }
        [StringLength(50)]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }
        //Specifies a data type that's more specific than the database intrinsic type.
        //It can enable type specific features, for example a datetime picker
        //or for EmailAddress we can use a mailto: link.
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; } 
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }

        //This is a navigation property. It holds other entities that are related to the entity that
        //owns this property. This property holds all of the Enrollment entities related to the Student. 
        //So if the Student row in the DB has two related Enrollment rows, the property contains those same
        //two Enrollment entities. Don't forget EF Entities are table rows aned EF Entity Sets are tables.
        //By default EF Core creates a HashSet<Enrolment> for this prop by default.
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
