// classes: Product - name, price, boolean, product type id
//          ProductType- names/categories

// view, add, delete, and update 

// main menu:
//view all
//add
//delete
//update
//search by product type


using System.Runtime.CompilerServices;

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
            throw new NotImplementedException();
        case 4:
            throw new NotImplementedException();
        case 5:
            throw new NotImplementedException();
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

