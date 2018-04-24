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
    /// Lógica interna para RelatorioCargo.xaml
    /// </summary>
    public partial class RelatorioCargo : Window
    {
        public RelatorioCargo()
        {
            InitializeComponent();
        }

        private void btbVoltarRelat_Click(object sender, RoutedEventArgs e)
        {
            RelatorioGeral relat = new RelatorioGeral();
            relat.Show();
        }

        private void btnGerarRelatCargo_Click(object sender, RoutedEventArgs e)
        {
            ListarCargos();
        }

        private void ListarCargos()
        {
            
            lvCargos.ItemsSource = CargoController.ListarCargos();
           
                      
        }

    }

}
