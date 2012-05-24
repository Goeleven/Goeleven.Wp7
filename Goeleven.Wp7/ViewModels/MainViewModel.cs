using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Collections.ObjectModel;


namespace Goeleven.Wp7
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            this.Items = new ObservableCollection<ItemViewModel>();
        }

        /// <summary>
        /// A collection for ItemViewModel objects.
        /// </summary>
        public ObservableCollection<ItemViewModel> Items { get; private set; }

        private string _sampleProperty = "Sample Runtime Property Value";

        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding
        /// </summary>
        /// <returns></returns>
        public string SampleProperty
        {
            get { return _sampleProperty; }
            set
            {
                if (value != _sampleProperty)
                {
                    _sampleProperty = value;
                    NotifyPropertyChanged("SampleProperty");
                }
            }
        }

        public bool IsDataLoaded { get; private set; }

        /// <summary>
        /// Creates and adds a few ItemViewModel objects into the Items collection.
        /// </summary>
        public void LoadData()
        {
            // Sample data; replace with real data
            this.Items.Add(new ItemViewModel()
                               {
                                   LineOne = "Maarten Balliauw",
                                   Image = "/Images/f62ebe822f6b351538e68cb2bbadefe9.jpeg",
                                   NumberOfComments = "7 Comments",
                                   LineTwo = "Hoe plaats je best een glazen deur zonder brokken te maken?",
                                   LineThree =
                                       "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"
                               });
            this.Items.Add(new ItemViewModel()
                               {
                                   LineOne = "Yves Goeleven",
                                   Image = "/Images/9925a436e7c82740344087c39ed1a078.jpeg",
                                   NumberOfComments = "1 Comment",
                                   LineTwo =
                                       "Ik heb een acer, waarvan de bladknopjes bevroren zijn. Gaat die nog bladeren krijgen dit jaar, gaat ie dood gaan, of is het gewoon een jaartje wachten?",
                                   LineThree =
                                       "Suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus"
                               });
            this.Items.Add(new ItemViewModel()
                               {
                                   LineOne = "Kristof Rennen",
                                   Image = "/Images/8909a2d7205fecc4481ddbbe30abfd2e.jpeg",
                                   NumberOfComments = "15 Comments",
                                   LineTwo =
                                       "Verf verwijderen van deurlijsten. Hoe kan ik dit doen zonder mijn hout te beschadigen?",
                                   LineThree =
                                       "Habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu suscipit torquent"
                               });
            this.Items.Add(new ItemViewModel()
                               {
                                   LineOne = "Maarten Balliauw",
                                   Image = "/Images/f62ebe822f6b351538e68cb2bbadefe9.jpeg",
                                   NumberOfComments = "3 Comments",
                                   LineTwo =
                                       "Grasmachine proper maken. Hoe doen jullie dit, ik krijg altijd op mijn kop van schoonvader dat ie niet proper genoeg is...",
                                   LineThree =
                                       "Ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos"
                               });
            this.Items.Add(new ItemViewModel()
                               {
                                   LineOne = "Yves Goeleven",
                                   Image = "/Images/9925a436e7c82740344087c39ed1a078.jpeg",
                                   NumberOfComments = "0 Comments",
                                   LineTwo =
                                       "Ik zou een betonnen voet moeten maken voor een droogmolen, hoe groot zou die moeten zijn?",
                                   LineThree =
                                       "Maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos interdum lobortis nascetur"
                               });

            this.IsDataLoaded = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
