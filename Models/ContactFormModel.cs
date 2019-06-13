using FluentValidation;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace myApp2.Models
{
    public class ContactFormModel
    {
        //Contact Detail Properties  w/validation
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set;}

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Email { get; set; }

        public string Phone { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Message { get; set; }

        
    }

    //FluentValidation from Starup.cs
    public class FormValidator : AbstractValidator<ContactFormModel>
    {
        //FluentValidation Method and Rules
        public FormValidator()
        {

            RuleFor(x => x.Name).Length(0, 25);
            RuleFor(x => x.Email).EmailAddress();
            RuleFor(x => x.Message).Length(0, 200);

        }


    }
}