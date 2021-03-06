// IMvxTvosNavigator.cs

// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
//
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

namespace MvvmCross.tvOS.Views
{
    using MvvmCross.Core.ViewModels;

    public interface IMvxTvosNavigator
    {
        void NavigateTo(MvxViewModelRequest request);

        void Close(IMvxViewModel toClose);
    }
}