using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    internal class DCategoria
    {
        private int _Idcategoria;
        private string _Nome;
        private string _Descricao;
        private string _Textobuscar;

        public int Idcategoria { get => _Idcategoria; set => _Idcategoria = value; }
        public string Nome { get => _Nome; set => _Nome = value; }
        public string Descricao { get => _Descricao; set => _Descricao = value; }
        public string Textobuscar { get => _Textobuscar; set => _Textobuscar = value; }


        //Construtor Vazio

        public DCategoria()
        {

        }

        // Construtor com Paramêtros

        public DCategoria(int idcategoria, string nome, string descricao, string textobuscar)
        {
            this.Idcategoria = idcategoria;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Textobuscar = textobuscar;

        }
    }
}
