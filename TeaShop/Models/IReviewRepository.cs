using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeaShop.Models
{
    public interface IReviewRepository
    {
        bool AddReview(TeaReview teaReview);

        bool RemovReview(int teaReviewId);
    }
}
