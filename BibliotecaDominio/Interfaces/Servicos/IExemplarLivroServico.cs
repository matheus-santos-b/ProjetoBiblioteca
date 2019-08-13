﻿using BibliotecaDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDominio.Interfaces.Servicos
{
    public interface IExemplarLivroServico : IBibliotecaServicoBase<ExemplarLivro>
    {
        new bool Remover(ExemplarLivro exemplarLivro);
    }
}
