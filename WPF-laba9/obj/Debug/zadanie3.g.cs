﻿#pragma checksum "..\..\zadanie3.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "43149D4C9C6C99F29147B7B411586BDADBA883AAD79664950DBA0DD8FAF12019"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WPF_laba9;


namespace WPF_laba9 {
    
    
    /// <summary>
    /// zadanie3
    /// </summary>
    public partial class zadanie3 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\zadanie3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox digit;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\zadanie3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton binary;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\zadanie3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton octagonal;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\zadanie3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock res;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\zadanie3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button сalculate;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\zadanie3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button reset;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\zadanie3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exit;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\zadanie3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF-laba9;component/zadanie3.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\zadanie3.xaml"
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
            this.digit = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.binary = ((System.Windows.Controls.RadioButton)(target));
            
            #line 21 "..\..\zadanie3.xaml"
            this.binary.Checked += new System.Windows.RoutedEventHandler(this.Binary);
            
            #line default
            #line hidden
            return;
            case 3:
            this.octagonal = ((System.Windows.Controls.RadioButton)(target));
            
            #line 22 "..\..\zadanie3.xaml"
            this.octagonal.Checked += new System.Windows.RoutedEventHandler(this.Octagonal);
            
            #line default
            #line hidden
            return;
            case 4:
            this.res = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.сalculate = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\zadanie3.xaml"
            this.сalculate.Click += new System.Windows.RoutedEventHandler(this.Calculate);
            
            #line default
            #line hidden
            return;
            case 6:
            this.reset = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\zadanie3.xaml"
            this.reset.Click += new System.Windows.RoutedEventHandler(this.Reset);
            
            #line default
            #line hidden
            return;
            case 7:
            this.exit = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\zadanie3.xaml"
            this.exit.Click += new System.Windows.RoutedEventHandler(this.Exit);
            
            #line default
            #line hidden
            return;
            case 8:
            this.back = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\zadanie3.xaml"
            this.back.Click += new System.Windows.RoutedEventHandler(this.Back);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

