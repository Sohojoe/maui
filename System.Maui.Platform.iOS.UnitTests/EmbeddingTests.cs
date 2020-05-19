using System.Threading.Tasks;
using NUnit.Framework;
using UIKit;

namespace System.Maui.Platform.iOS.UnitTests
{
	[TestFixture]
	public class EmbeddingTests
	{
		[Test]
		public async Task CanCreateViewControllerFromContentPage() 
		{
			var contentPage = new ContentPage { Title = "Embedded Page" };
			await Device.InvokeOnMainThreadAsync(() => {
				UIViewController controller = contentPage.CreateViewController();
			});
		}
	}
}