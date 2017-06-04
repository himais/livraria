//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Livraria.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Livro
    {
        public Livro()
        {
            this.Item_Venda = new HashSet<Item_Venda>();
            this.Autor = new HashSet<Autor>();
        }
    
        public int IdLivro { get; set; }
        public int IdGenero { get; set; }
        public int IdAutor { get; set; }
        public string NomeLivro { get; set; }
        public int Ano { get; set; }
        public string Descricao { get; set; }
        public int Paginas { get; set; }
        public int IdEditora { get; set; }
        public string Isbn { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeEstoque { get; set; }
    
        public virtual Genero Genero { get; set; }
        public virtual Editora Editora { get; set; }
        public virtual ICollection<Item_Venda> Item_Venda { get; set; }
        public virtual ICollection<Autor> Autor { get; set; }
    }
}
