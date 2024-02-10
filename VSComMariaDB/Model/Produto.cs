using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace VSComMariaDB.Model
{
    public class Produto
    {
        
        public int Id { get; set; }


        [MaxLength(100)]
        public string Nome { get; set; }


        [MaxLength(150)]
        public string Descricao { get; set;}


        public decimal Preco { get; set;}

        public bool Disponivel { get; set;}

        public bool Novidade { get; set; }



        [MaxLength(200)]
        public string Imagem { get; set; }





    }
}
