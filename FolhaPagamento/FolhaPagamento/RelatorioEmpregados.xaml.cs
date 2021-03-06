﻿using Controllers;
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
    /// Lógica interna para RelatorioEmpregados.xaml
    /// </summary>
    public partial class RelatorioEmpregados : Window
    {
        public RelatorioEmpregados()
        {
            InitializeComponent();
        }
        private void btnRelatEmpVoltar_Click(object sender, RoutedEventArgs e)
        {
            RelatorioGeral relat = new RelatorioGeral();
            relat.Show();
        }

        private void btnRelatEmpListar_Click(object sender, RoutedEventArgs e)
        {
            ListarEmpregados();           
        }

        private void ListarEmpregados()
        {
            lvEmpregado.ItemsSource = EmpregadoController.ListarEmpregados();
        }

       
    }
}
