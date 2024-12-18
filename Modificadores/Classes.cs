using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores
{
    class Teste
    {
        public string nome;
        public string sobrenome;

        public void Executar()
        {

        }
        public void Metodo1()
        {

        }
    }
    class Humano
    {
        protected string nome; // quase a mesma coisa que private mas ele deixa seus objetos serem instanciados
        private string sobrenome; // ele priva totalmente para a classe e não deixa seus objetos serem instanciados
        internal int idade; // ele priva para o mesmo assembly/projeto, em DLLS por exemplo, esse modificador não daria acesso a objetos instanciados
    }
    class Homem: Humano
    {
        public void Metodo()
        {
            nome = "";
        }
    }
}
