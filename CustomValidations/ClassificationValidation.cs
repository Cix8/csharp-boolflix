using System.ComponentModel.DataAnnotations;

namespace csharp_boolflix.CustomValidations
{
    public class ClassificationValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {
            int fieldValue = (int)value;

            if(fieldValue == null || fieldValue < 0)
            {
                return new ValidationResult("L'età della classificazione non può essere negativa");
            }

            return ValidationResult.Success;
        }
    }
}
