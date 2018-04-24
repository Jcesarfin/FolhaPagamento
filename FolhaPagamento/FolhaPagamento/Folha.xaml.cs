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
    /// Lógica interna para Salario.xaml
    /// </summary>
    public partial class Folha : Window
    {
        public Folha()
        {
            InitializeComponent();
        }

        private void btnVoltarMenu_Click(object sender, RoutedEventArgs e)
        {
            Cadastar cad = new Cadastar();
            cad.Show();
        }

        private void btnSalvarSalario_Click(object sender, RoutedEventArgs e)
        {
            SalvarSalario();
        }

        private void SalvarSalario()
        {
            EmpregadoController empC = new EmpregadoController();
            Empregado emp = empC.PesquisarPorCpf(txtFolhaCpf.Text);
            txtFolhaNome.Text = emp.Nome;
                        
            Salario sal = new Salario();

           
            sal.QtdeHoraNormal = Convert.ToInt32(txtFolhaQtHrNormal.Text);
            sal.QtdeHoraExtra = Convert.ToInt32(txtFolhaQtHrExtra.Text);
            sal.VlrHoraNormal = Convert.ToDecimal(txtFolhaVlrHrNormal.Text);
            sal.VlrHoraExtra = Convert.ToDecimal(txtFolhaVlrHrExtra.Text);
            sal.SalarioBruto = Convert.ToDecimal(txtFolhaVlrSalBruto.Text);
            sal.VlrInss = Convert.ToDecimal(txtFolhaVlrInss.Text);
            sal.VlrIR = Convert.ToDecimal(txtFolhaVlrIR.Text);
            sal.SalarioLiquido = Convert.ToDecimal(txtFolhaVlrSalLiq.Text);
            sal.Mes = Convert.ToInt32(txtFolhaMesRef.Text);
            sal.Ano = Convert.ToInt32(txtFolhaAnoRef.Text);

           
            sal.EmpregadoID = emp.EmpregadoID;

            SalarioController.SalvarSalario(sal);

            txtFolhaCpf.Text = (" ");
            txtFolhaNome.Text = (" ");
            txtFolhaQtHrNormal.Text = (" ");
            txtFolhaQtHrExtra.Text = (" ");
            txtFolhaVlrHrNormal.Text = (" ");
            txtFolhaVlrHrExtra.Text = (" ");
            txtFolhaVlrSalBruto.Text = (" ");
            txtFolhaVlrInss.Text = (" ");
            txtFolhaVlrIR.Text = (" ");
            txtFolhaVlrSalLiq.Text = (" ");
            txtFolhaMesRef.Text = (" ");
            txtFolhaAnoRef.Text = (" ");

        }

        private void btnPesquisaCpf_Click(object sender, RoutedEventArgs e)
        {
            
            EmpregadoController empC = new EmpregadoController();
            Empregado emp = empC.PesquisarPorCpf(txtFolhaCpf.Text);

        if (emp != null)
        {
            txtFolhaNome.Text = emp.Nome;
            }
            else
                MessageBox.Show("Cliente não encontrado");

        }



        
    
    }
}
