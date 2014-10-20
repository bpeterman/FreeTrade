using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace FreeTrade.ViewModels
{
    class TradeViewModel : ViewModelBase
    {
        private string companyName;
        
        public ObservableCollection<
        

        public TradeViewModel()
        {

        }

        #region PROPERTIES

        public string CompanyName
        {
            get
            {
                return companyName;
            }
            set
            {
                if (companyName != value)
                {
                    companyName = value;
                    RaisePropertyChanged("CompanyName");
                }
            }
        }

        #endregion PROPERTIES
    }
}
