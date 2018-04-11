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
            cad.ShowDialog();
        }

        private void btnSalvarSalario_Click(object sender, RoutedEventArgs e)
        {
            SalvarSalario();
        }

        private void SalvarSalario()
        {
            Salario sal = new Salario();
            sal._Empregado.CPF = txtFolhaCpf.Text;
            sal._Empregado.Nome = txtFolhaNome.Text;
            sal.QtdeHoraNormal = Convert.ToInt16(txtFolhaQtHrNormal.Text);
            sal.QtdeHoraExtra = Convert.ToInt16(txtFolhaQtHrExtra.Text);
            sal.VlrHoraNormal = Convert.ToInt16(txtFolhaVlrHrNormal.Text);
            sal.VlrHoraExtra = Convert.ToInt16(txtFolhaVlrHrExtra.Text);
            sal.SalarioBruto = Convert.ToInt16(txtFolhaVlrSalBruto.Text);
            sal.VlrInss = Convert.ToInt16(txtFolhaVlrInss.Text);
            sal.VlrIR = Convert.ToInt16(txtFolhaVlrIR.Text);
            sal.SalarioLiquido = Convert.ToInt16(txtFolhaVlrSalLiq);
            sal.Mes = Convert.ToInt16(txtFolhaMesRef.Text);
            sal.Ano = Convert.ToInt16(txtFolhaAnoRef.Text);


            SalarioController.SalvarSalario(sal);

        }
    }
}
