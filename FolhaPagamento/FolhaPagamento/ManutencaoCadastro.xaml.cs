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
    /// Lógica interna para ConsultaCadastro.xaml
    /// </summary>
    public partial class ManutencaoCadastro : Window
    {
        public ManutencaoCadastro()
        {
            InitializeComponent();
        }

        private void btnVoltarManutGeral_Click(object sender, RoutedEventArgs e)
        {
            ManutencaoGeral manut = new ManutencaoGeral();
            manut.Show();
        }

        private void btnVoltarMenuPrinc_Click(object sender, RoutedEventArgs e)
        {
            Cadastar cad = new Cadastar();
            cad.Show();
        }

        private void btnPesqEmpCpf_Click(object sender, RoutedEventArgs e)
        {
            EmpregadoController empC = new EmpregadoController();
            Empregado emp = empC.PesquisarPorCpf(txtConsEmpCpf.Text);

            if (emp != null)
            {                      

            txtConsNomeEmp.Text = emp.Nome;
            txtConsIdentEmp.Text = emp.Identidade;
            txtConsCpfEmp.Text = emp.CPF;
            txtConsDtNascEmp.Text = Convert.ToString(emp.DataNascimento);
            txtConsDtAdmEmp.Text = Convert.ToString(emp.DataAdmissão);
            txtConsDtDemEmp.Text = Convert.ToString(emp.DataDemissão);
            txtConsDeptoEmp.Text = emp.Departamento;
            txtConsCargoEmp.Text = emp.Cargo;

            txtConsRuaEmp.Text = emp._Endereco.Rua;
            txtConsNumEmp.Text = Convert.ToString(emp._Endereco.Numero);
            txtConsCepEmp.Text = Convert.ToString(emp._Endereco.Cep);
            txtConsComplEmp.Text = emp._Endereco.Complemento;

            }
            else
                MessageBox.Show("Cliente não encontrado");
        }

        private void btnManutEditar_Click(object sender, RoutedEventArgs e)
        {
            EmpregadoController empC = new EmpregadoController();
            Empregado emp = empC.PesquisarPorCpf(txtConsEmpCpf.Text);            
            
            Empregado novoEmp = new Empregado();
            novoEmp.EmpregadoID = emp.EmpregadoID;
            novoEmp._Endereco = new Endereco();

            
            novoEmp.Nome = txtConsNomeEmp.Text;
            novoEmp.Identidade = txtConsIdentEmp.Text;
            novoEmp.CPF = txtConsCpfEmp.Text;
            novoEmp.DataNascimento = Convert.ToDateTime(txtConsDtNascEmp.Text);
            novoEmp.DataAdmissão = Convert.ToDateTime(txtConsDtAdmEmp.Text);
            novoEmp.DataDemissão = Convert.ToDateTime(txtConsDtDemEmp.Text);
            novoEmp.Departamento = txtConsDeptoEmp.Text;
            novoEmp.Cargo = txtConsCargoEmp.Text;

           
            novoEmp._Endereco.Rua = txtConsRuaEmp.Text;
            novoEmp._Endereco.Numero = Convert.ToInt32(txtConsNumEmp.Text);
            novoEmp._Endereco.Cep = Convert.ToInt32(txtConsCepEmp.Text);
            novoEmp._Endereco.Complemento = txtConsComplEmp.Text;


            novoEmp.EnderecoID = novoEmp.EmpregadoID;

            EmpregadoController.EditarEmpregado(novoEmp.EmpregadoID, novoEmp, novoEmp._Endereco);

            txtConsEmpCpf.Text = (" ");
            txtConsNomeEmp.Text = (" ");
            txtConsIdentEmp.Text = (" ");
            txtConsCpfEmp.Text = (" ");
            txtConsDtNascEmp.Text = (" ");
            txtConsDtAdmEmp.Text = (" ");
            txtConsDtDemEmp.Text = (" ");
            txtConsDeptoEmp.Text = (" ");
            txtConsCargoEmp.Text = (" ");
            txtConsRuaEmp.Text = (" ");
            txtConsNumEmp.Text = (" ");
            txtConsCepEmp.Text = (" ");
            txtConsComplEmp.Text = (" ");

        }

        private void btbManutExcluir_Click(object sender, RoutedEventArgs e)
        {
            EmpregadoController empC = new EmpregadoController();
            Empregado emp = empC.PesquisarPorCpf(txtConsEmpCpf.Text);

            Empregado em = new Empregado();
            em.EmpregadoID = emp.EmpregadoID;
           
            Endereco end = new Endereco();
            end.EnderecoID = emp.EmpregadoID;

            EmpregadoController.ExcluirEmpregado(em.EmpregadoID);
            EnderecoController.ExcluirEndereco(end.EnderecoID);

            txtConsEmpCpf.Text = (" ");
            txtConsNomeEmp.Text = (" ");
            txtConsIdentEmp.Text = (" ");
            txtConsCpfEmp.Text = (" ");
            txtConsDtNascEmp.Text = (" ");
            txtConsDtAdmEmp.Text = (" ");
            txtConsDtDemEmp.Text = (" ");
            txtConsDeptoEmp.Text = (" ");
            txtConsCargoEmp.Text = (" ");
            txtConsRuaEmp.Text = (" ");
            txtConsNumEmp.Text = (" ");
            txtConsCepEmp.Text = (" ");
            txtConsComplEmp.Text = (" ");

        }
    }
}
