using System;
using System.ComponentModel.DataAnnotations;

namespace FirstTestApp.Models
{
    public class ErrorViewModel
    {
        
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        [Required]
        public int hi { get; set; }
    }
}