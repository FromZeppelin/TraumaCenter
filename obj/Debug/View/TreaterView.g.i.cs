// Updated by XamlIntelliSenseFileGenerator 03.06.2023 11:06:19
#pragma checksum "..\..\..\View\TreaterView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F0133D30CEAD8BA994D63A7D7D5FD66944A2FA383E4730E83FD453EC386DE91D"
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
using TraumaSoftware.View;


namespace TraumaSoftware.View
{


    /// <summary>
    /// TreaterView
    /// </summary>
    public partial class TreaterView : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector
    {


#line 17 "..\..\..\View\TreaterView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border SearchBar;

#line default
#line hidden


#line 19 "..\..\..\View\TreaterView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SearchWatermark;

#line default
#line hidden


#line 20 "..\..\..\View\TreaterView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchBox;

#line default
#line hidden


#line 25 "..\..\..\View\TreaterView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image RefreshButton;

#line default
#line hidden


#line 37 "..\..\..\View\TreaterView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CabinetButton;

#line default
#line hidden


#line 38 "..\..\..\View\TreaterView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateButton;

#line default
#line hidden


#line 40 "..\..\..\View\TreaterView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteButton;

#line default
#line hidden


#line 44 "..\..\..\View\TreaterView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid TreaterDataGrid;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TraumaSoftware;component/view/treaterview.xaml", System.UriKind.Relative);

#line 1 "..\..\..\View\TreaterView.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 9 "..\..\..\View\TreaterView.xaml"
                    ((TraumaSoftware.View.TreaterView)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Page_IsVisibleChanged);

#line default
#line hidden
                    return;
                case 2:
                    this.SearchBar = ((System.Windows.Controls.Border)(target));
                    return;
                case 3:
                    this.SearchWatermark = ((System.Windows.Controls.TextBlock)(target));

#line 19 "..\..\..\View\TreaterView.xaml"
                    this.SearchWatermark.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.SearchWatermark_MouseDown);

#line default
#line hidden
                    return;
                case 4:
                    this.SearchBox = ((System.Windows.Controls.TextBox)(target));

#line 20 "..\..\..\View\TreaterView.xaml"
                    this.SearchBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchBox_TextChanged);

#line default
#line hidden
                    return;
                case 5:
                    this.RefreshButton = ((System.Windows.Controls.Image)(target));

#line 26 "..\..\..\View\TreaterView.xaml"
                    this.RefreshButton.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.RefreshButton_MouseDown);

#line default
#line hidden
                    return;
                case 6:
                    this.CabinetButton = ((System.Windows.Controls.Button)(target));

#line 37 "..\..\..\View\TreaterView.xaml"
                    this.CabinetButton.Click += new System.Windows.RoutedEventHandler(this.CabinetButton_Click);

#line default
#line hidden
                    return;
                case 7:
                    this.CreateButton = ((System.Windows.Controls.Button)(target));

#line 38 "..\..\..\View\TreaterView.xaml"
                    this.CreateButton.Click += new System.Windows.RoutedEventHandler(this.CreateButton_Click);

#line default
#line hidden
                    return;
                case 8:
                    this.EditButton = ((System.Windows.Controls.Button)(target));
                    return;
                case 9:
                    this.DeleteButton = ((System.Windows.Controls.Button)(target));

#line 40 "..\..\..\View\TreaterView.xaml"
                    this.DeleteButton.Click += new System.Windows.RoutedEventHandler(this.DeleteButton_Click);

#line default
#line hidden
                    return;
                case 10:
                    this.TreaterDataGrid = ((System.Windows.Controls.DataGrid)(target));
                    return;
            }
            this._contentLoaded = true;
        }
    }
}

