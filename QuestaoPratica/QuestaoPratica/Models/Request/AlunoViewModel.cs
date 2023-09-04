using System.ComponentModel.DataAnnotations;

namespace QuestaoPratica.Models.Request
{
    public class AlunoViewModel
    {
        public int Codigo { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo RA é obrigatório.")]
        [RegularExpression(@"^RA\d{6}$", ErrorMessage = "O campo RA deve começar com as letras 'RA' seguidas de 6 dígitos.")]
        public int Ra { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "O campo Email deve ser um endereço de email válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo CPF é obrigatório.")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "O campo CPF deve conter 11 dígitos numéricos.")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "O campo Ativo é obrigatório.")]
        public bool Ativo { get; set; }
    }
}
