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
    /// Lógica interna para RelatorioGeral.xaml
    /// </summary>
    public partial class RelatorioGeral : Window
    {
        public RelatorioGeral()
        {
            InitializeComponent();
        }

        private void btbRelatEmpreg_Click(object sender, RoutedEventArgs e)
        {
            RelatorioEmpregados relat = new RelatorioEmpregados();
            relat.Show();
                
        }

        private void btbRelatFolha_Click(object sender, RoutedEventArgs e)
        {
            RelatorioFolha relat = new RelatorioFolha();
            relat.Show();
        }

        private void btbVoltarMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow cad = new MainWindow();
            cad.Show();
        }

        private void btbRelatDepto_Click(object sender, RoutedEventArgs e)
        {
            RelatorioDepto relat = new RelatorioDepto();
            relat.Show();
        }

        private void btbRelatCargos_Click(object sender, RoutedEventArgs e)
        {
            RelatorioCargo relat = new RelatorioCargo();
            relat.Show();
        }
    }
}
