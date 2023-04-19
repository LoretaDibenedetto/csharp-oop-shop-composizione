using CSharp_Composizione_Shop;


Shop newShop = new Shop("negozio altamente bello","Roma","via dei pini n34");
Product newProduct1 = new Product("shampoo", "descrizione", true, 3.0f);
Product newProduct2 = new Product("shampoo2", "descrizione2", false, 3.0f);

List<Product> productslistAgg = new List<Product> { newProduct1, newProduct2 };

newShop.addProductList((productslistAgg));
Console.WriteLine(newShop.strRappresetation());