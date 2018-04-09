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
    }
}
