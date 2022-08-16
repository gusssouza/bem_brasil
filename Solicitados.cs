using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace estrutura_herancas
{
    public class Solicitados : Produtos
    {
        public int codigoBeneficiario
        {
            get => default;
            set
            {
            }
        }

        public Doacoes Doacoes
        {
            get => default;
            set
            {
            }
        }

        public void CadastrarDoacaoSolicitada()
        {
            throw new System.NotImplementedException();
        }
    }
}