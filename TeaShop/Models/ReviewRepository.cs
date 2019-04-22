using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeaShop.Models
{
    public class ReviewRepository: IReviewRepository
    {
        private readonly AppDbContext _appDbContext;

        public ReviewRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public bool AddReview(TeaReview teaReview)
        {
            try
            {
                _appDbContext.TeaReviews.Add(teaReview);
                _appDbContext.SaveChanges();
                return true;
            }
            catch (Exception err)
            {
                return false;
            }
            
        }

        public bool RemovReview(int teaReviewId)
        {
            try
            {
                TeaReview review = _appDbContext.TeaReviews.FirstOrDefault(t => t.TeaReviewId == teaReviewId);
                if (review != null)
                {
                    _appDbContext.TeaReviews.Remove(review);
                    _appDbContext.SaveChanges();
                    return true;
                }
               
                return false;
            }
            catch (Exception err)
            {
                return false;
            }

           

       
        }

    }
}
