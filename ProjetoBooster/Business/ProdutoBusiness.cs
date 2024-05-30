using ProjetoBooster.Entities;
using ProjetoBooster.Repositories;

namespace ProjetoBooster.Business
{
    public class ProdutoBusiness : IProdutoBusiness
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoBusiness(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<IEnumerable<Produto>> GetAll()
        {
            return await _produtoRepository.GetAll();
        }

        public async Task<Produto> GetById(int id)
        {
            return await _produtoRepository.GetById(id);
        }

        public async Task Add(Produto produto)
        {
            await _produtoRepository.Add(produto);
        }

        public async Task Update(Produto produto)
        {
            await _produtoRepository.Update(produto);
        }

        public async Task Delete(int id)
        {
            await _produtoRepository.Delete(id);
        }
    }
}
