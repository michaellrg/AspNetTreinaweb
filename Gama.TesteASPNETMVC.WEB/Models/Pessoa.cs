using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gama.TesteASPNETMVC.WEB.Models
{
    public class Pessoa
    {
        //Referencia se é requirido ou não e o erro que será exibido
        [Required (ErrorMessage ="O nome é obrigatório")]
        //Mostra o nome que será exibido na label
        [DisplayName("Nome:")]
        //Referencia o mínimo de caracteres aceito
        [MinLength(5,ErrorMessage ="Nome com no mínimo 5 caracteres")]
        //Referencia o máximo de caracteres aceito
        [MaxLength (50, ErrorMessage ="Nome com no máximo 50 caracteres")]
        public string Nome { get; set; }

        //Mostra o nome que será exibido na label
        [DisplayName("Idade:")]
        public int idade { get; set; }


        //Referencia se é requirido ou não e o erro que será exibido
        [Required(ErrorMessage = "O endereço é obrigatório")]
        //Mostra o nome que será exibido na label
        [DisplayName("Endereço:")]
        //Referencia o máximo de caracteres aceito
        [MaxLength(100, ErrorMessage = "Endereco com no máximo 100 caracteres")]
        public string Endereco { get; set; }

        //Referencia se é requirido ou não e o erro que será exibido
        [Required(ErrorMessage = "O email é obrigatório")]
        //Mostra o nome que será exibido na label
        [DisplayName("Email:")]
        //Referencia o máximo de caracteres aceito
        [MaxLength(20, ErrorMessage = "Email com no máximo 20 caracteres")]
        //Valida se o tipo de campo digitado é mesmo email
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public bool Ativo { get; set; }
    }
}