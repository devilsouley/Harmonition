﻿#pragma checksum "..\..\Connexion.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3E3C2840364A3B8C5B73438B0CB0A831"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.34209
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace Harmonition {
    
    
    /// <summary>
    /// Connexion
    /// </summary>
    public partial class Connexion : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\Connexion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtPassword;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Connexion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnConnect;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Connexion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\Connexion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNewUser;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\Connexion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock btnRecupererCompte;
        
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
            System.Uri resourceLocater = new System.Uri("/Harmonition;component/connexion.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Connexion.xaml"
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
            this.txtPassword = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 38 "..\..\Connexion.xaml"
            this.txtPassword.GotFocus += new System.Windows.RoutedEventHandler(this.txtPassword_GotFocus);
            
            #line default
            #line hidden
            
            #line 38 "..\..\Connexion.xaml"
            this.txtPassword.LostFocus += new System.Windows.RoutedEventHandler(this.txtPassword_LostFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnConnect = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\Connexion.xaml"
            this.btnConnect.Click += new System.Windows.RoutedEventHandler(this.btnConnect_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\Connexion.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.btnCancel_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnNewUser = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\Connexion.xaml"
            this.btnNewUser.Click += new System.Windows.RoutedEventHandler(this.btnNewUser_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnRecupererCompte = ((System.Windows.Controls.TextBlock)(target));
            
            #line 48 "..\..\Connexion.xaml"
            this.btnRecupererCompte.MouseEnter += new System.Windows.Input.MouseEventHandler(this.btnRecupererCompte_MouseEnter);
            
            #line default
            #line hidden
            
            #line 48 "..\..\Connexion.xaml"
            this.btnRecupererCompte.MouseLeave += new System.Windows.Input.MouseEventHandler(this.btnRecupererCompte_MouseLeave);
            
            #line default
            #line hidden
            
            #line 48 "..\..\Connexion.xaml"
            this.btnRecupererCompte.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.btnRecupererCompte_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

