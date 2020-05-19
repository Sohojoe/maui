using System;
using System.Maui.PlatformConfiguration.WindowsSpecific;

namespace System.Maui.Platform.UWP
{
	public static class ElementExtensions
	{
		internal static T FindParent<T>(this Element self)
			where T : class
		{
			T returnvalue = default(T);

			do
			{
				self = self?.RealParent;
				returnvalue = self as T;
			}
			while (returnvalue == null && self != null);

			return returnvalue;
		}
	}
}