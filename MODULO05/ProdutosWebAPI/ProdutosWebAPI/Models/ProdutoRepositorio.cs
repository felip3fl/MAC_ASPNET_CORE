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
            Add(new Produto { Nome = "Refrigerante", Categoria = "Bebida", Preco = 99.99M });
            Add(new Produto { Nome = "Café", Categoria = "Bebida", Preco = 11.99M });
            Add(new Produto { Nome = "Bolacha", Categoria = "Alimento", Preco = 10.99M });
            Add(new Produto { Nome = "Celular", Categoria = "Objeto", Preco = 2100.99M });
            Add(new Produto { Nome = "Copo", Categoria = "Objeto", Preco = 19.99M });
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
