using System.Collections.Generic;
using System.Linq;

public class Cart
{
    public List<CartItem> Items { get; set; } = new List<CartItem>();

    public void AddItem(CartItem item)
    {
        var existingItem = Items.FirstOrDefault(x => x.ProductId == item.ProductId);

        if (existingItem != null)
        {
            existingItem.Quantity += item.Quantity;
        }
        else
        {
            Items.Add(item);
        }
    }

    public void RemoveItem(int productId)
    {
        Items.RemoveAll(x => x.ProductId == productId);
    }

    public decimal GetTotal()
    {
        return Items.Sum(x => x.Price * x.Quantity);
    }
}