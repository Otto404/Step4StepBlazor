using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebassemblyBlazor.Client.Code
{
   

    public class ExampleModel
    {
        [Required]
        [StringLength(10, ErrorMessage = "Name is too long.")]
        public string Name { get; set; }

        public Gender Gender { get; set; }

        public bool IsMarried { get; set; }
    }
    //Quelle: https://docs.microsoft.com/de-de/aspnet/core/blazor/forms-validation?view=aspnetcore-3.1

}
