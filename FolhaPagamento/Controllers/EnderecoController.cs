using Models;
using Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class EnderecoController
    {
        // INSERT

        public static void SalvarEndereco(Endereco endereco)
        {
            MeuContexto bancoDados = new MeuContexto();

            bancoDados.Enderecos.Add(endereco);
            bancoDados.SaveChanges();
        }

        // SELECT *

        public static List<Endereco> ListarEnderecos()
        {
            MeuContexto bancoDados = new MeuContexto();
            return bancoDados.Enderecos.ToList();
        }

        // SELECT BY ID

        public static Endereco PesquisarPorID(int id)
        {
            MeuContexto bancoDados = new MeuContexto();
            return bancoDados.Enderecos.Find(id);
        }

        // EDIT

        public static void EditarEndereco(int id, Endereco novoEndereco)
        {
            MeuContexto bancoDados = new MeuContexto();
            Endereco enderecoAtual = bancoDados.Enderecos.Find(id);

            enderecoAtual.Rua = novoEndereco.Rua;
            enderecoAtual.Numero = novoEndereco.Numero;
            enderecoAtual.Cep = novoEndereco.Cep;
            enderecoAtual.Complemento = novoEndereco.Complemento;       

            bancoDados.Entry(enderecoAtual).State = System.Data.Entity.EntityState.Modified;
            bancoDados.SaveChanges();

        }

        // DELETE

        public static void ExcluirEndereco(int id)
        {
            MeuContexto bancoDados = new MeuContexto();
            Endereco enderecoAtual = bancoDados.Enderecos.Find(id);

            bancoDados.Entry(enderecoAtual).State = System.Data.Entity.EntityState.Deleted;
            bancoDados.SaveChanges();

        }



    }
}
