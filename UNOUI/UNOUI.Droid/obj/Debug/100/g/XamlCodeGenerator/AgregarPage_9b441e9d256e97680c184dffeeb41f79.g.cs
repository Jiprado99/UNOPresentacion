// <autogenerated />
#pragma warning disable 618  // Ignore obsolete members warnings
#pragma warning disable 105  // Ignore duplicate namespaces
#pragma warning disable 1591 // Ignore missing XML comment warnings
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Uno.UI;
using Uno.UI.Xaml;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Text;
using Uno.Extensions;
using Uno;
using Uno.UI.Helpers.Xaml;
using UNOUI.Droid;

#if __ANDROID__
using _View = Android.Views.View;
#elif __IOS__
using _View = UIKit.UIView;
#elif __MACOS__
using _View = AppKit.NSView;
#elif UNO_REFERENCE_API || NET461
using _View = Windows.UI.Xaml.UIElement;
#endif

namespace UNOUI.Pages
{
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0056", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0058", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV1003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0085", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2001", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2004", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2005", Justification="Generated code")]
	partial class AgregarPage : Windows.UI.Xaml.Controls.Page
	{
				private void InitializeComponent()
		{
			var __resourceLocator = new global::System.Uri("file:///C:/Jprado/PresentacionUNO/UNOUI/UNOUI.Shared/Pages/AgregarPage.xaml");
			if(global::Uno.UI.ApplicationHelper.IsLoadableComponent(__resourceLocator))
			{
				global::Windows.UI.Xaml.Application.LoadComponent(this, __resourceLocator);
				return;
			}
			var nameScope = new global::Windows.UI.Xaml.NameScope();
			NameScope.SetNameScope(this, nameScope);
			base.IsParsing = true;
			// Source ..\..\..\..\..\..\..\UNOUI.Shared\Pages\AgregarPage.xaml (Line 1:2)
			base.Content = 
			new global::Windows.UI.Xaml.Controls.Grid
			{
				IsParsing = true,
				ColumnDefinitions = 
				{
					new global::Windows.UI.Xaml.Controls.ColumnDefinition
					{
						Width = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Star)/* Windows.UI.Xaml.GridLength/, *, ColumnDefinition/Width */,
						// Source ..\..\..\..\..\..\..\UNOUI.Shared\Pages\AgregarPage.xaml (Line 13:14)
					}
					,
					new global::Windows.UI.Xaml.Controls.ColumnDefinition
					{
						Width = new Windows.UI.Xaml.GridLength(5f, Windows.UI.Xaml.GridUnitType.Star)/* Windows.UI.Xaml.GridLength/, 5*, ColumnDefinition/Width */,
						// Source ..\..\..\..\..\..\..\UNOUI.Shared\Pages\AgregarPage.xaml (Line 14:14)
					}
					,
					new global::Windows.UI.Xaml.Controls.ColumnDefinition
					{
						Width = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Star)/* Windows.UI.Xaml.GridLength/, *, ColumnDefinition/Width */,
						// Source ..\..\..\..\..\..\..\UNOUI.Shared\Pages\AgregarPage.xaml (Line 15:14)
					}
					,
				}
				,
				RowDefinitions = 
				{
					new global::Windows.UI.Xaml.Controls.RowDefinition
					{
						Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Star)/* Windows.UI.Xaml.GridLength/, *, RowDefinition/Height */,
						// Source ..\..\..\..\..\..\..\UNOUI.Shared\Pages\AgregarPage.xaml (Line 18:14)
					}
					,
					new global::Windows.UI.Xaml.Controls.RowDefinition
					{
						Height = new Windows.UI.Xaml.GridLength(5f, Windows.UI.Xaml.GridUnitType.Star)/* Windows.UI.Xaml.GridLength/, 5*, RowDefinition/Height */,
						// Source ..\..\..\..\..\..\..\UNOUI.Shared\Pages\AgregarPage.xaml (Line 19:14)
					}
					,
					new global::Windows.UI.Xaml.Controls.RowDefinition
					{
						Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Star)/* Windows.UI.Xaml.GridLength/, *, RowDefinition/Height */,
						// Source ..\..\..\..\..\..\..\UNOUI.Shared\Pages\AgregarPage.xaml (Line 20:14)
					}
					,
				}
				,
				// Source ..\..\..\..\..\..\..\UNOUI.Shared\Pages\AgregarPage.xaml (Line 11:6)
				Children = 
				{
					new global::Windows.UI.Xaml.Controls.TextBlock
					{
						IsParsing = true,
						Text = "Agregar Palabras"/* string/, Agregar Palabras, TextBlock/Text */,
						FontSize = 60d/* double/, 60, TextBlock/FontSize */,
						HorizontalAlignment = global::Windows.UI.Xaml.HorizontalAlignment.Center/* Windows.UI.Xaml.HorizontalAlignment/, Center, TextBlock/HorizontalAlignment */,
						VerticalAlignment = global::Windows.UI.Xaml.VerticalAlignment.Center/* Windows.UI.Xaml.VerticalAlignment/, Center, TextBlock/VerticalAlignment */,
						// Source ..\..\..\..\..\..\..\UNOUI.Shared\Pages\AgregarPage.xaml (Line 22:10)
					}
					.AgregarPage_9b441e9d256e97680c184dffeeb41f79_XamlApply((AgregarPage_9b441e9d256e97680c184dffeeb41f79XamlApplyExtensions.XamlApplyHandler2)(c6 => 
					{
						global::Windows.UI.Xaml.Controls.Grid.SetColumn(c6, 1/* int/, 1, Grid/Column */);
						global::Windows.UI.Xaml.Controls.Grid.SetRow(c6, 0/* int/, 0, Grid/Row */);
						global::Uno.UI.FrameworkElementHelper.SetBaseUri(c6, "file:///C:/Jprado/PresentacionUNO/UNOUI/UNOUI.Shared/Pages/AgregarPage.xaml");
						c6.CreationComplete();
					}
					))
					,
					new global::Windows.UI.Xaml.Controls.StackPanel
					{
						IsParsing = true,
						// Source ..\..\..\..\..\..\..\UNOUI.Shared\Pages\AgregarPage.xaml (Line 23:10)
						Children = 
						{
							new global::Windows.UI.Xaml.Controls.TextBlock
							{
								IsParsing = true,
								Text = "Ingrese una palabra"/* string/, Ingrese una palabra, TextBlock/Text */,
								FontSize = 30d/* double/, 30, TextBlock/FontSize */,
								Margin = new global::Windows.UI.Xaml.Thickness(5)/* Windows.UI.Xaml.Thickness/, 5, TextBlock/Margin */,
								// Source ..\..\..\..\..\..\..\UNOUI.Shared\Pages\AgregarPage.xaml (Line 24:14)
							}
							.AgregarPage_9b441e9d256e97680c184dffeeb41f79_XamlApply((AgregarPage_9b441e9d256e97680c184dffeeb41f79XamlApplyExtensions.XamlApplyHandler2)(c7 => 
							{
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c7, "file:///C:/Jprado/PresentacionUNO/UNOUI/UNOUI.Shared/Pages/AgregarPage.xaml");
								c7.CreationComplete();
							}
							))
							,
							new global::Windows.UI.Xaml.Controls.TextBox
							{
								IsParsing = true,
								Name = "TxtPalabra",
								FontSize = 30d/* double/, 30, TextBox/FontSize */,
								Margin = new global::Windows.UI.Xaml.Thickness(5)/* Windows.UI.Xaml.Thickness/, 5, TextBox/Margin */,
								// Source ..\..\..\..\..\..\..\UNOUI.Shared\Pages\AgregarPage.xaml (Line 25:14)
							}
							.AgregarPage_9b441e9d256e97680c184dffeeb41f79_XamlApply((AgregarPage_9b441e9d256e97680c184dffeeb41f79XamlApplyExtensions.XamlApplyHandler3)(c8 => 
							{
								nameScope.RegisterName("TxtPalabra", c8);
								this.TxtPalabra = c8;
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c8, "file:///C:/Jprado/PresentacionUNO/UNOUI/UNOUI.Shared/Pages/AgregarPage.xaml");
								c8.CreationComplete();
							}
							))
							,
							new global::Windows.UI.Xaml.Controls.Button
							{
								IsParsing = true,
								Name = "BtnAgregar",
								Content = @"Agregar"/* object/, Agregar, Button/Content */,
								FontSize = 30d/* double/, 30, Button/FontSize */,
								HorizontalAlignment = global::Windows.UI.Xaml.HorizontalAlignment.Stretch/* Windows.UI.Xaml.HorizontalAlignment/, Stretch, Button/HorizontalAlignment */,
								Margin = new global::Windows.UI.Xaml.Thickness(10)/* Windows.UI.Xaml.Thickness/, 10, Button/Margin */,
								// Source ..\..\..\..\..\..\..\UNOUI.Shared\Pages\AgregarPage.xaml (Line 26:14)
							}
							.AgregarPage_9b441e9d256e97680c184dffeeb41f79_XamlApply((AgregarPage_9b441e9d256e97680c184dffeeb41f79XamlApplyExtensions.XamlApplyHandler4)(c9 => 
							{
								nameScope.RegisterName("BtnAgregar", c9);
								this.BtnAgregar = c9;
								var Tapped_BtnAgregar_Tapped_That = (this as global::Uno.UI.DataBinding.IWeakReferenceProvider).WeakReference;
								/* second level */ c9.Tapped += (BtnAgregar_Tapped_sender,BtnAgregar_Tapped_e) => (Tapped_BtnAgregar_Tapped_That.Target as AgregarPage)?.BtnAgregar_Tapped(BtnAgregar_Tapped_sender,BtnAgregar_Tapped_e);
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c9, "file:///C:/Jprado/PresentacionUNO/UNOUI/UNOUI.Shared/Pages/AgregarPage.xaml");
								c9.CreationComplete();
							}
							))
							,
						}
					}
					.AgregarPage_9b441e9d256e97680c184dffeeb41f79_XamlApply((AgregarPage_9b441e9d256e97680c184dffeeb41f79XamlApplyExtensions.XamlApplyHandler5)(c10 => 
					{
						global::Windows.UI.Xaml.Controls.Grid.SetRow(c10, 1/* int/, 1, Grid/Row */);
						global::Windows.UI.Xaml.Controls.Grid.SetColumn(c10, 1/* int/, 1, Grid/Column */);
						global::Uno.UI.FrameworkElementHelper.SetBaseUri(c10, "file:///C:/Jprado/PresentacionUNO/UNOUI/UNOUI.Shared/Pages/AgregarPage.xaml");
						c10.CreationComplete();
					}
					))
					,
				}
			}
			.AgregarPage_9b441e9d256e97680c184dffeeb41f79_XamlApply((AgregarPage_9b441e9d256e97680c184dffeeb41f79XamlApplyExtensions.XamlApplyHandler6)(c11 => 
			{
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c11, "file:///C:/Jprado/PresentacionUNO/UNOUI/UNOUI.Shared/Pages/AgregarPage.xaml");
				c11.CreationComplete();
			}
			))
			;
			
			this
			.GenericApply((c12 => 
			{
				// Source C:\Jprado\PresentacionUNO\UNOUI\UNOUI.Shared\Pages\AgregarPage.xaml (Line 1:2)
				
				// WARNING Property c12.base does not exist on {http://schemas.microsoft.com/winfx/2006/xaml/presentation}Page, the namespace is http://www.w3.org/XML/1998/namespace. This error was considered irrelevant by the XamlFileGenerator
			}
			))
			.GenericApply((c13 => 
			{
				// Class UNOUI.Pages.AgregarPage
				global::Uno.UI.ResourceResolverSingleton.Instance.ApplyResource(c13, global::Windows.UI.Xaml.Controls.Page.BackgroundProperty, "ApplicationPageBackgroundThemeBrush", isThemeResourceExtension: true, isHotReloadSupported: true, context: global::UNOUI.Droid.GlobalStaticResources.__ParseContext_);
				/* _isTopLevelDictionary:False */
				this._component_0 = c13;
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c13, "file:///C:/Jprado/PresentacionUNO/UNOUI/UNOUI.Shared/Pages/AgregarPage.xaml");
				c13.CreationComplete();
			}
			))
			;
			OnInitializeCompleted();

			Bindings = new AgregarPage_Bindings(this);
			Loading += delegate
			{
				Bindings.UpdateResources();
			}
			;
		}
		partial void OnInitializeCompleted();
		private global::Windows.UI.Xaml.Data.ElementNameSubject _TxtPalabraSubject = new global::Windows.UI.Xaml.Data.ElementNameSubject();
		private global::Windows.UI.Xaml.Controls.TextBox TxtPalabra
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.TextBox)_TxtPalabraSubject.ElementInstance;
			}
			set
			{
				_TxtPalabraSubject.ElementInstance = value;
			}
		}
		private global::Windows.UI.Xaml.Data.ElementNameSubject _BtnAgregarSubject = new global::Windows.UI.Xaml.Data.ElementNameSubject();
		private global::Windows.UI.Xaml.Controls.Button BtnAgregar
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.Button)_BtnAgregarSubject.ElementInstance;
			}
			set
			{
				_BtnAgregarSubject.ElementInstance = value;
			}
		}
		private global::Windows.UI.Xaml.Markup.ComponentHolder _component_0_Holder = new global::Windows.UI.Xaml.Markup.ComponentHolder(isWeak: true);
		private global::Windows.UI.Xaml.Controls.Page _component_0
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.Page)_component_0_Holder.Instance;
			}
			set
			{
				_component_0_Holder.Instance = value;
			}
		}
		private interface IAgregarPage_Bindings
		{
			void Initialize();
			void Update();
			void UpdateResources();
			void StopTracking();
		}
		#pragma warning disable 0169 //  Suppress unused field warning in case Bindings is not used.
		private IAgregarPage_Bindings Bindings;
		#pragma warning restore 0169
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		private class AgregarPage_Bindings : IAgregarPage_Bindings
		{
			#if UNO_HAS_UIELEMENT_IMPLICIT_PINNING
			private global::System.WeakReference _ownerReference;
			private AgregarPage Owner { get => (AgregarPage)_ownerReference?.Target; set => _ownerReference = new global::System.WeakReference(value); }
			#else
			private AgregarPage Owner { get; set; }
			#endif
			public AgregarPage_Bindings(AgregarPage owner)
			{
				Owner = owner;
			}
			void IAgregarPage_Bindings.Initialize()
			{
			}
			void IAgregarPage_Bindings.Update()
			{
				var owner = Owner;
			}
			void IAgregarPage_Bindings.UpdateResources()
			{
				var owner = Owner;
				owner._component_0.UpdateResourceBindings();
			}
			void IAgregarPage_Bindings.StopTracking()
			{
			}
		}

	}
}
namespace UNOUI.Droid
{
	static class AgregarPage_9b441e9d256e97680c184dffeeb41f79XamlApplyExtensions
	{
		public delegate void XamlApplyHandler0(global::Windows.UI.Xaml.Controls.ColumnDefinition instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.ColumnDefinition AgregarPage_9b441e9d256e97680c184dffeeb41f79_XamlApply(this global::Windows.UI.Xaml.Controls.ColumnDefinition instance, XamlApplyHandler0 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler1(global::Windows.UI.Xaml.Controls.RowDefinition instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.RowDefinition AgregarPage_9b441e9d256e97680c184dffeeb41f79_XamlApply(this global::Windows.UI.Xaml.Controls.RowDefinition instance, XamlApplyHandler1 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler2(global::Windows.UI.Xaml.Controls.TextBlock instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.TextBlock AgregarPage_9b441e9d256e97680c184dffeeb41f79_XamlApply(this global::Windows.UI.Xaml.Controls.TextBlock instance, XamlApplyHandler2 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler3(global::Windows.UI.Xaml.Controls.TextBox instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.TextBox AgregarPage_9b441e9d256e97680c184dffeeb41f79_XamlApply(this global::Windows.UI.Xaml.Controls.TextBox instance, XamlApplyHandler3 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler4(global::Windows.UI.Xaml.Controls.Button instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.Button AgregarPage_9b441e9d256e97680c184dffeeb41f79_XamlApply(this global::Windows.UI.Xaml.Controls.Button instance, XamlApplyHandler4 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler5(global::Windows.UI.Xaml.Controls.StackPanel instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.StackPanel AgregarPage_9b441e9d256e97680c184dffeeb41f79_XamlApply(this global::Windows.UI.Xaml.Controls.StackPanel instance, XamlApplyHandler5 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler6(global::Windows.UI.Xaml.Controls.Grid instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.Grid AgregarPage_9b441e9d256e97680c184dffeeb41f79_XamlApply(this global::Windows.UI.Xaml.Controls.Grid instance, XamlApplyHandler6 handler)
		{
			handler(instance);
			return instance;
		}
	}
}
