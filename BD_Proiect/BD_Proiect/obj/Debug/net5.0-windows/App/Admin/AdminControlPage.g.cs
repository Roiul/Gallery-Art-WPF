﻿#pragma checksum "..\..\..\..\..\App\Admin\AdminControlPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EA906E8626853F7A16F440761658CB26F0E5FB81"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BD_Proiect;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace BD_Proiect {
    
    
    /// <summary>
    /// AdminControlPage
    /// </summary>
    public partial class AdminControlPage : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\..\App\Admin\AdminControlPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TableComboBox;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\..\App\Admin\AdminControlPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGrid;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\..\App\Admin\AdminControlPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem AddRecord;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\App\Admin\AdminControlPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ModifyRecord;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\..\App\Admin\AdminControlPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem DeleteRecord;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BD_Proiect;component/app/admin/admincontrolpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\App\Admin\AdminControlPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TableComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 10 "..\..\..\..\..\App\Admin\AdminControlPage.xaml"
            this.TableComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TableComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 11 "..\..\..\..\..\App\Admin\AdminControlPage.xaml"
            this.DataGrid.RowEditEnding += new System.EventHandler<System.Windows.Controls.DataGridRowEditEndingEventArgs>(this.DataGrid_RowEditEnding);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AddRecord = ((System.Windows.Controls.MenuItem)(target));
            
            #line 14 "..\..\..\..\..\App\Admin\AdminControlPage.xaml"
            this.AddRecord.Click += new System.Windows.RoutedEventHandler(this.AddRecord_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ModifyRecord = ((System.Windows.Controls.MenuItem)(target));
            
            #line 16 "..\..\..\..\..\App\Admin\AdminControlPage.xaml"
            this.ModifyRecord.Click += new System.Windows.RoutedEventHandler(this.ModifyRecord_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DeleteRecord = ((System.Windows.Controls.MenuItem)(target));
            
            #line 18 "..\..\..\..\..\App\Admin\AdminControlPage.xaml"
            this.DeleteRecord.Click += new System.Windows.RoutedEventHandler(this.DeleteRecord_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

