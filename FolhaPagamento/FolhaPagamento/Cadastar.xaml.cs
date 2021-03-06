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
    /// Lógica interna para Cadastar.xaml
    /// </summary>
    public partial class Cadastar : Window
    {
        public Cadastar()
        {
            InitializeComponent();
        }

        private void btnCadastrarDepto_Click(object sender, RoutedEventArgs e)
        {
            CadastroDepartamento cad = new CadastroDepartamento();
            cad.ShowDialog();
        }

        private void btnCadastrarCargos_Click(object sender, RoutedEventArgs e)
        {
            CadastroCargo cad = new CadastroCargo();
            cad.ShowDialog();
        }

        private void btnCadastrarEmpregado_Click(object sender, RoutedEventArgs e)
        {
            CadastroEmpregado cad = new CadastroEmpregado();
            cad.ShowDialog();
        }

       

        private void btnFolha_Click(object sender, RoutedEventArgs e)
        {
            Folha folha = new Folha();
            folha.ShowDialog();
        }

        private void btnVoltarMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.ShowDialog();
        }

        
    }
}
