﻿#pragma checksum "..\..\..\..\App\Gallery\PaintingsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1A21C4F2391EE0C706AAE1E41A224A2DD5B416B4930DF2D021532EB4BB449ECE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BD_Proiect.Gallery;
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


namespace BD_Proiect.Gallery {
    
    
    /// <summary>
    /// PaintingsPage
    /// </summary>
    public partial class PaintingsPage : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\App\Gallery\PaintingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid PaintingsDataGrid;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\App\Gallery\PaintingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GallerysButton;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\App\Gallery\PaintingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExpositionsButton;
        
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
            System.Uri resourceLocater = new System.Uri("/BD_Proiect;component/app/gallery/paintingspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\App\Gallery\PaintingsPage.xaml"
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
            this.PaintingsDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 10 "..\..\..\..\App\Gallery\PaintingsPage.xaml"
            this.PaintingsDataGrid.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.PaintingsDataGrid_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GallerysButton = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\..\App\Gallery\PaintingsPage.xaml"
            this.GallerysButton.Click += new System.Windows.RoutedEventHandler(this.GallerysButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ExpositionsButton = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\..\App\Gallery\PaintingsPage.xaml"
            this.ExpositionsButton.Click += new System.Windows.RoutedEventHandler(this.ExpositionsButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

