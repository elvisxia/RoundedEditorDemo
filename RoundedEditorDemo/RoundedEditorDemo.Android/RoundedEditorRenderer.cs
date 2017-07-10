using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Graphics.Drawables;
using RoundedEditorDemo;
using RoundedEditorDemo.Droid;

[assembly:ExportRenderer(typeof(RoundedEditor),typeof(RoundedEditorRenderer))]
namespace RoundedEditorDemo.Droid
{
    public class RoundedEditorRenderer:EditorRenderer
    {

        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Background = Xamarin.Forms.Forms.Context.GetDrawable(Resource.Drawable.RoundedEditText);
            }
        }
    }
}