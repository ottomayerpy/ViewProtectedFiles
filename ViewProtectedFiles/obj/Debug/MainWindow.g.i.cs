#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "43821FB3FF2E4CE4AF1A8DB9362FF4C941656D47AFA13D5175226D1C00927EA5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
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


namespace ViewProtectedFiles {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelPathCurrentCatalog;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonBackCatalog;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonCreateCatalog;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonNextCatalog;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonOpen;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAdd;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonDelete;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonCopyTo;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListViewCatalog;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListViewImage;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn ColumnName;
        
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
            System.Uri resourceLocater = new System.Uri("/ViewProtectedFiles;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            
            #line 8 "..\..\MainWindow.xaml"
            ((ViewProtectedFiles.MainWindow)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.MetroWindow_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LabelPathCurrentCatalog = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.ButtonBackCatalog = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\MainWindow.xaml"
            this.ButtonBackCatalog.Click += new System.Windows.RoutedEventHandler(this.ButtonBackCatalog_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonCreateCatalog = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\MainWindow.xaml"
            this.ButtonCreateCatalog.Click += new System.Windows.RoutedEventHandler(this.ButtonCreateCatalog_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ButtonNextCatalog = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\MainWindow.xaml"
            this.ButtonNextCatalog.Click += new System.Windows.RoutedEventHandler(this.ButtonNextCatalog_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ButtonOpen = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\MainWindow.xaml"
            this.ButtonOpen.Click += new System.Windows.RoutedEventHandler(this.ButtonOpen_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ButtonAdd = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\MainWindow.xaml"
            this.ButtonAdd.Click += new System.Windows.RoutedEventHandler(this.ButtonAdd_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ButtonDelete = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\MainWindow.xaml"
            this.ButtonDelete.Click += new System.Windows.RoutedEventHandler(this.ButtonDelete_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ButtonCopyTo = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\MainWindow.xaml"
            this.ButtonCopyTo.Click += new System.Windows.RoutedEventHandler(this.ButtonCopyTo_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ListViewCatalog = ((System.Windows.Controls.ListView)(target));
            
            #line 19 "..\..\MainWindow.xaml"
            this.ListViewCatalog.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListViewCatalog_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ListViewImage = ((System.Windows.Controls.ListView)(target));
            return;
            case 12:
            this.ColumnName = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

