using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeaShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category{CategoryId= 1, CategoryName="White", CaffieneFree=false, Description= "White teas are the least processed of all teas. They release the least amount of caffeine of all teas, generally ranging from 10-15 milligrams per 8 oz cup. Almost all white teas hail from Fujian Province, China." },
                    new Category{CategoryId= 2, CategoryName="Green", CaffieneFree=false, Description= "Green tea leaves plucked in the morning are ready to be brewed in a pot the same night. The bypass of oxidation allows green tea to retain most of its natural dark green color, tannins, vitamin C, chlorophyll and minerals. The taste of green tea is therefore more astringent and subtler than oolong or black tea." },
                    new Category{CategoryId= 3, CategoryName="Oolong", CaffieneFree=false, Description= "Oolong teas are semi–oxidized, which places them mid–way between green and black teas. This gives them the body and complexity of a black tea, with the brightness and freshness of a green tea." },
                    new Category{CategoryId= 4, CategoryName="Black", CaffieneFree=false, Description= "Black teas are fully oxidized teas. Black teas brew a liquor from reddish brown to dark brown. They are the most popular type of tea in the Western world. Black teas range from 40 – 60 milligrams of caffeine per 8 oz cup." },
                    new Category{CategoryId= 5, CategoryName="Pu’erh", CaffieneFree=false, Description= "Pu’erh teas are aged and fermented. These aged teas are revered throughout Asia for their medicinal benefits, which range from curing hangovers to reducing cholesterol." },
                    new Category{CategoryId= 6, CategoryName="Fruity Tea", CaffieneFree=true, Description= "With no limits to which fruits can be used to make fruit tea, there is a very wide variety available." },
                    new Category{CategoryId= 7, CategoryName="Herbal", CaffieneFree=true, Description= "The history of herbs and spices is far more ancient than that of tea. Herbal Infusions are not tea, per se, as they do not come from the Camellia sinensis plant. They are popular after’dinner beverages and naturally 100% caffeine–free." },
                    new Category{CategoryId= 8, CategoryName="Rooibos", CaffieneFree=true, Description= "Rooibos is a naturally caffeine-free herbal tea indigenous to the Cedarburg mountain area in South Africa, also known as red bush tea. Its naturally sweet flavor, lack of bitter tannins, and naturally decaf nature makes it a great tea for the whole family." },
                };
            }
        }
    }
}


