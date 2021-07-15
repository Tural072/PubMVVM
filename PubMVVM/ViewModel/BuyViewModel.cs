using PubMVVM.Model;
using PubMVVM.Repostory;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubMVVM.ViewModel
{
    public class BuyViewModel:BaseViewModel
    {
        private Pub Pub;

        public Pub MyProperty
        {
            get { return Pub; }
            set { Pub = value;OnPropertyChanged();}
        }

       
    }
}
