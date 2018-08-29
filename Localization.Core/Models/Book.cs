using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Westwind.Utilities.Properties;

namespace Localization.Core.Models
{
    public class Book
    {
        public int BookId { get; set; }
        [Required(ErrorMessage = "ErrorMail")]
        public string Title { get; set; }
    }
}
