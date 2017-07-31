using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolPCLibrary
{
    public class Product
    {
        public static int MaxId;
        private int id;
        public string Name;
        public int SupplierId;
        private int categoryId;
        public string Unit;

        //   public float Price;
        private float price;

        public Product()
        {
            id = ++Product.MaxId;
        }

        public float Price
        {
            set
            {
                if (value >= 1000f)
                    this.price = 1000.0f;
                else if (value < 100f)
                    this.price = 100f;
                else
                    this.price = value;
            }
            get
            {
                return this.price;
            }
        }

        public int CategoryId
        {
            get => categoryId;
            set
            {
                if (value < 0)
                    this.categoryId = 0;
                else
                    value = categoryId;
            }
        }

        public int Id { get => id; }

        #region 傳純屬性寫法

        //      public void setprice(float value)
        //      {
        //          if (value >= 1000f)
        //              this.price = 1000.0f;
        //          else if (value < 100f)
        //              this.price = 100f;
        //          else
        //              this.price = value;
        //      }

        //      public float getprice()
        //      {
        //          return this.price;
        //      }

        #endregion 傳純屬性寫法
    }
}