#pragma checksum "..\..\..\..\Manager\Clients\ManagerClientAddPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "01AFB6D479474371C895E05A7121589633FEF4B78F595E2D5830C9F974624725"
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
using VetClinic.Manager.Clients;


namespace VetClinic.Manager.Clients {
    
    
    /// <summary>
    /// ManagerClientAddPage
    /// </summary>
    public partial class ManagerClientAddPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\..\..\Manager\Clients\ManagerClientAddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbFirstName;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Manager\Clients\ManagerClientAddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbLastName;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\Manager\Clients\ManagerClientAddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbPatronymic;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\Manager\Clients\ManagerClientAddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbGender;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\Manager\Clients\ManagerClientAddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbBirthday;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\..\Manager\Clients\ManagerClientAddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbAddres;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\..\Manager\Clients\ManagerClientAddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSaveClient;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\..\Manager\Clients\ManagerClientAddPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancelClient;
        
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
            System.Uri resourceLocater = new System.Uri("/VetClinic;component/manager/clients/managerclientaddpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Manager\Clients\ManagerClientAddPage.xaml"
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
            this.txbFirstName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txbLastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txbPatronymic = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.cmbGender = ((System.Windows.Controls.ComboBox)(target));
            
            #line 66 "..\..\..\..\Manager\Clients\ManagerClientAddPage.xaml"
            this.cmbGender.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbGender_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txbBirthday = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txbAddres = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnSaveClient = ((System.Windows.Controls.Button)(target));
            
            #line 102 "..\..\..\..\Manager\Clients\ManagerClientAddPage.xaml"
            this.btnSaveClient.Click += new System.Windows.RoutedEventHandler(this.btnSaveClient_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnCancelClient = ((System.Windows.Controls.Button)(target));
            
            #line 107 "..\..\..\..\Manager\Clients\ManagerClientAddPage.xaml"
            this.btnCancelClient.Click += new System.Windows.RoutedEventHandler(this.btnCancelClient_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

