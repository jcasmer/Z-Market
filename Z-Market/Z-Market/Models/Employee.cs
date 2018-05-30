using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string FirstName { get; set; }

        [Display(Name = "Apellido")]
        [Required(ErrorMessage = "Debe ingresar {0}")]
        public string LastName { get; set; }

        [Display(Name = "Salario")]
        [Required(ErrorMessage = "Debe ingresar {0}")]
        public decimal Salary{ get; set; }

        [Display(Name = "Porcentaje Bono")]
        public float BonusPercent { get; set; }

        [Display(Name = "Día de nacimiento")]
        [Required(ErrorMessage = "Debe ingresar {0}")]
        public DateTime DateOfBirth { get; set; }
        [Display(Name = "Hora inicio")]
        public DateTime StartTime { get; set; }
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; }
        [Display(Name = "Url")]
        public string URL { get; set; }

        [Required(ErrorMessage = "Debe ingresar {0}")]
        public int DocumentTypeID { get; set; }

        public virtual DocumentType DocumentType { get; set; } // empleado relacion con tipo de documento
    }
}