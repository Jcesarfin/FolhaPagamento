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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FolhaPagamento
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCadastros_Click(object sender, RoutedEventArgs e)
        {
            Cadastar cad = new Cadastar();
            cad.Show();

        }

        private void btnManutencao_Click(object sender, RoutedEventArgs e)
        {
            ManutencaoGeral manut = new ManutencaoGeral();
            manut.Show();
        }

        private void btnRelatorios_Click(object sender, RoutedEventArgs e)
        {
            RelatorioGeral relat = new RelatorioGeral();
            relat.Show();
        }
    }
}
