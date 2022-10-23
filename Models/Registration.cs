using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace heartyculture_API_Enc.Models
{
    public partial class Registration
    {
        public int Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Useremail { get; set; }
        public string? Password { get; set; }
    }
}
