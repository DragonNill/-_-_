﻿#pragma checksum "..\..\..\..\Windows\ListViewProducts.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "930B8C0CD027E7E9D1800D7358BE9949DC359635"
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
using ООО__Посуда_.Windows;


namespace ООО__Посуда_.Windows {
    
    
    /// <summary>
    /// ListViewProducts
    /// </summary>
    public partial class ListViewProducts : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\..\Windows\ListViewProducts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label SNPLabel;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Windows\ListViewProducts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CountProductsLabel;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Windows\ListViewProducts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FindTextBox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Windows\ListViewProducts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FilterComboBox;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Windows\ListViewProducts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SortingComboBox;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Windows\ListViewProducts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ProductsListView;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Windows\ListViewProducts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteButton;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Windows\ListViewProducts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddButton;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Windows\ListViewProducts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateButton;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Windows\ListViewProducts.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ООО _Посуда_;component/windows/listviewproducts.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\ListViewProducts.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\..\Windows\ListViewProducts.xaml"
            ((ООО__Посуда_.Windows.ListViewProducts)(target)).SizeChanged += new System.Windows.SizeChangedEventHandler(this.Window_SizeChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SNPLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.CountProductsLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.FindTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\..\..\Windows\ListViewProducts.xaml"
            this.FindTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.FindTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.FilterComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 34 "..\..\..\..\Windows\ListViewProducts.xaml"
            this.FilterComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FilterComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.SortingComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 35 "..\..\..\..\Windows\ListViewProducts.xaml"
            this.SortingComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SortingComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ProductsListView = ((System.Windows.Controls.ListView)(target));
            return;
            case 8:
            this.DeleteButton = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.AddButton = ((System.Windows.Controls.Button)(target));
            return;
            case 10:
            this.UpdateButton = ((System.Windows.Controls.Button)(target));
            return;
            case 11:
            this.BackButton = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\..\Windows\ListViewProducts.xaml"
            this.BackButton.Click += new System.Windows.RoutedEventHandler(this.BackButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

