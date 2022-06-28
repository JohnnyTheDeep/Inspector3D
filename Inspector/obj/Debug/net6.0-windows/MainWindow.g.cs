﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71A8EF9E9DC5E7AE0A1483B8F07D426AD0049153"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using HelixToolkit.Wpf;
using Microsoft.Xaml.Behaviors;
using Microsoft.Xaml.Behaviors.Core;
using Microsoft.Xaml.Behaviors.Input;
using Microsoft.Xaml.Behaviors.Layout;
using Microsoft.Xaml.Behaviors.Media;
using SharpVectors.Converters;
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


namespace Inspector {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.UserControl usc1;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid mainGrid;
        
        #line default
        #line hidden
        
        
        #line 248 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ColumnDefinition column2;
        
        #line default
        #line hidden
        
        
        #line 261 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HelixToolkit.Wpf.HelixViewport3D viewPort3d;
        
        #line default
        #line hidden
        
        
        #line 289 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ToolTip modelObjectToolTip;
        
        #line default
        #line hidden
        
        
        #line 292 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Media3D.ModelVisual3D model;
        
        #line default
        #line hidden
        
        
        #line 293 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HelixToolkit.Wpf.GridLinesVisual3D helixToolKitGridLines;
        
        #line default
        #line hidden
        
        
        #line 304 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton CameraMode_Inspect_RadioButton;
        
        #line default
        #line hidden
        
        
        #line 316 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SharpVectors.Converters.SvgViewbox cameraInspectButton;
        
        #line default
        #line hidden
        
        
        #line 319 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton CameraMode_Fixed_RadioButton;
        
        #line default
        #line hidden
        
        
        #line 334 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton CameraMode_WalkAround_RadioButton;
        
        #line default
        #line hidden
        
        
        #line 351 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SharpVectors.Converters.SvgViewbox rotationButtonImage;
        
        #line default
        #line hidden
        
        
        #line 354 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SharpVectors.Converters.SvgViewbox dragButtonImage;
        
        #line default
        #line hidden
        
        
        #line 386 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup autoRotatePopUp;
        
        #line default
        #line hidden
        
        
        #line 398 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider autoRotateSlider;
        
        #line default
        #line hidden
        
        
        #line 405 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup popup4;
        
        #line default
        #line hidden
        
        
        #line 413 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock popup4TextBlock;
        
        #line default
        #line hidden
        
        
        #line 418 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup addModelInformation;
        
        #line default
        #line hidden
        
        
        #line 433 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup popup3;
        
        #line default
        #line hidden
        
        
        #line 441 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton developerMode;
        
        #line default
        #line hidden
        
        
        #line 442 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton userMode;
        
        #line default
        #line hidden
        
        
        #line 465 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ToolTip tooltip1;
        
        #line default
        #line hidden
        
        
        #line 500 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem propertiesTabItem;
        
        #line default
        #line hidden
        
        
        #line 508 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock descriptionModelTextBlock;
        
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
            System.Uri resourceLocater = new System.Uri("/Inspector;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
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
            this.usc1 = ((System.Windows.Controls.UserControl)(target));
            return;
            case 2:
            this.mainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.column2 = ((System.Windows.Controls.ColumnDefinition)(target));
            return;
            case 4:
            this.viewPort3d = ((HelixToolkit.Wpf.HelixViewport3D)(target));
            return;
            case 5:
            this.modelObjectToolTip = ((System.Windows.Controls.ToolTip)(target));
            return;
            case 6:
            this.model = ((System.Windows.Media.Media3D.ModelVisual3D)(target));
            return;
            case 7:
            this.helixToolKitGridLines = ((HelixToolkit.Wpf.GridLinesVisual3D)(target));
            return;
            case 8:
            this.CameraMode_Inspect_RadioButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 9:
            this.cameraInspectButton = ((SharpVectors.Converters.SvgViewbox)(target));
            return;
            case 10:
            this.CameraMode_Fixed_RadioButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 11:
            this.CameraMode_WalkAround_RadioButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 12:
            this.rotationButtonImage = ((SharpVectors.Converters.SvgViewbox)(target));
            return;
            case 13:
            this.dragButtonImage = ((SharpVectors.Converters.SvgViewbox)(target));
            return;
            case 14:
            this.autoRotatePopUp = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 15:
            this.autoRotateSlider = ((System.Windows.Controls.Slider)(target));
            return;
            case 16:
            this.popup4 = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 17:
            this.popup4TextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 18:
            this.addModelInformation = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 19:
            this.popup3 = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 20:
            this.developerMode = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 21:
            this.userMode = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 22:
            
            #line 456 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 23:
            this.tooltip1 = ((System.Windows.Controls.ToolTip)(target));
            return;
            case 24:
            this.propertiesTabItem = ((System.Windows.Controls.TabItem)(target));
            return;
            case 25:
            this.descriptionModelTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 26:
            
            #line 518 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
