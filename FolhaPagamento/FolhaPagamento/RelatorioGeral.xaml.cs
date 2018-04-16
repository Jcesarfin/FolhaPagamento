﻿using System;
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
            relat.ShowDialog();
                
        }

        private void btbRelatFolha_Click(object sender, RoutedEventArgs e)
        {
            RelatorioFolha relat = new RelatorioFolha();
            relat.ShowDialog();
        }

        private void btbVoltarMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow cad = new MainWindow();
            cad.ShowDialog();
        }

        private void btbRelatDepto_Click(object sender, RoutedEventArgs e)
        {
            RelatorioDepto relat = new RelatorioDepto();
            relat.ShowDialog();
        }

        private void btbRelatCargos_Click(object sender, RoutedEventArgs e)
        {
            RelatorioCargo relat = new RelatorioCargo();
            relat.ShowDialog();
        }
    }
}
