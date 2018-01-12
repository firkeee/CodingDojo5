using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace CodingDojo5.ViewModel
{
    public class ItemVm : ViewModelBase
    {
        public ItemVm(string description, BitmapImage image, string ageRec)
        {
            Description = description;
            Image = image;
            AgeRec = ageRec;
        }
        public ObservableCollection<ItemVm> Items { get; set; }
        public string Description { get; set; }
        public BitmapImage Image { get; set; }
        public string AgeRec { get; set; }

        public void AddItem(ItemVm item)
        {
            if (Items == null)
                Items = new ObservableCollection<ItemVm>();

            Items.Add(item);
        }
    }
}