using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestao_de_Clientes.Models
{
    [Table("Cliente")]
    public class ClienteModel
    {
        [Key]
        public int Id { get; set; }
        [Column("Codigo")]
        public string Codigo { get; set; }
        [Required]
        [Column("NomeAbrevido_Fantasia")]
        public string NomeFantasia { get; set; }
        [Column("Nome_RazaoSocial")]
        public string NomeRazaoSocial { get; set; }
        [Required]
        [Column("CPF_CNPJ")]
        public string CPFCNPJ { get; set; }
        [Column("RG_IE")]
        public string RGIE { get; set; }
        [Column("Tipo")]
        public string Tipo { get; set; } // Pode ser melhorado usando uma enumeração para PF/PJ
        [Required]
        [Column("Cep")]
        public string CEP { get; set; }
        [Column("Logradouro")]
        public string Logradouro { get; set; }
        [Column("Numero")]
        public string Numero { get; set; }
        [Column("Complemento")]
        public string Complemento { get; set; }
        [Column("Bairro")]
        public string Bairro { get; set; }
        [Column("Municipio")]
        public string Municipio { get; set; }
        [Column("Unidade_Federativa")]
        public string UnidadeFederativa { get; set; }
        [Column("Email")]
        public string Email { get; set; }
        [Column("Telefone")]
        public string Telefone { get; set; }

        [Column("Data_Inclusao")]
        public DateTime Inclusao { get; set; }
        [Column("Data_Alteracao")]
        public DateTime Alteracao { get; set; }

    }
}
