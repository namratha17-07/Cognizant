using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;

using var context = new AppDbContext();

// Retrieve all products
Console.WriteLine("All Products:");
var products = await context.Products.ToListAsync();

foreach (var p in products)
{
    Console.WriteLine($"{p.Name} - ₹{p.Price}");
}

// Find product by ID
var product = await context.Products.FindAsync(1);

Console.WriteLine();
Console.WriteLine($"Found Product: {product?.Name}");

// Retrieve first expensive product
var expensive = await context.Products
    .FirstOrDefaultAsync(p => p.Price > 50000);

Console.WriteLine($"Expensive Product: {expensive?.Name}");