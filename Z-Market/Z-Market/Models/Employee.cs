using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Z_Market.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }


        [Display(Name="Nombre")]
        [Required(ErrorMessage="Debe ingresar {0}")]
        [StringLength(50, ErrorMessage = "El campo {0} debe estar entre {2} y {1}", MinimumLength =3)]
        public string FirstName { get; set; }

        [Display(Name = "Apellido")]
        [Required(ErrorMessage = "Debe ingresar {0}")]
        [StringLength(50, ErrorMessage = "El campo {0} debe estar entre {1} y {2}", MinimumLength = 3)]
        public string LastName { get; set; }

        [Display(Name = "Salario")]
        [Required(ErrorMessage = "Debe ingresar {0}")]
        [DisplayFormat(DataFormatString="{0:C2}", ApplyFormatInEditMode=false)]
        public decimal Salary{ get; set; }

        [Display(Name = "Porcentaje Bono")]
        [DisplayFormat(DataFormatString = "{0:P2}", ApplyFormatInEditMode = false)]
        public float BonusPercent { get; set; }

        [Display(Name = "Día de nacimiento")]
        [Required(ErrorMessage = "Debe ingresar {0}")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/mm/dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Hora inicio")]
        [Required(ErrorMessage = "Debe ingresar {0}")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime StartTime { get; set; }


        [Display(Name = "Correo electrónico")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Url")]
        [DataType(DataType.Url)]
        public string URL { get; set; }

        [Required(ErrorMessage = "Debe ingresar {0}")]
        public int DocumentTypeID { get; set; }

        [NotMapped]
        [Display(Name = "Edad")]
        public int Age { get { return DateTime.Now.Year - DateOfBirth.Year; } }

        public virtual DocumentType DocumentType { get; set; } // empleado relacion con tipo de documento
    }
}