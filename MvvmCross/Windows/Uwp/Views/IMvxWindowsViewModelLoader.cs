﻿// IMvxAndroidViewsContainer.cs

// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
//
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

namespace MvvmCross.Uwp.Views
{
    using System;
    using MvvmCross.Core.ViewModels;

    public interface IMvxWindowsViewModelLoader
    {
        IMvxViewModel Load(string requestText, IMvxBundle savedState);
    }
}
