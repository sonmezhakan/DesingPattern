using CA_Singleton.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Singleton.Data
{
    public class ProductData
    {
        private static ProductData _productData;
        private ProductData()
        {
            //Constructor private tanımlandığından dışarıdan erişimi engelleriz
        }
        public static ProductData Instance
        {
            get 
            { 
                //Eğer instance alınmadıysa instance alınmasını sağlıyoruz. Instance alındıysa bellekte tutulan instance geri döndürüyoruz.
                if(_productData == null)
                {
                    _productData = new ProductData();
                }
                return _productData;
            }

        }
    }
}
