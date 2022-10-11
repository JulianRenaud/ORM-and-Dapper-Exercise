using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using ORM_Dapper;
using System.Data;

var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

string connString = config.GetConnectionString("DefaultConnection");

IDbConnection conn = new MySqlConnection(connString);

#region Department

////ADDING TO DEPARTMENTS

//var departmentRepo = new DapperDepartmentRepository(conn);

////departmentRepo.InsertDepartment("Anything");

////SELECTING DEPARTMENTS

//var departments = departmentRepo.GetAllDepartments();

//foreach (var department in departments)
//{
//    Console.WriteLine($"{department.DepartmentID} {department.Name}");
//    Console.WriteLine();
//    Console.WriteLine();
//}

#endregion


#region Product
var productRepository = new DapperProductRepository(conn);

//UPDATING A PRODUCT

//var productToUpdate = productRepository.GetProduct(940);


//productToUpdate.Name = "Macbook";
//productToUpdate.Price = 1000;
//productToUpdate.CategoryID = 1;
//productToUpdate.StockLevel = 866;
//productToUpdate.OnSale = true;

//productRepository.UpdateProduct(productToUpdate);


//DELETING A PRODUCT

//productRepository.DeleteProduct(940);




//SELECTING PRODUCTS




var products = productRepository.GetAllProducts();


foreach (var product in products)
{
    Console.WriteLine(product.ProductID);
    Console.WriteLine(product.Name);
    Console.WriteLine(product.Price);
    Console.WriteLine(product.CategoryID);
    Console.WriteLine(product.OnSale);
    Console.WriteLine(product.StockLevel);
    Console.WriteLine();
    Console.WriteLine();
}

#endregion