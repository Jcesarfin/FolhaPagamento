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
            cad.Show();
        }

        private void btnVoltarMenuManut_Click(object sender, RoutedEventArgs e)
        {
            ManutencaoGeral manut = new ManutencaoGeral();
            manut.Show();
        }

        private void btnConsFolhaCpf_Click(object sender, RoutedEventArgs e)
        {
            SalarioController salC = new SalarioController();
            Salario sal = salC.PesquisarPorCpfMesAno(txtManutFolhaCpf.Text);

            txtManutNomeFolha.Text = sal._Empregado.Nome;
            txtManutQtHrNormal.Text = Convert.ToString(sal.QtdeHoraNormal);
            txtManutQtHrExtra.Text = Convert.ToString(sal.QtdeHoraExtra);
            txtManutVlrHrNormal.Text = Convert.ToString(sal.VlrHoraNormal);
            txtManutVlrHrExtra.Text = Convert.ToString(sal.VlrHoraExtra);
            txtManutSalBrFolha.Text = Convert.ToString(sal.SalarioBruto);
            txtManutInssFolha.Text = Convert.ToString(sal.VlrInss);
            txtManutIrFolha.Text = Convert.ToString(sal.VlrIR);
            txtManutVlrLiqFolha.Text = Convert.ToString(sal.SalarioLiquido);
            txtManutMesFolha.Text = Convert.ToString(sal.Mes);
            txtManutAnoFolha.Text = Convert.ToString(sal.Ano);
        }
    }
}
