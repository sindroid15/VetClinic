﻿#pragma checksum "..\..\..\..\Manager\Appointment\PageManagerAppointmentConfirming.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "84105FF87326A25AA558278ED97C45526121F47FEF070E54F0D14FC717891602"
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
    /// PageManagerAppointmentConfirming
    /// </summary>
    public partial class PageManagerAppointmentConfirming : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\..\Manager\Appointment\PageManagerAppointmentConfirming.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbNameClient;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Manager\Appointment\PageManagerAppointmentConfirming.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbNamePet;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Manager\Appointment\PageManagerAppointmentConfirming.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbDateTime;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\Manager\Appointment\PageManagerAppointmentConfirming.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSaveAppointment;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\Manager\Appointment\PageManagerAppointmentConfirming.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancelAppointment;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\Manager\Appointment\PageManagerAppointmentConfirming.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEditAppointment;
        
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
            System.Uri resourceLocater = new System.Uri("/VetClinic;component/manager/appointment/pagemanagerappointmentconfirming.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Manager\Appointment\PageManagerAppointmentConfirming.xaml"
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
            this.txbNameClient = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txbNamePet = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txbDateTime = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btnSaveAppointment = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\..\Manager\Appointment\PageManagerAppointmentConfirming.xaml"
            this.btnSaveAppointment.Click += new System.Windows.RoutedEventHandler(this.btnSaveAppointment_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnCancelAppointment = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\..\Manager\Appointment\PageManagerAppointmentConfirming.xaml"
            this.btnCancelAppointment.Click += new System.Windows.RoutedEventHandler(this.btnCancelAppointment_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnEditAppointment = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\..\Manager\Appointment\PageManagerAppointmentConfirming.xaml"
            this.btnEditAppointment.Click += new System.Windows.RoutedEventHandler(this.btnEditAppointment_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

