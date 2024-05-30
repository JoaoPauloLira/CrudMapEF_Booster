using ProjetoBooster.Entities;

namespace ProjetoBooster.Business
{
    public interface IProdutoBusiness
    {
        Task<IEnumerable<Produto>> GetAll();
        Task<Produto> GetById(int id);
        Task Add(Produto produto);
        Task Update(Produto produto);
        Task Delete(int id);
    }
}
