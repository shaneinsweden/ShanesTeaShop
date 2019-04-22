using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeaShop.Models
{
    public class TeaReview
    {
        public int TeaReviewId { get; set; }
  
        public int TeaId { get; set; }

        public string ReviewedBy { get; set; }

        public DateTime ReviewedOn { get; set; }

        public string ReviewTitle { get; set; }

        public string ReviewText { get; set; }

        public int Rating { get; set; }
    }
}
