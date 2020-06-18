using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMultiLanguage.Services
{
    public interface IRefreshUI
    {
        public event Action RefreshRequested;
        public void CallRequestRefresh();
    }
}
