using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeaShop.ViewModels
{
    public class AddReviewViewModel
    {
        [Required]
        [Display(Name = "Review Title")]
        public string ReviewTitle { get; set; }

        [Required]
        [Display(Name = "Review Description")]
        public string ReviewText { get; set; }

        [Required]
        [Display(Name = "Star Rating")]
        public int Rating { get; set; }

        public int TeaReviewId { get; set; }

        public int TeaId { get; set; }

        public string ReviewedBy { get; set; }

        public DateTime ReviewedOn { get; set; }

    
}
}
