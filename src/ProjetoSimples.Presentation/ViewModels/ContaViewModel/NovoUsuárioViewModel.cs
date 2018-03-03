﻿using System.ComponentModel.DataAnnotations;

namespace ProjetoSimples.Presentation.ViewModels.ContaViewModel
{
    public class NovoUsuárioViewModel
    {
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O nome é obrigatório")]
        [MaxLength(30, ErrorMessage = "O nome não pode conter mais de 30 caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "A senha é obrigatória")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "A senha deve possuir entre 3 e 20 caracteres")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
