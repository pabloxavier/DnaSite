﻿using System.ComponentModel.DataAnnotations;

namespace DNAMais.Domain.Validacao
{
    public class CNPJValidation : ValidationAttribute
    {
        //public string ErrorMessage { get; set; }

        public override bool IsValid(object value)
        {
            return true;
        }
    }
}
