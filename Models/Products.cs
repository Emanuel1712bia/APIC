using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class product
    {
        [Key]

        public int Id { get; set; }

    [Required(ErrorMessage ="Este Campo é Obrigatrio")]
    [MaxLength(60, ErrorMessage ="Este campo deve conter entre 3 e 60 caracteres")]
    [MinLength(3, ErrorMessage ="Este campo deve conter entre 3 e 60 caracteres")]
    
    public string Title { get; set; }

    [MaxLength(1024, ErrorMessage ="Este campo deve conter no máximo 1024 caracteres")]

    public string Description { get; set; }

    [Required(ErrorMessage ="Este Campo é Obrigatrio")]
    [Range(1, int.MaxValue, ErrorMessage = "O preço deve ser maior de zero")]

    public decimal price { get; set; }
    [Required(ErrorMessage ="Este Campo é Obrigatrio")]
    [Range(1, int.MaxValue, ErrorMessage = "Categoria Inválida")]

    public int CategoryId { get; set; }

    public Category Category { get; set; }

    }
}