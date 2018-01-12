using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using System;
using System.Windows.Media.Imaging;
using GalaSoft.MvvmLight.CommandWpf;

namespace CodingDojo5.ViewModel
{
   
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<ItemVm> MainItems { get; set; }
        public ObservableCollection<ItemVm> Cart { get; set; }
        private RelayCommand<ItemVm> buyBtnClickedCmd;

        public RelayCommand<ItemVm> BuyBtnClickedCmd
        {
            get { return buyBtnClickedCmd; }
            set { buyBtnClickedCmd = value; RaisePropertyChanged(); }
        }


        private ItemVm selectedItem;

        public ItemVm SelectedItem
        {
            get { return selectedItem; }
            set { selectedItem = value; RaisePropertyChanged(); }

        }

        public MainViewModel()
        {
            MainItems = new ObservableCollection<ItemVm>();
            Cart = new ObservableCollection<ItemVm>();
            BuyBtnClickedCmd = new RelayCommand<ItemVm>((p)=> 
            {
                Cart.Add(p);
            }, (p)=> { return true; });
            
            GenerateData();
            SelectedItem = MainItems[0];
            
        }
        

        private void GenerateData()
        {
            MainItems.Add(new ItemVm("My Lego", new BitmapImage(new Uri("Images/lego1.jpg", UriKind.Relative)), "5-10"));
            MainItems.Add(new ItemVm("My Playmobil", new BitmapImage(new Uri("Images/playmobil1.jpg", UriKind.Relative)), "6+"));
            MainItems[0].AddItem(new ItemVm("Helicopter", new BitmapImage(new Uri("Images/lego1.jpg", UriKind.Relative)), "5-10"));
            MainItems[0].AddItem(new ItemVm("Machine", new BitmapImage(new Uri("Images/lego2.jpg", UriKind.Relative)), "1-3"));
            MainItems[0].AddItem(new ItemVm("New Machine", new BitmapImage(new Uri("Images/lego3.jpg", UriKind.Relative)), "3-7"));
            MainItems[0].AddItem(new ItemVm("Digger", new BitmapImage(new Uri("Images/lego4.jpg", UriKind.Relative)), "10+"));
            MainItems[1].AddItem(new ItemVm("House", new BitmapImage(new Uri("Images/playmobil1.jpg", UriKind.Relative)), "6+"));
            MainItems[1].AddItem(new ItemVm("Package", new BitmapImage(new Uri("Images/playmobil2.jpg", UriKind.Relative)), "2-7"));
            MainItems[1].AddItem(new ItemVm("Warriors", new BitmapImage(new Uri("Images/playmobil3.jpg", UriKind.Relative)), "3-6"));

        }
    }
}