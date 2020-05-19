using System;
using global::Windows.UI.Xaml;

namespace System.Maui.Platform.UWP
{
	public interface IVisualElementRenderer : IRegisterable, IDisposable
	{
		FrameworkElement ContainerElement { get; }

		VisualElement Element { get; }

		event EventHandler<VisualElementChangedEventArgs> ElementChanged;

		SizeRequest GetDesiredSize(double widthConstraint, double heightConstraint);

		void SetElement(VisualElement element);

		UIElement GetNativeElement();
	}
}