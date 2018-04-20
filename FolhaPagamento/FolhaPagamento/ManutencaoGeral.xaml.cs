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
    /// Lógica interna para ConsultaGeral.xaml
    /// </summary>
    public partial class ManutencaoGeral : Window
    {
        public ManutencaoGeral()
        {
            InitializeComponent();
        }

        private void btnManutCadastro_Click(object sender, RoutedEventArgs e)
        {
            ManutencaoCadastro manut = new ManutencaoCadastro();
            manut.Show();
        }

        private void btnManutFolha_Click(object sender, RoutedEventArgs e)
        {
            ManutencaoFolha manut = new ManutencaoFolha();
            manut.Show();
        }

        private void btnVoltarMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow cad = new MainWindow();
            cad.Show();
        }
    }
}
