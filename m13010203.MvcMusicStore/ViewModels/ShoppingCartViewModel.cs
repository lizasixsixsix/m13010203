using System.Collections.Generic;
using m13010203.MvcMusicStore.Models;

namespace m13010203.MvcMusicStore.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal    { get; set; }
    }
}