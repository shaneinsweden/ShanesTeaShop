using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeaShop.Models
{
    public class MockTeaRepository : ITeaRepository
    {
        private readonly ICategoryRepository categoryRepoistory = new MockCategoryRepository();

        public IEnumerable<Tea> Teas
        {
            get
            {
                return new List<Tea>
                {
                    new Tea{
                        TeaId =1,
                        //Id = new Guid("CCD73059-E44B-4C81-97FE-8AD8C4DBDE6D"),
                        Name = "Best Earl Grey",
                        LongDescription ="A stunning version of this classic Tea. Well-rounded flavour with distinct citrus notes.",
                        ShortDescription = "Well-rounded flavour with distinct citrus notes.",
                        Price= 4,
                        InStock=true,
                        CategoryId=4,
                        InTeaBags=false,
                        ImageThumbnailUrl = "/Images/EarlGrey.jpg"
                        },
                    new Tea{
                        TeaId =2,
                        //Id = new Guid("7DEAA67A-A4DD-48E8-B540-18D97E16820D"),
                        Name = "English Breakfast",
                        LongDescription ="This English Breakfast Tea offers a delicate balance of strength and flavour for a delightful start to the day.",
                        ShortDescription = "Delicate balance of strength and flavour.",
                        Price= 4,
                        InStock=true,
                        CategoryId=4,
                        InTeaBags=false,
                        },
                    new Tea{
                        TeaId =3,
                        //Id = new Guid("3931EC83-2A38-4D8D-97BC-3F88E6372B99"),
                        Name = "Jasmine Green Tea No.7 ",
                        LongDescription ="Our luxury brand Jasmine Chinese green tea, infused with oils of jasmine, imparts a refreshing flavour.",
                        ShortDescription = "Refreshing flavour.",
                        Price= 3.5M,
                        InStock=true,
                        CategoryId=2,
                        InTeaBags=false,
                        },
                    new Tea{
                        TeaId =4,
                        //Id = new Guid("671D5146-B6E4-4D34-82F0-38599B3E7B10"),
                        Name = "Organic Japanese Matcha",
                        LongDescription ="A great choice for anyone new to matcha. Imparts a smooth, mellow flavour with hints of grassy sweetness.",
                        ShortDescription = "Mellow flavour with hints of grassy sweetness",
                        Price= 11.01M,
                        InStock=true,
                        CategoryId=2,
                        InTeaBags=false,
                        },
                    new Tea{
                        TeaId =5,
                        //Id = new Guid("44DE6C9A-05F1-4E6E-9F71-085CB32CEFCF"),
                        Name = "Chinese Jade Ginseng Oolong No.66",
                        LongDescription ="This unique Oolong tea is full of flavour and offers a wide variety of health benefits.",
                        ShortDescription = "Full flavoured.",
                        Price= 6.5M,
                        InStock=true,
                        CategoryId=3,
                        InTeaBags=false,
                        },
                    new Tea{
                        TeaId =6,
                        //Id = new Guid("DD528ADC-BDB8-47E7-B048-337A91D3B82A"),
                        Name = "Milk Oolong Triune",
                        LongDescription ="Our award-winning Milk Oolong teabags provide a soft, creamy flavour with natural sweetness.",
                        ShortDescription = "Soft, creamy flavoured.",
                        Price= 9.95M,
                        InStock=true,
                        CategoryId=3,
                        InTeaBags=true,
                        },
                    new Tea{
                        TeaId =6,
                        //Id = new Guid("D44AC809-9720-437D-9B17-7D29A69CF413"),
                        Name = "Monkey Picked Tie Guan Yin - Limited Edition - No.41",
                        LongDescription ="Handmade by Artisan teamakers, this limited-edition Tue Guan Yin is the finest of our Oolong teas.",
                        ShortDescription = "Limited edition.",
                        Price= 15.26M,
                        InStock=true,
                        CategoryId=3,
                        InTeaBags=false,
                        },
                    new Tea{
                        TeaId =8,
                        //Id = new Guid("B1289505-113B-481F-B151-A8727429A1AD"),
                        Name = "Yunnan Pu Erh - No.37",
                        LongDescription ="Aged for 27 years, this Pu'erh tea from the Yunnan Province imparts a mature and smooth flavour.",
                        ShortDescription = "Mature and smooth flavour",
                        Price= 15.26M,
                        InStock=true,
                        CategoryId=5,
                        InTeaBags=false,
                        },
                    new Tea{
                        TeaId =9,
                        //Id = new Guid("B817ED42-A9AF-43AB-BD46-F87A6FC18352"),
                        Name = "Sencha Goji-Berry Pomegranate Blend - No.11",
                        LongDescription ="Bursting with high levels of healthy antioxidants and rich in vitamins.",
                        ShortDescription = "Rich in vitamins.",
                        Price= 5.5M,
                        InStock=true,
                        CategoryId=6,
                        InTeaBags=false,
                        },
                    new Tea{
                        TeaId =10,
                        //Id = new Guid("C2376498-B6AE-4760-AFF5-938A2E2D6BE5"),
                        Name = "Chamomile Blossoms - No.121",
                        LongDescription ="Revered for its outstanding health benefits, our chamomile tea offers an apple-like floral taste.",
                        ShortDescription = "Floral taste.",
                        Price= 4.2M,
                        InStock=true,
                        CategoryId=7,
                        InTeaBags=false,
                        },
                    new Tea{
                        TeaId =11,
                        //Id = new Guid("673DA626-555A-4150-BFFA-C8D84ADF3E39"),
                        Name = "Vanilla Organic Rooibos - No.101",
                        LongDescription ="A healthy Organic Rooibos, this tea offers a rich, full-bodied infusion with tangy and sweet notes.",
                        ShortDescription = "Rich and full-bodied.",
                        Price= 6.72M,
                        InStock=true,
                        CategoryId=8,
                        InTeaBags=false,
                        },
                };
            }
        }

        public IEnumerable<Tea> TeasOfTheWeek => throw new NotImplementedException();

        public IEnumerable<Tea> FindTeas(string searchString)
        {
            throw new NotImplementedException();
        }

        public Tea GetTeaById(int teaId)
        {
            throw new NotImplementedException();
        }
    }
}

