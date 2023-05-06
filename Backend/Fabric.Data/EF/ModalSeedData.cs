using Fabric.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric.Data.EF
{
    public static class ModalSeedData
    {
        private static List<Pattern> patterns = new List<Pattern>();
        private static List<Category> categories = new List<Category>();
        public static void Seed(this ModelBuilder modelBuilder)
        {
            AddCategory(modelBuilder);
            AddPattern(modelBuilder);
            AddSetting(modelBuilder);
            AddProduct(modelBuilder);
            AddImage(modelBuilder);
        }
        static void AddCategory(ModelBuilder modelBuilder)
        {
            List<(string, string)> categoryData = new List<(string, string)>();
            categoryData.Add(("Silk Fabrics", "Browse all our silk fabrics here, and use the filter to refine your options! Our evolving array of designer & Liberty deadstock silk fabrics provides an ongoing treasure hunt for many a seasoned sewist, with lots of these rolls one-of-a-kind and never to be seen again!  Whether you're looking for silk prints, georgettes, crepes, challis, twills, satins, suitings or jacquards you'll be sure to find something suitable online! Shop silk fabrics online today!"));
            categoryData.Add(("Rayon, Viscose & More", "Browse all of our range of rayon, viscose & other cellulose fabrics here and use the filter to refine your options. Our evolving array of designer & Liberty deadstock cellulose fabrics provides an ongoing treasure hunt for many a seasoned sewist, with lots of these rolls of of a kind and never to be seen again! Whether you're looking for vintage-inspired prints, georgettes, crepes, challis, twills, satins, suitings or knitted fabrics you'll be sure to find something suitable online! Shop rayon, viscose fabrics online today!"));
            categoryData.Add(("Merino Fabrics", "Browse all our merino fabrics here and use the filter to refine your options! Merino is one of the world’s oldest breeds of sheep, originating in Spain as far back as the 12th century. Merino sheep produce extremely fine and soft wool, making fabric that is breathable, moisture-wicking and suitable for all seasons as well as a huge variety of uses. Browse our huge range of merino fabrics online here, including our exclusive, ethically-made ZQ Premium Merino range in over 35 shades, along with our ever-evolving range of deadstock merino fabrics in heavyweight, activewear, textured and striped styles! Shop merino fabrics online today!"));
            categoryData.Add(("Linen Fabrics", "Browse all our linen fabrics here, and use the filter to refine your options! Here at The Fabric Store, linen is one of our favourite fibres. As well as being super easy to sew, linen fabric has a lovely earthy feel, starting off crisp but softening beautifully in time with wash and wear. The flax plant, from which linen fibres are harvested, consumes far less water than cotton and requires fewer chemicals and pesticides making it a great eco fabric choice for the environmentally conscious. Browse our huge range of linen fabrics online here, including our exclusive ranges and our ever-evolving collection of deadstock linens as well! Our exclusive ranges include certified Organic Linen, Gingham Linen, Vintage Finish Linen and Heavyweight Linen. Find an array of patterns, textures and colours in our deadstock linens too! Shop linen fabrics online today!"));
            categoryData.Add(("Cotton Fabrics", "Browse our huge range of cotton fabrics here and use the filter to refine your options. This collection includes our exclusive certified Organic Cotton Sweatshirting + Rib and Upcycled Cotton ranges. Our evolving array of designer & Liberty deadstock cotton fabrics provides an ongoing treasure hunt for many a seasoned sewist, with lots of these rolls one-of-a-kind and never to be seen again! Whether you're looking for cotton prints, stripes, checks, shirtings, sateens, denims, chambrays, twills, corduroys, sateens or knitted fabrics, you'll be sure to find something suitable online! Shop cotton fabrics online today!"));
            categoryData.Add(("Jersey & Knitted Fabrics", "Browse all our cotton, viscose & synthetic blend knitted fabrics here and use the filter to refine your options. This collection includes our exclusive certified Organic Cotton Sweatshirting + Rib too. Our evolving array of designer & Liberty deadstock knitted fabrics provides an ongoing treasure hunt for many a seasoned sewist, with lots of these rolls of-of-a-kind and never to be seen again! Whether you're looking for relaxed linens, super soft cottons, fluid viscose and stretchy activewear jerseys. For a casual project with flair choose our printed Liberty cotton knits, and for the cooler days, our range of sweatshirtings are ideal! Shop knitted & jersey fabric online today!"));

            for(var i = 0; i < categories.Count; i++)
            {
                var key = "CTGR" + IDGenerator(i);
                var category = categoryData[i];
                categories.Add(new Category()
                {
                    ID = key,
                    Name = category.Item1,
                    Description = category.Item2,
                });
            }

            modelBuilder.Entity<Category>().HasData(categories);
        }
        static void AddPattern(ModelBuilder modelBuilder)
        {
            string[] patternName = { "Abstract", "Animal", "Check", "Conversational", "Floral", "Geometric", "Large Scale", "Motif", "No Pattern", "Paisley" };
            for(var i = 0; i < patternName.Length; i++)
            {
                var key = "PTRN" + IDGenerator(i);
                patterns.Add(new Pattern()
                {
                    ID = key,
                    Name = patternName[i],
                });
            }
            modelBuilder.Entity<Pattern>().HasData(patterns);
        }
        static void AddSetting(ModelBuilder modelBuilder)
        {
            List<(string, string, string)> settingData = new List<(string, string, string)>();
            settingData.Add(("Width", "0", "49"));
            settingData.Add(("Width", "50", "60"));
            List<Setting> settings = new List<Setting>();
            for(var i = 0; i < settingData.Count; i++)
            {
                var key = "STTG" + IDGenerator(i);
                var setting = settingData[i];
                settings.Add(new Setting()
                {
                    ID = "STTG" + IDGenerator(i++),
                    Type = setting.Item1,
                    Value1 = setting.Item2,
                    Value2 = setting.Item3,
                });
            }
            modelBuilder.Entity<Setting>().HasData(settings);
        }
        static void AddProduct(ModelBuilder modelBuilder)
        {
            int i = 0;
            List<Product> products = new List<Product>();
            products.Add(new Product()
            {
                ID = "PRDT" + IDGenerator(i++),
                Name = "ZQ Premium Merino - Turmeric",
                Quantity = 99,
                Width = 59,
                Price = 36.00,
                Weight = Enums.WeightEnum.Midweight,
                Stretch = Enums.StretchEnum.NonStretch,
                WovedIn = "Dalat City and Nam Dinh City, Vietnam",
                PatternID = patterns.Where(x => x.Name == "No Pattern").Select(x => x.ID).FirstOrDefault(),
                CategoryID = categories.Where(x => x.Name == "Merino Fabrics").Select(x => x.ID).FirstOrDefault(),
                Description = "// Our single jersey ZQ Premium Merino in our seasonal colour, Turmeric. This fabric is knitted from ZQ certified merino and produced just for us in our range of exclusive colours. The superfine merino fibre is spun into a single twist yarn, creating a slightly textural fabric with naturally occurring slubs throughout. The single jersey knit structure gives this fabric mechanical stretch and great drape. Beautifully soft, merino jersey is ideal for all seasons and perfect for next-to-skin basics and layering."
            });
            products.Add(new Product()
            {
                ID = "PRDT" + IDGenerator(i++),
                Name = "Pindot Merino Blend Jersey - Army",
                Quantity = 99,
                Width = 47,
                Price = 18.00,
                Weight = Enums.WeightEnum.Lightweight,
                Stretch = Enums.StretchEnum.OneWay,
                WovedIn = "Vietnam",
                PatternID = patterns.Where(x => x.Name == "Large Scale").Select(x => x.ID).FirstOrDefault(),
                CategoryID = categories.Where(x => x.Name == "Merino Fabrics").Select(x => x.ID).FirstOrDefault(),
                Description = "// This lightweight army green merino blend jersey has subtle pointelle holes, backed with a very fine plated stripe. Perfect for street and activewear for those chillier days."
            });
            products.Add(new Product()
            {
                ID = "PRDT" + IDGenerator(i++),
                Name = "Sheer Check Silk / Cotton - Teal / Black",
                Quantity = 99,
                Width = 57,
                Price = 24.00,
                Weight = Enums.WeightEnum.Midweight,
                Stretch = Enums.StretchEnum.TwoWay,
                WovedIn = "China",
                PatternID = patterns.Where(x => x.Name == "Check").Select(x => x.ID).FirstOrDefault(),
                CategoryID = categories.Where(x => x.Name == "Silk Fabrics").Select(x => x.ID).FirstOrDefault(),
                Description = "// A deadstock silk/ cotton in teal and black. This lightweight fabric has been cleverly woven with sheer black warp striped with a  deep teal stripe, then a sheer black and teal striped weft creating a dimensional check fabric. A sheer fabric with a dry hand feel and no stretch. Ideal for shirts like the Bloom, dresses like the Paint or Ivy."
            });

            modelBuilder.Entity<Product>().HasData(products);
        }
        static void AddImage(ModelBuilder modelBuilder)
        {
            List<(string, string[])> imageData = new List<(string, string[])> ();
            string[] imagesPRDT000000 = { "https://res.cloudinary.com/dhi3bjn0s/image/upload/v1683395842/Fabric/ZQ_Merino_Tumeric_Swatch_1000x1000_sixf1d.webp", "https://res.cloudinary.com/dhi3bjn0s/image/upload/v1683395881/Fabric/ZQ_Merino_Tumeric_Hang_36b686ea-16c4-447b-9426-d9ea304bf617_1000x1000_ij2rgq.webp", "https://res.cloudinary.com/dhi3bjn0s/image/upload/v1683395881/Fabric/ZQ_Merino_Tumeric_Roll_1000x1000_a9dzr7.webp", "https://res.cloudinary.com/dhi3bjn0s/image/upload/v1683395883/Fabric/ZQ_Merino_Tumeric_Ruler_2864b442-a822-45b5-a5ac-90877b38be7f_1000x1000_fvgqio.webp" };
            imageData.Add(("PRDT000000", imagesPRDT000000));
            string[] imagesPRDT000001 = { "https://res.cloudinary.com/dhi3bjn0s/image/upload/v1683396716/Fabric/Pindot_Merino_Blend_Jersey_Army_Swatch_1000x1000_pn9pxf.webp", "https://res.cloudinary.com/dhi3bjn0s/image/upload/v1683396715/Fabric/Pindot_Merino_Blend_Jersey_Army_Hang_1000x1000_vyvzd0.webp", "https://res.cloudinary.com/dhi3bjn0s/image/upload/v1683396716/Fabric/Pindot_Merino_Blend_Jersey_Army_Roll_1000x1000_tqamxz.webp", "https://res.cloudinary.com/dhi3bjn0s/image/upload/v1683396716/Fabric/Pindot_Merino_Blend_Jersey_Army_Ruler_1000x1000_ai1wi2.jpg" };
            imageData.Add(("PRDT000001", imagesPRDT000001));
            string[] imagesPRDT000002 = { "https://res.cloudinary.com/dhi3bjn0s/image/upload/v1683397552/Fabric/Teal_Sheer_Grid_Swatch_OO_1000x1000_yedrcg.webp", "https://res.cloudinary.com/dhi3bjn0s/image/upload/v1683397552/Fabric/Teal_Sheer_Grid_Hang_1000x1000_qjtbii.webp", "https://res.cloudinary.com/dhi3bjn0s/image/upload/v1683397552/Fabric/Teal_Sheer_Grid_Roll_1000x1000_gxqmax.webp", "https://res.cloudinary.com/dhi3bjn0s/image/upload/v1683397552/Fabric/Teal_Sheer_Grid_Ruler_1000x1000_jpi3h1.webp" };
            imageData.Add(("PRDT000002", imagesPRDT000002));
            List<Image> images = new List<Image>();
            var i = 0;
            foreach (var image in imageData)
            {
                foreach (var image2 in image.Item2)
                {
                    images.Add(new Image()
                    {
                        ID = "IMGE" + IDGenerator(i),
                        ProductID = image.Item1,
                        Url = image2
                    });
                    i = i + 1;
                }
            }

            modelBuilder.Entity<Image>().HasData(images);
        }

        static string IDGenerator(int id)
        {
            var numberOfZero = 6 - id.ToString().Length;
            var result = id.ToString();
            for(var i = 0; i < numberOfZero; i++)
            {
                result = "0" + result;
            }
            return result;
        }
    }
}
