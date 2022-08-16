using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace estrutura_herancas
{
    public class Doador : Beneficente
    {
        public DoadorEEntregador DoadorEEntregador
        {
            get => default;
            set
            {
            }
        }

        public int codigoDoador
        {
            get => default;
            set
            {
            }
        }

        public void CadastrarDoador()
        {
            throw new System.NotImplementedException();
        }
    }

    public class CopyOfDoador
    {
    }
}