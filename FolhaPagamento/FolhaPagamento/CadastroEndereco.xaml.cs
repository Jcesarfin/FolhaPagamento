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
    /// Lógica interna para CadastroEndereco.xaml
    /// </summary>
    public partial class CadastroEndereco : Window
    {
        public CadastroEndereco()
        {
            InitializeComponent();
        }

        private void btnVoltarMenu_Click(object sender, RoutedEventArgs e)
        {
            Cadastar cad = new Cadastar();
            cad.ShowDialog();
        }

        private void btnSalvarEndereco_Click(object sender, RoutedEventArgs e)
        {
            SalvarEndereco();
        }

        private void SalvarEndereco()
        {
            Endereco end = new Endereco();

            end.Rua = txtEndRua.Text;
            end.Numero = Convert.ToInt16(txtEndNum.Text);
            end.Cep = Convert.ToInt16(txtEndCep.Text);
            end.Complemento = txtEndCompl.Text;

            EnderecoController.SalvarEndereco(end);

            
        }
    }
}
