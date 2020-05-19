using System;
using Android.Content;
using Android.Runtime;
using Android.Widget;
using System.Maui.Platform.Android.FastRenderers;

namespace System.Maui.Platform.Android
{
	internal class FormsImageView : ImageView, IImageRendererController
	{
		bool _skipInvalidate;

		public FormsImageView(Context context) : base(context)
		{
		}

		protected FormsImageView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		public override void Invalidate()
		{
			if (_skipInvalidate)
			{
				_skipInvalidate = false;
				return;
			}

			base.Invalidate();
		}

		public void SkipInvalidate()
		{
			_skipInvalidate = true;
		}

		void IImageRendererController.SetFormsAnimationDrawable(IFormsAnimationDrawable formsAnimationDrawable)
		{
		}


		bool IImageRendererController.IsDisposed => false || !this.IsAlive();
	}
}