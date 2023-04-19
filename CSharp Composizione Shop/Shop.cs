using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Composizione_Shop
{

    public class Shop
    {
        //ATTRIBUTI
        private string shopName;
        private string shopCity;
        private string shopAddress;
        private List<Product> ProductList;


        //COSTRUTTORE
        public Shop(string shopName, string shopCity, string shopAddress) {
        
         this.shopName = shopName;
         this.shopCity = shopCity;
         this.shopAddress = shopAddress;
         this.ProductList = new List<Product>();
         
    
        }

       //GETTERS
       public string ShopName
        { get { return this.shopName; }  }

        public string ShopCity
        { get { return this.shopCity; } set { this.shopCity = value; } }

        public string ShopAddress
        { get { return this.shopAddress; } set { this.shopAddress = value; } }
        
        public List<Product> GetProducts() {

            return this.ProductList;


        }





















    }
}
