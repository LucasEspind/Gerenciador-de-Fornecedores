using Sistema_de_Cadastro_de_Fornecedor.Enumerator;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema_de_Cadastro_de_Fornecedor.Models
{
    [Table("Fornecedores")]
    public class FornecedoresModel
    {
        [Key, Column("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage ="O nome deve ter no mínimo 2 caracteres e no máximo 100!"), MaxLength(100), MinLength(2), Column("Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="O Cnpj deve ter 14 caracteres!"), MaxLength(14), MinLength(14), Column("CNPJ")]
        public string CNPJ { get; set; }

        [Column("Especializacao"), Required(ErrorMessage = "Especifique a Especialização do fornecedor!")]
        public EspecializacaoEnum Especializacao { get; set; }

        [Required(ErrorMessage = "O Cep deve ter 8 caracteres!"), MaxLength(8), MinLength(8), Column("CEP")]
        public string CEP { get; set; }

        [Required, MaxLength(255), Column("Endereco")]
        public string Endereco{ get; set; }
    }
}