﻿#pragma checksum "..\..\RelatorioDepto.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44158AD0ED9CD4D7F6D6D3C6D109130CAA8EAAAB"
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
    /// RelatorioDepto
    /// </summary>
    public partial class RelatorioDepto : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\RelatorioDepto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FolhaPagamento.RelatorioDepto telaRelatDepto;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\RelatorioDepto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\RelatorioDepto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblRelatNomeDepto;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\RelatorioDepto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblRelatLocalDepto;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\RelatorioDepto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRelatNomeDepto;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\RelatorioDepto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRelatLocalDepto;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\RelatorioDepto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVoltarRelatGeral;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\RelatorioDepto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btbRelatGerar;
        
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
            System.Uri resourceLocater = new System.Uri("/FolhaPagamento;component/relatoriodepto.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RelatorioDepto.xaml"
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
            this.telaRelatDepto = ((FolhaPagamento.RelatorioDepto)(target));
            return;
            case 2:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lblRelatNomeDepto = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lblRelatLocalDepto = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.txtRelatNomeDepto = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtRelatLocalDepto = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnVoltarRelatGeral = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\RelatorioDepto.xaml"
            this.btnVoltarRelatGeral.Click += new System.Windows.RoutedEventHandler(this.btnVoltarRelatGeral_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btbRelatGerar = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\RelatorioDepto.xaml"
            this.btbRelatGerar.Click += new System.Windows.RoutedEventHandler(this.btbRelatGerar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
