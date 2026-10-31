using Microsoft.EntityFrameworkCore;
namespace BethanysPieShop.Models
{
    public class ShoppingCart : IShoppingCart
    {
        private readonly AppDbContext _appDbContext;
        public string? ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; } = default!;

        private ShoppingCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession? session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext?.Session;
            AppDbContext context = services.GetService<AppDbContext>()
                ?? throw new Exception("Error initializing");
            string cartId = session?.GetString("CartId") ?? Guid.NewGuid().ToString();
            session?.SetString("CartId", cartId);
            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }
        public void AddToCart(Pie pie)
        {
            var ShoppingCartItem =
            _appDbContext.ShoppingCartItems.SingleOrDefault(
            s => s.Pie.PieId == pie.PieId && s.ShoppingCartId == ShoppingCartId);
            if (ShoppingCartItem == null)
            {
                ShoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    PieId = pie.PieId,
                    Amount = 1
                };
                _appDbContext.ShoppingCartItems.Add(ShoppingCartItem);
            }
            else
            {
                ShoppingCartItem.Amount++;
            }
            _appDbContext.SaveChanges();
        }
        public int RemoveFromCart(Pie pie)
        {
            var ShoppingCartItem =
            _appDbContext.ShoppingCartItems.SingleOrDefault(
            s => s.Pie.PieId == pie.PieId && s.ShoppingCartId == ShoppingCartId);
            var localAmount = 0;
            if (ShoppingCartItem != null)
            {
                if (ShoppingCartItem.Amount > 1)
                {
                    ShoppingCartItem.Amount--;
                    localAmount = ShoppingCartItem.Amount;
                }
                else
                {
                    _appDbContext.ShoppingCartItems.Remove(ShoppingCartItem);
                }
            }
            _appDbContext.SaveChanges();
            return localAmount;
        }
        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ??=
                       _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                           .Include(s => s.Pie)
                           .ToList();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _appDbContext.ShoppingCartItems
                           .Where(c => c.ShoppingCartId == ShoppingCartId)
                           .Select(c => c.Pie.Price * c.Amount)
                           .AsEnumerable()
                           .Sum();
            return total;
        }
        public void ClearCart()
        {
            var cartItems = _appDbContext
                .ShoppingCartItems
                .Where(cart => cart.ShoppingCartId == ShoppingCartId);

            _appDbContext.ShoppingCartItems.RemoveRange(cartItems);

            _appDbContext.SaveChanges();
        }
    }
}