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
    /// Lógica interna para ConsultaFolha.xaml
    /// </summary>
    public partial class ManutencaoFolha : Window
    {
        public ManutencaoFolha()
        {
            InitializeComponent();
        }

        private void btnVoltarMenuPrinc_Click(object sender, RoutedEventArgs e)
        {

            MainWindow cad = new MainWindow();
            cad.ShowDialog();
        }

        private void btnVoltarMenuManut_Click(object sender, RoutedEventArgs e)
        {
            ManutencaoGeral manut = new ManutencaoGeral();
            manut.ShowDialog();
        }
    }
}
