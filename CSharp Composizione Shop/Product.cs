namespace CSharp_Composizione_Shop
{
   public class Product
    {
        private string nameProduct;
        private string descriptionProduct;
        private int barCode;
        private bool onSale;
        private float price;

        //Costruttore
        public Product(string nameProduct, string descriptionProduct, int barCode, bool onSale )
        { 
        
        this.nameProduct = nameProduct;
        this.descriptionProduct = descriptionProduct;
        this.barCode = GenerateCode();
        this.onSale = onSale;
        this.price = price;        
        
        
        }

        //Getters setters

        //nome prodotto
        public string NameProduct
        {
            get { return this.nameProduct; }
            set { this.nameProduct = value; }
        }

        //descrizione
        public string DescriptionProduct
        {
            get { return this.descriptionProduct; }
            set { this.descriptionProduct = value; }
        }
        //codice a barre
        public int BarCode
        {
            get { return this.barCode; }
        }


        //saldo prodotto 
        //getters
        public bool GetOnSale()
        {
            return this.onSale;
        }
        
        //setters
        public bool SetOnSale()
        {
            return onSale = false;
        }
       

        //metodi

        //generare numero randomico
        private int GenerateCode()
        {
            Random rnd = new Random();
            return rnd.Next(10000000, 99999999);

        }

        public string GetProductString()
        {
            string rapprString = "Nome del prodotto: " + this.nameProduct + ", ";
            rapprString += "Description: " + this.descriptionProduct + ", ";
            rapprString += "Prezzo: " + this.price + ", ";
            rapprString += "Barcode: " + this.barCode + ", ";
            rapprString += "Is on sale? " + this.onSale + ", ";

            return rapprString;
        }




    }
}