using CSharp_Composizione_Shop;

Product newProduct1 = new Product("shampoo1", "descrizione1", true, 3.0f);
Product newProduct2 = new Product("shampoo1", "descrizione1", true, 3.0f);
Product newProduct3 = new Product("shampoo2", "descrizione2", false, 3.0f);
Product newProduct4 = new Product("shampoo3", "descrizione3", false, 3.00f);


Shop newShop = new Shop("negozio altamente bello","Roma","via dei pini n34");
List<Product> productslistAgg = new List<Product> { newProduct1, newProduct2 };
//newShop.addProductList((productslistAgg));
//newShop.AddProduct(newProduct3);
//newShop.RemoveProduct(newProduct1);
//Console.WriteLine(newShop.strRappresetation());

Shop newShop2 = new Shop("negozio altamente bello2", "Roma3", "via dei pini n34");
List<Product> productslistAgg2 = new List<Product> { newProduct1, newProduct2, newProduct4 };
newShop2.addProductList((productslistAgg2));
newShop2.AddProduct(newProduct3);
Console.WriteLine(newShop2.strRappresetation());