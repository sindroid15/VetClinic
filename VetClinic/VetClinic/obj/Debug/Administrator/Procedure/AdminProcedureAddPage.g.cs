#pragma checksum "..\..\..\..\Administrator\Procedure\AdminProcedureAddPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E4A383A46E51CD26F6912B93D619C5939E3E0124321FDB6714EDA08214D97BA3"
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
using VetClinic.Administrator.Procedure;


namespace VetClinic.Administrator.Procedure {
    
    
    /// <summary>
    /// AdminProcedureAddPage
    /// </summary>
    public partial class AdminProcedureAddPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\..\..\Administrator\Procedure\AdminProcedureAddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbNameProcedure;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Administrator\Procedure\AdminProcedureAddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbCost;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\Administrator\Procedure\AdminProcedureAddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbCabinet;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\Administrator\Procedure\AdminProcedureAddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbDurationInSeconds;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\..\Administrator\Procedure\AdminProcedureAddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSaveProcedure;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\..\Administrator\Procedure\AdminProcedureAddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancelProcedure;
        
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
            System.Uri resourceLocater = new System.Uri("/VetClinic;component/administrator/procedure/adminprocedureaddpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Administrator\Procedure\AdminProcedureAddPage.xaml"
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
            this.txbNameProcedure = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txbCost = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.cmbCabinet = ((System.Windows.Controls.ComboBox)(target));
            
            #line 68 "..\..\..\..\Administrator\Procedure\AdminProcedureAddPage.xaml"
            this.cmbCabinet.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbCabinet_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txbDurationInSeconds = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btnSaveProcedure = ((System.Windows.Controls.Button)(target));
            
            #line 89 "..\..\..\..\Administrator\Procedure\AdminProcedureAddPage.xaml"
            this.btnSaveProcedure.Click += new System.Windows.RoutedEventHandler(this.btnSaveProcedure_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnCancelProcedure = ((System.Windows.Controls.Button)(target));
            
            #line 94 "..\..\..\..\Administrator\Procedure\AdminProcedureAddPage.xaml"
            this.btnCancelProcedure.Click += new System.Windows.RoutedEventHandler(this.btnCancelProcedure_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

