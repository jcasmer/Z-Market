﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Z_Market.Models
{
    public class DocumentType
    {
        [Key]
        [Display(Name = "Tipo Documento")]
        public int DocumentTypeID { get; set; }
        [Display(Name = "Tipo Documento")]
        public string Description { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}