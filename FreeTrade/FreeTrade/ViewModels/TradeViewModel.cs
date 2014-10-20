using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Collections.ObjectModel;
using FreeTrade.Models;
using FreeTrade.Helpers;

namespace FreeTrade.ViewModels
{
    class TradeViewModel : ViewModelBase
    {
        public Search searchHelper = new Search();

        private string companyName;
        private string searchTerm;

        public ObservableCollection<Company> Companies;
        
        public TradeViewModel()
        {
            searchHelper.initialize();
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

        public string SearchTerm
        {
            get
            {
                return searchTerm;
            }
            set
            {
                if (searchTerm != value)
                {
                    searchTerm = value;
                    RaisePropertyChanged("SearchTerm");
                }
            }
        }

        #endregion PROPERTIES

        #region METHODS
        public void Search()
        {
            Companies = searchHelper.search(searchTerm);
            RaisePropertyChanged("Companies");
        }

        public bool CanSearch()
        {
            return true;
        }
        #endregion METHODS

        #region COMMANDS
        private ICommand searchCommand;

        public ICommand SearchCommand
        {
            get
            {
                if (searchCommand == null)
                {
                    searchCommand = new RelayCommand(
                        param => this.Search(),
                        param => this.CanSearch()
                    );
                }
                return searchCommand;
            }
        }
        #endregion COMMANDS
    }
}
