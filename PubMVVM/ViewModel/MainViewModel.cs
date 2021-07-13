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
    public class MainViewModel
    {
        public MainWindow MainWindow { get; set; }
        public FakeRepo PubRepostory { get; set; }
        public ObservableCollection<Pub> Pubs { get; set; }
        public MainViewModel()
        {
            PubRepostory = new FakeRepo();
            Pubs = new ObservableCollection<Pub>(PubRepostory.GetAll());
        }
    }
}
