﻿#pragma checksum "..\..\..\..\Dcotor\Appointment\PageDoctorAppointmentPetAdd.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CDAF22AE79CA6F5A20B0BE82BCFFC3EAEE3D88D791092D46586FC2B1B1007C24"
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
using VetClinic.Doctor.Appointment;


namespace VetClinic.Doctor.Appointment {
    
    
    /// <summary>
    /// PageDoctorAppointmentPetAdd
    /// </summary>
    public partial class PageDoctorAppointmentPetAdd : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\..\Dcotor\Appointment\PageDoctorAppointmentPetAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbPetSearch;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Dcotor\Appointment\PageDoctorAppointmentPetAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearch;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Dcotor\Appointment\PageDoctorAppointmentPetAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNew;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\Dcotor\Appointment\PageDoctorAppointmentPetAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\Dcotor\Appointment\PageDoctorAppointmentPetAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvAdminAppointmentPetAdd;
        
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
            System.Uri resourceLocater = new System.Uri("/VetClinic;component/dcotor/appointment/pagedoctorappointmentpetadd.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Dcotor\Appointment\PageDoctorAppointmentPetAdd.xaml"
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
            this.txbPetSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 29 "..\..\..\..\Dcotor\Appointment\PageDoctorAppointmentPetAdd.xaml"
            this.txbPetSearch.SelectionChanged += new System.Windows.RoutedEventHandler(this.txbPetSearch_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnSearch = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\..\Dcotor\Appointment\PageDoctorAppointmentPetAdd.xaml"
            this.btnSearch.Click += new System.Windows.RoutedEventHandler(this.btnSearch_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnNew = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\..\Dcotor\Appointment\PageDoctorAppointmentPetAdd.xaml"
            this.btnNew.Click += new System.Windows.RoutedEventHandler(this.btnNew_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\..\Dcotor\Appointment\PageDoctorAppointmentPetAdd.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.btnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lvAdminAppointmentPetAdd = ((System.Windows.Controls.ListView)(target));
            
            #line 61 "..\..\..\..\Dcotor\Appointment\PageDoctorAppointmentPetAdd.xaml"
            this.lvAdminAppointmentPetAdd.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lvAdminAppointmentPetAdd_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
