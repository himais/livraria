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
    using System.ComponentModel.DataAnnotations;
    
    public partial class Genero
    {
        public Genero()
        {
            this.Livro = new HashSet<Livro>();
        }
    
        public int IdGenero { get; set; }

        [Required(ErrorMessage = "Insira o nome do g�nero!", AllowEmptyStrings = false)]
        public string NomeGenero { get; set; }
    
        public virtual ICollection<Livro> Livro { get; set; }
    }
}
