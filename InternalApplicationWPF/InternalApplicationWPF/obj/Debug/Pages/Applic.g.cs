﻿#pragma checksum "..\..\..\Pages\Applic.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AFA6C2EF22A3D570E46815F09258BF9A9D2E85D8803995D37CD431DF9EBEAB0D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using InternalApplicationWPF.Pages;
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


namespace InternalApplicationWPF.Pages {
    
    
    /// <summary>
    /// Applic
    /// </summary>
    public partial class Applic : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 44 "..\..\..\Pages\Applic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dg;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Pages\Applic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnWord;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Pages\Applic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnExcel;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\Pages\Applic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAplic;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Pages\Applic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbtnDateStart;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\Pages\Applic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbtnDateEnd;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\Pages\Applic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbIAID;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\Pages\Applic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
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
            System.Uri resourceLocater = new System.Uri("/InternalApplicationWPF;component/pages/applic.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Applic.xaml"
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
            this.dg = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.btnWord = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\Pages\Applic.xaml"
            this.btnWord.Click += new System.Windows.RoutedEventHandler(this.btnWord_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnExcel = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\Pages\Applic.xaml"
            this.btnExcel.Click += new System.Windows.RoutedEventHandler(this.btnExcel_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnAplic = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\Pages\Applic.xaml"
            this.btnAplic.Click += new System.Windows.RoutedEventHandler(this.btnAplic_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.rbtnDateStart = ((System.Windows.Controls.RadioButton)(target));
            
            #line 69 "..\..\..\Pages\Applic.xaml"
            this.rbtnDateStart.Checked += new System.Windows.RoutedEventHandler(this.rbtnDateStart_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.rbtnDateEnd = ((System.Windows.Controls.RadioButton)(target));
            
            #line 70 "..\..\..\Pages\Applic.xaml"
            this.rbtnDateEnd.Checked += new System.Windows.RoutedEventHandler(this.rbtnDateEnd_Checked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cbIAID = ((System.Windows.Controls.ComboBox)(target));
            
            #line 74 "..\..\..\Pages\Applic.xaml"
            this.cbIAID.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbIAID_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnBack = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\Pages\Applic.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.btnBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

