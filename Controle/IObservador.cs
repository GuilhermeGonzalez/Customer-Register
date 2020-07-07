using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proj_Aula_BD.Controle
{
    public interface IObservador
    {
        void notificar(string acao, params Object[] parametros);
    }
}
