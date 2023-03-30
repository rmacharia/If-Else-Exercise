int currentInventory = 10;
int quantityToOrder = 5;

if (currentInventory >= quantityToOrder)
{
    Console.WriteLine("Inventory is sufficient. No need to order more.");
}
else
{
    int quantityNeeded = quantityToOrder - currentInventory;
    Console.WriteLine($"Inventory is low. Please order {quantityNeeded} more items.");
}
