using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    //Requirements
    //1.  add product to cart
    // 2. remove product from cart
    // 3. clear cart

    //4. increase total number of  products already in the cart
    //5.increase total number of products and its number of the product is not in the cart 
    public class CartManager
   {
       private readonly List<CartItem> _cartItems;

       public CartManager()
       {
           _cartItems = new List<CartItem>();
       }

       public void Add(CartItem cartItem)
       {
           var addCarItem = _cartItems.SingleOrDefault(t => t.Product.ProductId == cartItem.Product.ProductId);
           if (addCarItem == null)
           {

               _cartItems.Add(cartItem);

            }
           else
           {
               addCarItem.Quantity += cartItem.Quantity;
           }
          
       }

       public void Remove(int productId)
       {
           var product = _cartItems.FirstOrDefault(t => t.Product.ProductId == productId);

           _cartItems.Remove(product);
       }

       public List<CartItem> CartItems
       {
           get { return _cartItems; }
       }

       public void Clear()
       {
           _cartItems.Clear();
       }

       public decimal TotalPrice
       {
           get { return _cartItems.Sum(t => t.Quantity * t.Product.UnitPrice); }
       }

       public int TotalQuantity
       {
           get { return _cartItems.Sum(t => t.Quantity ); }
       }

       public int TotalItems
       {
           get { return _cartItems.Count; }
       }

    }
}
