using BlazorMultiLanguage.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMultiLanguage.Classes
{
    public class RefreshUI : IRefreshUI
    {
        public event Action RefreshRequested;

        public void CallRequestRefresh()
        {
            RefreshRequested?.Invoke();
        }
    }
}
