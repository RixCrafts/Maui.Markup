﻿using CommunityToolkit.Maui.Markup.Sample.Constants;
using CommunityToolkit.Maui.Markup.Sample.ViewModels.Base;

namespace CommunityToolkit.Maui.Markup.Sample.Pages.Base;

abstract class BaseContentPage<T> : ContentPage where T : BaseViewModel
{
	protected BaseContentPage(T viewModel, string pageTitle)
	{
		base.BindingContext = viewModel;

		Title = pageTitle;
		BackgroundColor = ColorConstants.PageBackgroundColor;
	}

	protected new T BindingContext => (T)base.BindingContext;
}