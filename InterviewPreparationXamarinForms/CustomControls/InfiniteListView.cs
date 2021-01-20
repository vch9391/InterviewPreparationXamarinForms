﻿using System.Collections;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;

namespace InterviewPreparationXamarinForms.CustomControls
{
	/// <summary>
	/// A simple listview that exposes a bindable command to allow infinite loading behaviour.
	/// </summary>
	public class InfiniteListView : ListView
	{
		/// <summary>
		/// Respresents the command that is fired to ask the view model to load additional data bound collection.
		/// </summary>
		public static readonly BindableProperty LoadMoreCommandProperty =
			BindableProperty.Create(nameof(LoadMoreCommandProperty), typeof(ICommand), typeof(InfiniteListView), default(ICommand));

		/// <summary>
		/// Gets or sets the command binding that is called whenever the listview is getting near the bottomn of the list, and therefore requiress more data to be loaded.
		/// </summary>
		public ICommand LoadMoreCommand
		{
			get { return (ICommand)GetValue(LoadMoreCommandProperty); }
			set { SetValue(LoadMoreCommandProperty, value); }
		}

		/// <summary>
		/// Creates a new instance of a <see cref="InfiniteListView" />
		/// </summary>
		public InfiniteListView()
		{
			ItemAppearing += InfiniteListView_ItemAppearing;
		}


		void InfiniteListView_ItemAppearing(object sender, ItemVisibilityEventArgs e)
		{
			var items = ItemsSource as IList;

			Debug.WriteLine($"{e.Item.ToString()} :: {items[items.Count - 1]}");

			if (items != null && e.Item == items[items.Count - 1])
			{
				if (LoadMoreCommand != null && LoadMoreCommand.CanExecute(null))
					LoadMoreCommand.Execute(null);
			}
		}


	}
}
