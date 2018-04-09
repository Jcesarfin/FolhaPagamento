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
            manut.ShowDialog();
        }

        private void btnVoltarMenuPrinc_Click(object sender, RoutedEventArgs e)
        {
            Cadastar cad = new Cadastar();
            cad.ShowDialog();
        }
    }
}
