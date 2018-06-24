using System;
using System.ComponentModel.DataAnnotations;

namespace AutomaticModelStateValidation.Sample.Models
{
    public class ViewSubmissionViewModel
    {
        public int Id { get; set; }
    }

    public class SaveSubmissionViewModel
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }
    }

    public class NewSubmissionViewModel
    {
        public string Name { get; set; }
    }
}
