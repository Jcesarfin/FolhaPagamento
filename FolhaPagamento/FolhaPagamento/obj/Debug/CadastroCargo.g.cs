﻿#pragma checksum "..\..\CadastroCargo.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FEEC2F63F8070C693E1A8F464908C237EB4C3B20"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using FolhaPagamento;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace FolhaPagamento {
    
    
    /// <summary>
    /// CadastroCargo
    /// </summary>
    public partial class CadastroCargo : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\CadastroCargo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FolhaPagamento.CadastroCargo telaCadCargo;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\CadastroCargo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTituloCadCargo;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\CadastroCargo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblNomeCargo;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\CadastroCargo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNomeCargo;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\CadastroCargo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtVlrHora;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\CadastroCargo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSalvarCadCargo;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\CadastroCargo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVoltarMenu;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\CadastroCargo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblVlrHora;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FolhaPagamento;component/cadastrocargo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CadastroCargo.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.telaCadCargo = ((FolhaPagamento.CadastroCargo)(target));
            return;
            case 2:
            this.lblTituloCadCargo = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lblNomeCargo = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.txtNomeCargo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtVlrHora = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnSalvarCadCargo = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\CadastroCargo.xaml"
            this.btnSalvarCadCargo.Click += new System.Windows.RoutedEventHandler(this.btnSalvarCadCargo_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnVoltarMenu = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\CadastroCargo.xaml"
            this.btnVoltarMenu.Click += new System.Windows.RoutedEventHandler(this.btnVoltarMenu_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lblVlrHora = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

