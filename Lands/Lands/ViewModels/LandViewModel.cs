
namespace Lands.ViewModels
{
    using Models;

    public class LandViewModel
    {
        #region Properties
        public Land Land
        {
            get;
            set;
        }
        #endregion

        #region Contructors
        public LandViewModel(Land land)
        {
            this.Land = land;
        }
        #endregion

    }
}
