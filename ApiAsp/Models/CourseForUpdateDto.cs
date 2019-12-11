﻿using ApiAsp.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAsp.Models
{
    public class CourseForUpdateDto : CourseForManipulationDto
    {
        [Required(ErrorMessage = "You Should fill out a description.")]
        public override string Description { get => base.Description; set => base.Description = value; }
    }
}
