using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ContaCorrente
    {
        private int _numeroConta;
        private string _nome ;
        private decimal _saldo;

        public int NumeroConta 
        { 
            get { return _numeroConta;}
            set { _numeroConta = value;}
        }
        public string Nome
        {
            get { return _nome;}
            set { _nome = value;}
        }
        public decimal Saldo
        {
            get { return _saldo;}
        }

        public void AlterarNome (string ANovoNome)
        {
           _nome = ANovoNome;
        }
        public void Deposito (decimal AnValor)
        {
            _saldo = _saldo + AnValor;
        }
        public void Saque (decimal AnValor)
        {
            _saldo = _saldo - AnValor;
        }

        public ContaCorrente(int ANumeroConta, string ANome, decimal ASaldo = 0)
        {
            this._numeroConta = ANumeroConta;
            this._nome = ANome;
            this._saldo = ASaldo;
        }
        
    }
}
