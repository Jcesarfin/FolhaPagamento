using Controllers;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FolhaPagamento
{
    /// <summary>
    /// Lógica interna para CadastroEmpregado.xaml
    /// </summary>
    public partial class CadastroEmpregado : Window
    {
        public CadastroEmpregado()
        {
            InitializeComponent();
        }

        private void btnVoltarMenuCadastro_Click(object sender, RoutedEventArgs e)
        {
            Cadastar cad = new Cadastar();
            cad.ShowDialog();
        }

        private void btnMigrarCadEndereco_Click(object sender, RoutedEventArgs e)
        {
            CadastroEndereco cad = new CadastroEndereco();
            cad.ShowDialog();
        }

        private void btnSalvarCadEmpregado_Click(object sender, RoutedEventArgs e)
        {
            SalvarEmpregado();
        }

        private void SalvarEmpregado()
        {
            Empregado emp = new Empregado();

            emp.Nome = txtEmprNome.Text;
            emp.Identidade = txtEmprIdent.Text;
            emp.CPF = txtEmprCpf.Text;
            emp.Sexo = txtEmpSexo.Text;
            //emp.DataNascimento = Convert.ToDateTime(txtEmprNasc.Text);
            //emp.DataAdmissão = Convert.ToDateTime(txtEmprAdm.Text);
            //emp.DataDemissão = Convert.ToDateTime(txtEmprDemi.Text);
            emp.Departamento = txtEmpDepto.Text;
            emp.Cargo = txtEmpCargo.Text;

           // Problema da Exceção pode estar no relacionamento com o Endereco!!!!            
            //Endereco end = SalvarEndereco(); ////igual ao console mas dá erro qdo altera de void para static ....
            //emp.EnderecoID = end.EnderecoID;


            EmpregadoController.SalvarEmpregado(emp);
            
        }
        

    }
}
