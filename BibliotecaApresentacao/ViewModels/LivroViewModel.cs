﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BibliotecaApresentacao.ViewModels
{
    public class LivroViewModel
    {
        [Key]
        public int LivroId { get; set; }

        [Required(ErrorMessage = "Título é um campo obrigatório.")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres.")]
        public string Titulo { get;  set; }

        public int AutorId { get; set; }

        [Required(ErrorMessage = "Autor é um campo obrigatório.")]
        public virtual AutorViewModel Autor { get;  set; }

        public int EditoraId { get; set; }

        [Required(ErrorMessage = "Editora é um campo obrigatório.")]
        public virtual EditoraViewModel Editora { get;  set; }

        public int AssuntoId { get; set; }

        [Required(ErrorMessage = "Assunto é um campo obrigatório")]
        public virtual AssuntoViewModel Assunto { get;  set; }

        public int ClassificacaoId { get; set; }

        [Required(ErrorMessage = "Classificação é um campo obrigatório.")]
        public virtual ClassificacaoViewModel Classificacao { get;  set; }

        public int LocalizacaoId { get; set; }

        [Required(ErrorMessage = "Localização é um campo obrigatório.")]
        public virtual LocalizacaoViewModel Localizacao { get; set; }

        public virtual IEnumerable<ExemplarLivroViewModel> Exemplares { get;  set; }
    }
}