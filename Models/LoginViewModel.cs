using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
namespace EXAMMidTerm.Models{
    public class LoginViewModel{
        [Required(ErrorMessage = "Please enter your email/username.")]
        [EmailAddress(ErrorMessage = "Please enter a proper email.")]
        /* This should work but its not, I don't remember when we did this so I don't know how to make it work.
         The internet sources for help are basically useless and give no content with their code examples.
         Everything else was pretty simple to figure out but I spent 8 hours trying to make this work.
         I don't understand custom validation... so I just used teh built in [EmailAdress] as seen above.

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext){
            if (userName.Contains("@") && userName.Contains(".") && userName[userName.Length]
             != '@' && userName[userName.Length] != '.' && userName[0] != '@' && userName[0] != '.'){
                yield return new ValidationResult("Invalid Username, must be a email.",new[] { "userName" });
    }
} */
        public string userName{get; set;}
        [Required(ErrorMessage = "Please enter your password.")]
        [MinLength(8, ErrorMessage = "Your password must be 8 characters.")]
        //I also can not figure out how to require upper and lower case characters using validators.
        public string password{get; set;}
    }
}