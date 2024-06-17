// classes: Product - name, price, boolean, product type id
//          ProductType- names/categories

// view, add, delete, and update 

// main menu:
//view all
//add
//delete
//update
//search by product type


List <ProductType> productTypes = new List<ProductType>()
{
    new ProductType()
    {
        Category = "Apparel",
    },
    new ProductType()
        {
        Category = "Potions",
    },
    new ProductType()
        {
        Category = "Enchanted Objects",
    },
    new ProductType()
    {
        Category = "Wands"
    }
};

List <Product> products = new List<Product>()
{
    new Product()
    {
        Name = "Gooseberry Juice",
        Price = 8M,
        Available = true,
        ProductTypeId = 2

    },
        new Product()
    {
        Name = "Neville's Formal Slippers",
        Price = 12M,
        Available = true,
        ProductTypeId = 1

    },
        new Product()
    {
        Name = "Json Obj",
        Price = 6M,
        Available = false,
        ProductTypeId = 3

    },
        new Product()
    {
        Name = "The Middle Finger",
        Price = 90M,
        Available = true,
        ProductTypeId = 4

    },
};


Console.WriteLine(@"
Welcome to Abe and Red's Emporium. ");

int choice = 0; 

while (choice != 6)
{

    Console.WriteLine(@"
        Please Select and Option:
        1. Display all Products
        2. Display by Product Type
        3. Add a Product
        4. Update a Product
        5. Delete a Product 
        6. Exit
        
    ");

    choice = int.Parse(Console.ReadLine());

    switch(choice)
    {
        case 1:
            ListProducts();
            break;
        case 2:
            throw new NotImplementedException();
        case 3:
            AddProduct();
            break;
        case 4:
            UpdateProduct();
            break;
        case 5:
            DeleteProduct();
            break;
        case 6:
            Console.WriteLine(@"
            Fek you! Come again...
            ");
            break;
        default:
            throw new FormatException();
    }

}

void ListProducts()
{
    for(int i = 0; i < products.Count;  i++)
    {
        Console.WriteLine(@$"
        ----------------------------
         {i + 1 }. {products[i].Name}");
    }
}

void ListProductTypes()
{

    for ( int i = 0; i <productTypes.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {productTypes[i].Category}");
    }


     
}


void AddProduct()
{
    Console.WriteLine(@"
    Name your product");

    string name = Console.ReadLine();

    Console.WriteLine(@"
    Name your price");

    decimal price = decimal.Parse(Console.ReadLine());

    Console.WriteLine(@"
    Select a category:");

    ListProductTypes();

    int productTypeId = int.Parse(Console.ReadLine());

    Product productToAdd = new Product()
    {
        Name = name,
        Price = price,
        Available = true,
        ProductTypeId = productTypeId

    };

    products.Add(productToAdd);

    if (products.Last().Name == name)
    {
        Console.WriteLine(@$"{name} was added to the inventory!");
    }
    else 
    {
        Console.WriteLine(@$"
        There was a problem adding your product to inventory!");
    }

    Console.WriteLine("Would you like to add another product? Enter y/n.");

    string rerun = Console.ReadLine();

    if (rerun == "y")
    {
        AddProduct();
    }

}

void UpdateProduct()
{
    Console.WriteLine(@"Please select a product to update");

    ListProducts();

    int choice = int.Parse(Console.ReadLine());

    if (choice > 0 || choice <= products.Count)
    {
        Product prod = products[choice - 1];
        UpdateProperties(prod);
    }
    else
    {
        Console.WriteLine(@"Please make a selection from the given options");
    }


}

void UpdateProperties(Product prod)
{
    int choice = 0;
    while (choice != 5)
    {

    Console.WriteLine(@$"Which property would you like to change?

    1. Name: {prod.Name}
    2. Price: {prod.Price}
    3. ProductTypeId: {prod.ProductTypeId}
    4. Availability: {prod.Available}
    5. I'm finished updating properties
    ");

    choice = int.Parse(Console.ReadLine());

    switch(choice)
    {
        case 1 :
            Console.WriteLine(" What is the new name of this product?");
            string name = Console.ReadLine();
            prod.Name = name;
            break;

        case 2:
            Console.WriteLine(" What is the new price?");
            string price = Console.ReadLine();
            prod.Price = Decimal.Parse(price);
            break;
        
        case 3:
            Console.WriteLine("Please Select a new product type ");
            ListProductTypes();
            // test
            int productType = int.Parse(Console.ReadLine());
            prod.ProductTypeId = productType;
            break;

        case 4:
            prod.Available = !prod.Available;
            Console.WriteLine(prod.Available 
            ? "Your product is in stock" 
            : "Your product has been sold");
            break;

        case 5: 
            Console.WriteLine("Product Update Completed");
            break;

        default:
            Console.WriteLine("Please choose from the listed options only");
            break;

    }

    }

}

void DeleteProduct()
{
    Console.WriteLine("Which product would you like to delete?");

    ListProducts();

    int choice = int.Parse(Console.ReadLine());

    products.RemoveAt(choice -1);

    Console.WriteLine("Delete Successful");

}
