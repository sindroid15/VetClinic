﻿#pragma checksum "..\..\..\..\Manager\Appointment\PageManagerAppointmentClientAdd.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2E4E7B2D13DE87E04C1304231AAF6038B1E6FD66EA7B8804576FDF838DBC990F"
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
using VetClinic.Manager.Appointment;


namespace VetClinic.Manager.Appointment {
    
    
    /// <summary>
    /// PageManagerAppointmentClientAdd
    /// </summary>
    public partial class PageManagerAppointmentClientAdd : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\..\Manager\Appointment\PageManagerAppointmentClientAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbAdminAppointmentClientAdd;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Manager\Appointment\PageManagerAppointmentClientAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearch;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Manager\Appointment\PageManagerAppointmentClientAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNew;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\Manager\Appointment\PageManagerAppointmentClientAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\Manager\Appointment\PageManagerAppointmentClientAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvAdminAppointmentClientAdd;
        
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
            System.Uri resourceLocater = new System.Uri("/VetClinic;component/manager/appointment/pagemanagerappointmentclientadd.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Manager\Appointment\PageManagerAppointmentClientAdd.xaml"
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
            this.txbAdminAppointmentClientAdd = ((System.Windows.Controls.TextBox)(target));
            
            #line 31 "..\..\..\..\Manager\Appointment\PageManagerAppointmentClientAdd.xaml"
            this.txbAdminAppointmentClientAdd.SelectionChanged += new System.Windows.RoutedEventHandler(this.txbAdminAppointmentClientAdd_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnSearch = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\..\Manager\Appointment\PageManagerAppointmentClientAdd.xaml"
            this.btnSearch.Click += new System.Windows.RoutedEventHandler(this.btnSearch_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnNew = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\..\Manager\Appointment\PageManagerAppointmentClientAdd.xaml"
            this.btnNew.Click += new System.Windows.RoutedEventHandler(this.btnNew_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\..\Manager\Appointment\PageManagerAppointmentClientAdd.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.btnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lvAdminAppointmentClientAdd = ((System.Windows.Controls.ListView)(target));
            
            #line 63 "..\..\..\..\Manager\Appointment\PageManagerAppointmentClientAdd.xaml"
            this.lvAdminAppointmentClientAdd.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lvAdminAppointmentClientAdd_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
