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
	partial class RecuperarPage : Windows.UI.Xaml.Controls.Page
	{
				private void InitializeComponent()
		{
			var __resourceLocator = new global::System.Uri("file:///C:/Jprado/PresentacionUNO/PresentacionUNO/UNOUI/UNOUI.Shared/Pages/RecuperarPage.xaml");
			if(global::Uno.UI.ApplicationHelper.IsLoadableComponent(__resourceLocator))
			{
				global::Windows.UI.Xaml.Application.LoadComponent(this, __resourceLocator);
				return;
			}
			var nameScope = new global::Windows.UI.Xaml.NameScope();
			NameScope.SetNameScope(this, nameScope);
			base.IsParsing = true;
			// Source ..\..\..\..\..\..\..\UNOUI.Shared\Pages\RecuperarPage.xaml (Line 1:2)
			base.Content = 
			new global::Windows.UI.Xaml.Controls.Grid
			{
				IsParsing = true,
				// Source ..\..\..\..\..\..\..\UNOUI.Shared\Pages\RecuperarPage.xaml (Line 11:6)
				Children = 
				{
					new global::Windows.UI.Xaml.Controls.Button
					{
						IsParsing = true,
						Name = "BtnRecuperar",
						Content = @"Recuperar"/* object/, Recuperar, Button/Content */,
						HorizontalAlignment = global::Windows.UI.Xaml.HorizontalAlignment.Center/* Windows.UI.Xaml.HorizontalAlignment/, Center, Button/HorizontalAlignment */,
						FontSize = 60d/* double/, 60, Button/FontSize */,
						// Source ..\..\..\..\..\..\..\UNOUI.Shared\Pages\RecuperarPage.xaml (Line 12:10)
					}
					.RecuperarPage_edfe3a9216c1fbd4abb876c06ce45be9_XamlApply((RecuperarPage_edfe3a9216c1fbd4abb876c06ce45be9XamlApplyExtensions.XamlApplyHandler0)(c0 => 
					{
						nameScope.RegisterName("BtnRecuperar", c0);
						this.BtnRecuperar = c0;
						var Click_BtnRecuperar_Click_That = (this as global::Uno.UI.DataBinding.IWeakReferenceProvider).WeakReference;
						/* second level */ c0.Click += (BtnRecuperar_Click_sender,BtnRecuperar_Click_e) => (Click_BtnRecuperar_Click_That.Target as RecuperarPage)?.BtnRecuperar_Click(BtnRecuperar_Click_sender,BtnRecuperar_Click_e);
						global::Uno.UI.FrameworkElementHelper.SetBaseUri(c0, "file:///C:/Jprado/PresentacionUNO/PresentacionUNO/UNOUI/UNOUI.Shared/Pages/RecuperarPage.xaml");
						c0.CreationComplete();
					}
					))
					,
				}
			}
			.RecuperarPage_edfe3a9216c1fbd4abb876c06ce45be9_XamlApply((RecuperarPage_edfe3a9216c1fbd4abb876c06ce45be9XamlApplyExtensions.XamlApplyHandler1)(c1 => 
			{
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c1, "file:///C:/Jprado/PresentacionUNO/PresentacionUNO/UNOUI/UNOUI.Shared/Pages/RecuperarPage.xaml");
				c1.CreationComplete();
			}
			))
			;
			
			this
			.GenericApply((c2 => 
			{
				// Source C:\Jprado\PresentacionUNO\PresentacionUNO\UNOUI\UNOUI.Shared\Pages\RecuperarPage.xaml (Line 1:2)
				
				// WARNING Property c2.base does not exist on {http://schemas.microsoft.com/winfx/2006/xaml/presentation}Page, the namespace is http://www.w3.org/XML/1998/namespace. This error was considered irrelevant by the XamlFileGenerator
			}
			))
			.GenericApply((c3 => 
			{
				// Class UNOUI.Pages.RecuperarPage
				global::Uno.UI.ResourceResolverSingleton.Instance.ApplyResource(c3, global::Windows.UI.Xaml.Controls.Page.BackgroundProperty, "ApplicationPageBackgroundThemeBrush", isThemeResourceExtension: true, isHotReloadSupported: true, context: global::UNOUI.Droid.GlobalStaticResources.__ParseContext_);
				/* _isTopLevelDictionary:False */
				this._component_0 = c3;
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c3, "file:///C:/Jprado/PresentacionUNO/PresentacionUNO/UNOUI/UNOUI.Shared/Pages/RecuperarPage.xaml");
				c3.CreationComplete();
			}
			))
			;
			OnInitializeCompleted();

			Bindings = new RecuperarPage_Bindings(this);
			Loading += delegate
			{
				Bindings.UpdateResources();
			}
			;
		}
		partial void OnInitializeCompleted();
		private global::Windows.UI.Xaml.Data.ElementNameSubject _BtnRecuperarSubject = new global::Windows.UI.Xaml.Data.ElementNameSubject();
		private global::Windows.UI.Xaml.Controls.Button BtnRecuperar
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.Button)_BtnRecuperarSubject.ElementInstance;
			}
			set
			{
				_BtnRecuperarSubject.ElementInstance = value;
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
		private interface IRecuperarPage_Bindings
		{
			void Initialize();
			void Update();
			void UpdateResources();
			void StopTracking();
		}
		#pragma warning disable 0169 //  Suppress unused field warning in case Bindings is not used.
		private IRecuperarPage_Bindings Bindings;
		#pragma warning restore 0169
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		private class RecuperarPage_Bindings : IRecuperarPage_Bindings
		{
			#if UNO_HAS_UIELEMENT_IMPLICIT_PINNING
			private global::System.WeakReference _ownerReference;
			private RecuperarPage Owner { get => (RecuperarPage)_ownerReference?.Target; set => _ownerReference = new global::System.WeakReference(value); }
			#else
			private RecuperarPage Owner { get; set; }
			#endif
			public RecuperarPage_Bindings(RecuperarPage owner)
			{
				Owner = owner;
			}
			void IRecuperarPage_Bindings.Initialize()
			{
			}
			void IRecuperarPage_Bindings.Update()
			{
				var owner = Owner;
			}
			void IRecuperarPage_Bindings.UpdateResources()
			{
				var owner = Owner;
				owner._component_0.UpdateResourceBindings();
			}
			void IRecuperarPage_Bindings.StopTracking()
			{
			}
		}

	}
}
namespace UNOUI.Droid
{
	static class RecuperarPage_edfe3a9216c1fbd4abb876c06ce45be9XamlApplyExtensions
	{
		public delegate void XamlApplyHandler0(global::Windows.UI.Xaml.Controls.Button instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.Button RecuperarPage_edfe3a9216c1fbd4abb876c06ce45be9_XamlApply(this global::Windows.UI.Xaml.Controls.Button instance, XamlApplyHandler0 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler1(global::Windows.UI.Xaml.Controls.Grid instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.Grid RecuperarPage_edfe3a9216c1fbd4abb876c06ce45be9_XamlApply(this global::Windows.UI.Xaml.Controls.Grid instance, XamlApplyHandler1 handler)
		{
			handler(instance);
			return instance;
		}
	}
}
