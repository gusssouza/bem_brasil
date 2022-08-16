using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace estrutura_herancas
{
    public class Ofertados : Produtos
    {
        public int codigoBeneficente
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

        public void CadastrarDoacaoOfertada()
        {
            throw new System.NotImplementedException();
        }
    }
}