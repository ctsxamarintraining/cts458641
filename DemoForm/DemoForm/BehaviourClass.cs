using System;
using Xamarin.Forms;

namespace DemoForm
{
	public class BehaviourClass:Behavior<Entry>
	{
		
		protected override void OnAttachedTo (Entry entry)
		{
			entry.TextChanged += OnEntryTextChanged;
			base.OnAttachedTo (entry);
		}

		protected override void OnDetachingFrom (Entry entry)
		{
			entry.TextChanged -= OnEntryTextChanged;
			base.OnDetachingFrom (entry);
		}

		void OnEntryTextChanged (object sender, TextChangedEventArgs args)
		{
			double result;
			bool isValid = true;

			if (args.NewTextValue == "") {
				isValid = false;
			}
	
				
			((Entry)sender).BackgroundColor = isValid ? Color.Default : Color.Red;
		}

	}
}


