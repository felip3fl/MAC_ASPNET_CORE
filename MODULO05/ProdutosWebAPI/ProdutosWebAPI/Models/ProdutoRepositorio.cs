using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdutosWebAPI.Models
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private List<Produto> produtos = new List<Produto>();
        private int _nextId = 1;

        public ProdutoRepositorio()
        {
            produtos.Add(new Produto { Id = 1, Nome = "Guaraná Antartica", Categoria = "Refrigerantes", Preco = 4.59M });
            produtos.Add(new Produto { Id = 2, Nome = "Suco de Laranja Prats", Categoria = "Sucos", Preco = 5.75M });
            produtos.Add(new Produto { Id = 3, Nome = "Mostarda Hammer", Categoria = "Condimentos", Preco = 3.90M });
            produtos.Add(new Produto { Id = 4, Nome = "Molho de Tomate Cepera", Categoria = "Condimentos", Preco = 2.99M });
            produtos.Add(new Produto { Id = 5, Nome = "Suco de Uva Aurora", Categoria = "Sucos", Preco = 6.50M });
        }

        public Produto Add(Produto item)
        {
            if (item == null)
                throw new ArgumentException("item null");

            item.Id = _nextId++;
            return item;
        }
        

        public Produto Get(int id)
        {
            return produtos.Find(p => p.Id == id);
        }

        public IEnumerable<Produto> GetAll()
        {
            return produtos;
        }

        public void Remove(int id)
        {
            produtos.RemoveAll(p => p.Id == id);
        }

        public bool Update(Produto item)
        {
            if (item == null)
                throw new ArgumentException("item null");

            int index = produtos.FindIndex(p => p.Id == item.Id);
            if (index == -1)
                return false;

            produtos.RemoveAt(index);
            produtos.Add(item);
            return true;
        }
    }
}
