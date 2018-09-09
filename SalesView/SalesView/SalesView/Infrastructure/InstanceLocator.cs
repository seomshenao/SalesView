using SalesView.ViewModels;

namespace SalesView.Infrastructure
{
    public class InstanceLocator
    {
        #region Poperties
        public MainViewModel Main { get; set; }
        #endregion

        #region C'tor
        public InstanceLocator()
        {
            Main = new MainViewModel();
        }
        #endregion
    }
}
