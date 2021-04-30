using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingCGI1.Pages.modul5
{
    public class CSSFormClassProvider : FieldCssClassProvider
    {
        public override string GetFieldCssClass(EditContext editContext, in FieldIdentifier fieldIdentifier)
        {
            var IsValid = !editContext.GetValidationMessages(fieldIdentifier).Any();
            return IsValid ? "is-valid" : "is-invalid";
        
        }
    }
}
