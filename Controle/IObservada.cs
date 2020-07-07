using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proj_Aula_BD.Controle
{
    public interface IObservada
    {
        void adicionarObservadores(IObservador observador);// Permita que observadores sejam cadastrados
        void notificarObservadores();//Quando houver alteracao em meu estado, irei notificar quem esta me observando

    }
}
