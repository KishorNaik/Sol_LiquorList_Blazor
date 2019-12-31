using Sol_List.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_List.Data
{
    public class LiquorData
    {
        public async Task<IEnumerable<LiquorModel>> GetLiquorListAsync()
        {
            return await Task.Run(() => {

                var liquorList = new List<LiquorModel>();

                liquorList.Add(new LiquorModel()
                {

                    Category = "Beer",
                    Name = "Budweiser",
                    Url = "https://4.bp.blogspot.com/-qO_jUdEjaeg/WQ6wfWqwx_I/AAAAAAAAHMU/9edHPrv0ll8DFW1MVFS47pr6wG8Nr9gOQCLcB/s1600/download.jpg",
                    Price = 150

                });

                liquorList.Add(new LiquorModel()
                {

                    Category = "Beer",
                    Name = "Kingfisher",
                    Url = "https://produits.bienmanger.com/34519-0w470h470_Kingfisher_Premium_Beer_From_India.jpg",
                    Price = 150

                });

                liquorList.Add(new LiquorModel()
                {

                    Category = "Beer",
                    Name = "Tuborg",
                    Url = "https://5.imimg.com/data5/QR/FB/QZ/SELLER-11737895/tuborg-non-alcohoilc-beer-500x500.jpg",
                    Price = 150

                });

                liquorList.Add(new LiquorModel()
                {

                    Category = "Wine",
                    Name = "Sula Rasa",
                    Url = "https://sulawines.com/DataFiles/pro_detail_img/11_11_2016_04_34_241sb.png",
                    Price = 1495

                });

                liquorList.Add(new LiquorModel()
                {

                    Category = "Wine",
                    Name = "Myra Misfit",
                    Url = "http://www.thedrinksbusiness.com/wordpress/wp-content/uploads/2015/07/Misfit-wine-350x350.jpg",
                    Price = 1500

                });

                liquorList.Add(new LiquorModel()
                {
                    Category = "Wine",
                    Name = "Fratelli Sette",
                    Url = "https://cdn.shopify.com/s/files/1/1784/6695/products/FRATELLI_SETE_2013.png?v=1530151835",
                    Price = 1600

                });

                liquorList.Add(new LiquorModel()
                {
                    Category = "Whiskey",
                    Name = "Blenders Pride",
                    Url = "https://i.pinimg.com/originals/05/b6/dd/05b6ddbc8a828fdc38daffe5080e6fdf.jpg",
                    Price = 929

                });

                liquorList.Add(new LiquorModel()
                {
                    Category = "Whiskey",
                    Name = "Royal Challenge",
                    Url = "https://www.wine-searcher.com/images/labels/84/61/10498461.jpg",
                    Price = 1200
                });

                liquorList.Add(new LiquorModel()
                {
                    Category = "Whiskey",
                    Name = "Signature",
                    Url = "http://dwineshop.com/wp-content/uploads/2016/11/wh148-wh154.png",
                    Price = 1200

                });

                liquorList.Add(new LiquorModel()
                {
                    Category = "Vodka",
                    Name = "White Mischief",
                    Url = "https://api.dialadelivery.co.ke/uploads/white-mischief-vodka.jpeg",
                    Price = 500

                });

                liquorList.Add(new LiquorModel()
                {
                    Category = "Vodka",
                    Name = "Romanov",
                    Url = "http://dwineshop.com/wp-content/uploads/2016/11/170-thickbox_default.jpg",
                    Price = 500

                });

                liquorList.Add(new LiquorModel()
                {
                    Category = "Vodka",
                    Name = "Smirnoff",
                    Url = "https://cdn.diffords.com/contrib/bws/2017/10/59db862390633.jpg",
                    Price = 500

                });

                return liquorList;
            });
        }
    }
}
