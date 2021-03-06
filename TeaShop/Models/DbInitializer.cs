﻿using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeaShop.Models
{
    public class DbInitializer
    {
        //public static void Seed(IApplicationBuilder applicationBuilder)
        public static void Seed(AppDbContext context)
        {

            using (var transaction = context.Database.BeginTransaction())
            {
                if (!context.Categories.Any())
                {
                    context.Categories.AddRange(Categories.Select(c => c.Value));
                }

                context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Categories ON");
                context.SaveChanges();
                context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Categories OFF");

                if (!context.Teas.Any())
                {
                    context.AddRange
                    (
                        new Tea
                        {
                            TeaId = 1,
                        //Id = new Guid("CCD73059-E44B-4C81-97FE-8AD8C4DBDE6D"),
                        Name = "Best Earl Grey",
                            LongDescription = "A stunning version of this classic Tea. Well-rounded flavour with distinct citrus notes.",
                            ShortDescription = "Well-rounded flavour with distinct citrus notes.",
                            Price = 3.4M,
                            InStock = true,
                            CategoryId = 4,
                            InTeaBags = false,
                            IsTeaOfTheWeek = true,
                            ImageThumbnailUrl = "/Images/EarlGrey-sm.jpg",
                            ImageUrl = "/Images/EarlGrey.jpg"
                        },
                        new Tea
                        {
                            TeaId = 2,
                        //Id = new Guid("7DEAA67A-A4DD-48E8-B540-18D97E16820D"),
                        Name = "English Breakfast",
                            LongDescription = "This English Breakfast Tea offers a delicate balance of strength and flavour for a delightful start to the day.",
                            ShortDescription = "Delicate balance of strength and flavour.",
                            Price = 5.1M,
                            InStock = true,
                            CategoryId = 4,
                            InTeaBags = false,
                            ImageThumbnailUrl = "/Images/English-Breakfast-sm.jpg",
                            ImageUrl = "/Images/English-Breakfast.jpg"
                        },
                        new Tea
                        {
                            TeaId = 3,
                        //Id = new Guid("3931EC83-2A38-4D8D-97BC-3F88E6372B99"),
                        Name = "Jasmine Green Tea No.7 ",
                            LongDescription = "Our luxury brand Jasmine Chinese green tea, infused with oils of jasmine, imparts a refreshing flavour.",
                            ShortDescription = "Refreshing flavour.",
                            Price = 3.5M,
                            InStock = true,
                            CategoryId = 2,
                            InTeaBags = false,
                            IsTeaOfTheWeek = true,
                            ImageThumbnailUrl = "/Images/jasmine-green-tea-sm.jpg",
                            ImageUrl = "/Images/jasmine-green-tea.jpg"
                        },
                        new Tea
                        {
                            TeaId = 4,
                        //Id = new Guid("671D5146-B6E4-4D34-82F0-38599B3E7B10"),
                        Name = "Organic Japanese Matcha",
                            LongDescription = "A great choice for anyone new to matcha. Imparts a smooth, mellow flavour with hints of grassy sweetness.",
                            ShortDescription = "Mellow flavour with hints of grassy sweetness",
                            Price = 11.01M,
                            InStock = true,
                            CategoryId = 2,
                            InTeaBags = false,
                            ImageThumbnailUrl = "/Images/organicmatcha-sm.jpg",
                            ImageUrl = "/Images/organicmatcha.jpg"
                        },
                        new Tea
                        {
                            TeaId = 5,
                        //Id = new Guid("44DE6C9A-05F1-4E6E-9F71-085CB32CEFCF"),
                        Name = "Chinese Jade Ginseng Oolong No.66",
                            LongDescription = "This unique Oolong tea is full of flavour and offers a wide variety of health benefits.",
                            ShortDescription = "Full flavoured.",
                            Price = 6.5M,
                            InStock = true,
                            CategoryId = 3,
                            InTeaBags = false,
                            ImageThumbnailUrl = "/Images/Chinese-Jade-Jingseng-sm.jpg",
                            ImageUrl = "/Images/hinese-Jade-Jingseng.jpg"
                        },
                        new Tea
                        {
                            TeaId = 6,
                        //Id = new Guid("DD528ADC-BDB8-47E7-B048-337A91D3B82A"),
                        Name = "Milk Oolong Triune",
                            LongDescription = "Our award-winning Milk Oolong teabags provide a soft, creamy flavour with natural sweetness.",
                            ShortDescription = "Soft, creamy flavoured.",
                            Price = 9.95M,
                            InStock = true,
                            CategoryId = 3,
                            InTeaBags = true,
                            IsTeaOfTheWeek = true,
                            ImageThumbnailUrl = "/Images/taiwanese-ginseng-oolong-sm.jpg",
                            ImageUrl = "/Images/taiwanese-ginseng-oolong.jpg"
                        },
                        new Tea
                        {
                            TeaId = 7,
                        //Id = new Guid("D44AC809-9720-437D-9B17-7D29A69CF413"),
                        Name = "Monkey Picked Tie Guan Yin - Limited Edition - No.41",
                            LongDescription = "Handmade by Artisan teamakers, this limited-edition Tue Guan Yin is the finest of our Oolong teas.",
                            ShortDescription = "Limited edition.",
                            Price = 15.26M,
                            InStock = true,
                            CategoryId = 3,
                            InTeaBags = false,
                            ImageThumbnailUrl = "/Images/MonkeyPickedTaiguanYin-sm.jpg",
                            ImageUrl = "/Images/PickedTaiguanYin.jpg"
                        },
                        new Tea
                        {
                            TeaId = 8,
                        //Id = new Guid("B1289505-113B-481F-B151-A8727429A1AD"),
                        Name = "Yunnan Pu Erh - No.37",
                            LongDescription = "Aged for 27 years, this Pu'erh tea from the Yunnan Province imparts a mature and smooth flavour.",
                            ShortDescription = "Mature and smooth flavour",
                            Price = 15.26M,
                            InStock = true,
                            CategoryId = 5,
                            InTeaBags = false,
                            IsTeaOfTheWeek = true,
                            ImageThumbnailUrl = "/Images/pu-erh-standard-sm.jpg",
                            ImageUrl = "/Images/pu-erh-standard.jpg"
                        },
                        new Tea
                        {
                            TeaId = 9,
                        //Id = new Guid("B817ED42-A9AF-43AB-BD46-F87A6FC18352"),
                        Name = "Sencha Goji-Berry Pomegranate Blend - No.11",
                            LongDescription = "Bursting with high levels of healthy antioxidants and rich in vitamins.",
                            ShortDescription = "Rich in vitamins.",
                            Price = 5.5M,
                            InStock = true,
                            CategoryId = 6,
                            InTeaBags = false,
                            ImageThumbnailUrl = "/Images/SenchaGojiberry-sm.jpg",
                            ImageUrl = "/Images/SenchaGojiberry.jpg"
                        },
                        new Tea
                        {
                            TeaId = 10,
                        //Id = new Guid("C2376498-B6AE-4760-AFF5-938A2E2D6BE5"),
                        Name = "Chamomile Blossoms - No.121",
                            LongDescription = "Revered for its outstanding health benefits, our chamomile tea offers an apple-like floral taste.",
                            ShortDescription = "Floral taste.",
                            Price = 4.2M,
                            InStock = true,
                            CategoryId = 7,
                            InTeaBags = false,
                            ImageThumbnailUrl = "/Images/organic-camomile-blossoms-sm.jpg",
                            ImageUrl = "/Images/organic-camomile-blossoms.jpg"
                        },
                        new Tea
                        {
                            TeaId = 11,
                        //Id = new Guid("673DA626-555A-4150-BFFA-C8D84ADF3E39"),
                        Name = "Vanilla Organic Rooibos - No.101",
                            LongDescription = "A healthy Organic Rooibos, this tea offers a rich, full-bodied infusion with tangy and sweet notes.",
                            ShortDescription = "Rich and full-bodied.",
                            Price = 6.72M,
                            InStock = true,
                            CategoryId = 8,
                            InTeaBags = false,
                            IsTeaOfTheWeek = true,
                            ImageThumbnailUrl = "/Images/vanilla-organic-rooibos-sm.jpg",
                            ImageUrl = "/Images/vanilla-organic-rooibos.jpg"
                        },
                        new Tea
                        {
                            TeaId = 12,
                        //Id = new Guid("C2376498-B6AE-4760-AFF5-938A2E2D6BE5"),
                        Name = "White Peony Supreme - No.148",
                            LongDescription = "Named after the petals of the White Peony, this tea is characterised by its tender, downy-white leaves.",
                            ShortDescription = "Tender, downy-white leaves.",
                            Price = 4.5M,
                            InStock = true,
                            CategoryId = 1,
                            InTeaBags = false,
                            ImageThumbnailUrl = "/Images/supremepeonyweb-sm.jpg",
                            ImageUrl = "/Images/supremepeonyweb.jpg"
                        },
                        new Tea
                        {
                            TeaId = 13,
                        //Id = new Guid("C2376498-B6AE-4760-AFF5-938A2E2D6BE5"),
                        Name = "Imperial Jasmine Silver Needle Triune Tea Bags Individually Wrapped - No.9",
                            LongDescription = "Naturally infused with the essential oils of jasmine flowers, this tea imparts a light flavour with floral notes.",
                            ShortDescription = "A light flavour with floral notes.",
                            Price = 34.2M,
                            InStock = true,
                            CategoryId = 1,
                            InTeaBags = true,
                            ImageThumbnailUrl = "/Images/JasmineNeedle-Envelop-sm.jpg",
                            ImageUrl = "/Images/JasmineNeedle-Envelop.jpg"
                        }
                        );
                }

                if (!context.TeaReviews.Any())
                {
                    context.AddRange
                    (
                        new TeaReview
                        {
                            TeaReviewId = 1,
                            TeaId = 1,
                            ReviewedBy = "shane",
                            ReviewedOn = new DateTime(2019, 4, 22, 14, 04, 0),
                            ReviewTitle = "My favourite",
                            ReviewText = "What a <b>great</b> tea, I absolutely love this stuff. For breakfast or all day it truly is the best",
                            Rating = 5
                        }

                    );
                }

                context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Teas ON");
                context.SaveChanges();
                context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Teas OFF");

                transaction.Commit();
            }
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        //new Category{CategoryId= 1, Id = new Guid("2320A8FB-5745-4999-9D45-95A221B57785"), CategoryName="White", CaffieneFree=false, Description= "White teas are the least processed of all teas. They release the least amount of caffeine of all teas, generally ranging from 10-15 milligrams per 8 oz cup. Almost all white teas hail from Fujian Province, China." },
                        //new Category{CategoryId= 2, Id = new Guid("F6E5009B-A9FA-439A-8546-2FF28CF672D5"), CategoryName="Green", CaffieneFree=false, Description= "Green tea leaves plucked in the morning are ready to be brewed in a pot the same night. The bypass of oxidation allows green tea to retain most of its natural dark green color, tannins, vitamin C, chlorophyll and minerals. The taste of green tea is therefore more astringent and subtler than oolong or black tea." },
                        //new Category{CategoryId= 3, Id = new Guid("14DF84B3-1E9D-4EDB-994E-E955B7D61D73"), CategoryName="Oolong", CaffieneFree=false, Description= "Oolong teas are semi–oxidized, which places them mid–way between green and black teas. This gives them the body and complexity of a black tea, with the brightness and freshness of a green tea." },
                        //new Category{CategoryId= 4, Id = new Guid("BCAAFAB1-17F3-4480-8915-1796F3401BDC"), CategoryName="Black", CaffieneFree=false, Description= "Black teas are fully oxidized teas. Black teas brew a liquor from reddish brown to dark brown. They are the most popular type of tea in the Western world. Black teas range from 40 – 60 milligrams of caffeine per 8 oz cup." },
                        //new Category{CategoryId= 5, Id = new Guid("1C147A76-2FEC-4CE4-AACA-558DD3CDE691"), CategoryName="Pu’erh", CaffieneFree=false, Description= "Pu’erh teas are aged and fermented. These aged teas are revered throughout Asia for their medicinal benefits, which range from curing hangovers to reducing cholesterol." },
                        //new Category{CategoryId= 6, Id = new Guid("19613EE6-84D1-4204-AD0B-9E297FDE3014"), CategoryName="Fruity Tea", CaffieneFree=true, Description= "With no limits to which fruits can be used to make fruit tea, there is a very wide variety available." },
                        //new Category{CategoryId= 7, Id = new Guid("DD2119F7-EBFC-4FDE-B9A3-933C31D82DAA"), CategoryName="Herbal", CaffieneFree=true, Description= "The history of herbs and spices is far more ancient than that of tea. Herbal Infusions are not tea, per se, as they do not come from the Camellia sinensis plant. They are popular after’dinner beverages and naturally 100% caffeine–free." },
                        //new Category{CategoryId= 8, Id = new Guid("CCD73059-E44B-4C81-97FE-8AD8C4DBDE6D"), CategoryName="Rooibos", CaffieneFree=true, Description= "Rooibos is a naturally caffeine-free herbal tea indigenous to the Cedarburg mountain area in South Africa, also known as red bush tea. Its naturally sweet flavor, lack of bitter tannins, and naturally decaf nature makes it a great tea for the whole family." },
                           
                        new Category{CategoryId= 1, CategoryName="White", CaffieneFree=false, Description= "White teas are the least processed of all teas. They release the least amount of caffeine of all teas, generally ranging from 10-15 milligrams per 8 oz cup. Almost all white teas hail from Fujian Province, China." },
                        new Category{CategoryId= 2, CategoryName="Green", CaffieneFree=false, Description= "Green tea leaves plucked in the morning are ready to be brewed in a pot the same night. The bypass of oxidation allows green tea to retain most of its natural dark green color, tannins, vitamin C, chlorophyll and minerals. The taste of green tea is therefore more astringent and subtler than oolong or black tea." },
                        new Category{CategoryId= 3, CategoryName="Oolong", CaffieneFree=false, Description= "Oolong teas are semi–oxidized, which places them mid–way between green and black teas. This gives them the body and complexity of a black tea, with the brightness and freshness of a green tea." },
                        new Category{CategoryId= 4, CategoryName="Black", CaffieneFree=false, Description= "Black teas are fully oxidized teas. Black teas brew a liquor from reddish brown to dark brown. They are the most popular type of tea in the Western world. Black teas range from 40 – 60 milligrams of caffeine per 8 oz cup." },
                        new Category{CategoryId= 5, CategoryName="Pu’erh", CaffieneFree=false, Description= "Pu’erh teas are aged and fermented. These aged teas are revered throughout Asia for their medicinal benefits, which range from curing hangovers to reducing cholesterol." },
                        new Category{CategoryId= 6, CategoryName="Fruity Tea", CaffieneFree=true, Description= "With no limits to which fruits can be used to make fruit tea, there is a very wide variety available." },
                        new Category{CategoryId= 7, CategoryName="Herbal", CaffieneFree=true, Description= "The history of herbs and spices is far more ancient than that of tea. Herbal Infusions are not tea, per se, as they do not come from the Camellia sinensis plant. They are popular after’dinner beverages and naturally 100% caffeine–free." },
                        new Category{CategoryId= 8, CategoryName="Rooibos", CaffieneFree=true, Description= "Rooibos is a naturally caffeine-free herbal tea indigenous to the Cedarburg mountain area in South Africa, also known as red bush tea. Its naturally sweet flavor, lack of bitter tannins, and naturally decaf nature makes it a great tea for the whole family." },
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}
