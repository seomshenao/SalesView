using System;
using System.Collections.Generic;
using System.Text;

namespace SalesView.ViewModels
{
    public class MainViewModel
    {
        #region Poperties
        public LoginViewModel Login { get; set; }
        #endregion

        #region C'tor
        public MainViewModel()
        {
            Login = new LoginViewModel();
        }
        #endregion

    }
}
