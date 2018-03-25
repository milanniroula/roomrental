using api.roomrental.Entities;
using api.roomrental.models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.roomrental.Helpers
{
    public sealed class UniqueEmail : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {



            }
            return ValidationResult.Success;
        }

    }
}
