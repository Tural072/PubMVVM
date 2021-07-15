using PubMVVM.Model;
using PubMVVM.Repostory;
using PubMVVM.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubMVVM.ViewModel
{
    public class MainViewModel:BaseViewModel
    {
        public MainWindow MainWindow { get; set; }
        public FakeRepo PubRepostory { get; set; }
        public ObservableCollection<Pub> Pubs { get; set; }
        private Pub pub;

        public Pub Pub
        {
            get { return pub; }
            set { pub = value; OnPropertyChanged(); }
        }
        public RelayCommand ShowHistoryCommand { get; set; }
        public RelayCommand BuyCommand { get; set; }
        public RelayCommand ResetCommand { get; set; }
        public RelayCommand SelectedItemChangedCommand { get; set; }
        public BuyWindow BuyWindow { get; set; }
        public MainViewModel()
        {
            PubRepostory = new FakeRepo();
            Pubs = new ObservableCollection<Pub>(PubRepostory.GetAll());

            SelectedItemChangedCommand = new RelayCommand((SelectedItem) =>
            {
                var item = SelectedItem as Pub;
                Pub = item;
                //MainWindow.Mimage.Source = new BitmapImage(new Uri(
                // Pub.ImagePath, UriKind.RelativeOrAbsolute));
            });
        }
    }
}
