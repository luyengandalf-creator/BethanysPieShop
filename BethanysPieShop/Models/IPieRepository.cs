namespace BethanysPieShop.Models
{
public interface IPieRepository
{
Task<List<Pie>> GetAllAsync();
Task<List<Pie>> GetPiesOfTheWeek();
Task<Pie?> GetByidAsync(int id);
Task<List<Pie>> GetByCategoryAsync(string categoryName);
}
}