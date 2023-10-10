using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace projeto_final_bloco_02.Model
{
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(255)]
        public string Nome { get; set; } = string.Empty;

        [Column(TypeName = "varchar")]
        [StringLength(510)]
        public string Descricao { get; set; } = string.Empty;

        [Column(TypeName = "int")]
        public int quantidade { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public decimal Preco { get; set; }
    }
}
