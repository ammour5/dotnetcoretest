using System;
using System.ComponentModel.DataAnnotations;

namespace backend.Data.Models
{
    public class CredentialModel
    {
        public CredentialModel() 
        { 
        }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
