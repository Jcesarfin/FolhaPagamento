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

            if (sal != null)
            {

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
            else
                MessageBox.Show("Cliente não encontrado");

        }

        private void btnFolhaEditar_Click(object sender, RoutedEventArgs e)
        {
            SalarioController salC = new SalarioController();
            Salario sal = salC.PesquisarPorCpfMesAno(txtManutFolhaCpf.Text);

            Salario novoSalario = new Salario();
            novoSalario.SalarioID = sal.SalarioID;

            novoSalario.QtdeHoraNormal = Convert.ToInt32(txtManutQtHrNormal.Text);
            novoSalario.QtdeHoraExtra = Convert.ToInt32(txtManutQtHrExtra.Text);
            novoSalario.VlrHoraNormal = Convert.ToDecimal(txtManutVlrHrNormal.Text);
            novoSalario.VlrHoraExtra = Convert.ToDecimal(txtManutVlrHrExtra.Text);
            novoSalario.SalarioBruto = Convert.ToDecimal(txtManutSalBrFolha.Text);
            novoSalario.VlrInss = Convert.ToDecimal(txtManutInssFolha.Text);
            novoSalario.VlrIR = Convert.ToDecimal(txtManutIrFolha.Text);
            novoSalario.SalarioLiquido = Convert.ToDecimal(txtManutVlrLiqFolha.Text);
            novoSalario.Mes = Convert.ToInt32(txtManutMesFolha.Text);
            novoSalario.Ano = Convert.ToInt32(txtManutAnoFolha.Text);

            
            SalarioController.EditarSalario(novoSalario.SalarioID, novoSalario);

            txtManutFolhaCpf.Text = (" ");
            txtManutNomeFolha.Text = (" ");
            txtManutQtHrNormal.Text = (" ");
            txtManutQtHrExtra.Text = (" ");
            txtManutVlrHrNormal.Text = (" ");
            txtManutVlrHrExtra.Text = (" ");
            txtManutSalBrFolha.Text = (" ");
            txtManutInssFolha.Text = (" ");
            txtManutIrFolha.Text = (" ");
            txtManutVlrLiqFolha.Text = (" ");
            txtManutMesFolha.Text = (" ");
            txtManutAnoFolha.Text = (" ");



        }

        private void btnFolhaExcluir_Click(object sender, RoutedEventArgs e)
        {
            SalarioController salC = new SalarioController();
            Salario sal = salC.PesquisarPorCpfMesAno(txtManutFolhaCpf.Text);

            Salario s = new Salario();
            s.SalarioID = sal.SalarioID;

            SalarioController.ExcluirSalario(s.SalarioID);

            txtManutFolhaCpf.Text = (" ");
            txtManutNomeFolha.Text = (" ");
            txtManutQtHrNormal.Text = (" ");
            txtManutQtHrExtra.Text = (" ");
            txtManutVlrHrNormal.Text = (" ");
            txtManutVlrHrExtra.Text = (" ");
            txtManutSalBrFolha.Text = (" ");
            txtManutInssFolha.Text = (" ");
            txtManutIrFolha.Text = (" ");
            txtManutVlrLiqFolha.Text = (" ");
            txtManutMesFolha.Text = (" ");
            txtManutAnoFolha.Text = (" ");

        }
    }
}
