﻿#pragma checksum "..\..\..\Dcotor\PageProfile.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B37B3A8C3AD316AA92DA5FBC519BAEF9793925EDFE4C8FD2B2DDC0C87C5EB09D"
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
using VetClinic.Doctor;


namespace VetClinic.Doctor {
    
    
    /// <summary>
    /// PageProfile
    /// </summary>
    public partial class PageProfile : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Dcotor\PageProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image usrImage;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Dcotor\PageProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblLastName;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Dcotor\PageProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblFirstName;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Dcotor\PageProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblPosition;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Dcotor\PageProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblRole;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Dcotor\PageProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAppointment;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Dcotor\PageProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnProcedure;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Dcotor\PageProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogout;
        
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
            System.Uri resourceLocater = new System.Uri("/VetClinic;component/dcotor/pageprofile.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Dcotor\PageProfile.xaml"
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
            this.usrImage = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.tblLastName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.tblFirstName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.tblPosition = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.tblRole = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.btnAppointment = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\Dcotor\PageProfile.xaml"
            this.btnAppointment.Click += new System.Windows.RoutedEventHandler(this.btnAppointment_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnProcedure = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\Dcotor\PageProfile.xaml"
            this.btnProcedure.Click += new System.Windows.RoutedEventHandler(this.btnProcedure_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnLogout = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\Dcotor\PageProfile.xaml"
            this.btnLogout.Click += new System.Windows.RoutedEventHandler(this.btnLogout_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
