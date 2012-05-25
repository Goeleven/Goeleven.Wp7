using System;
using System.Windows;
using System.Windows.Input;
using Microsoft.Phone.Controls;

namespace Goeleven.Wp7
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
            Loaded += MainPage_Loaded;

            inboxGrid.Tap += inboxGrid_Tap;
            projectsGrid.Tap += projectsGrid_Tap;
            calendarGrid.Tap += calendarGrid_Tap;
            marketplaceGrid.Tap += marketplaceGrid_Tap;

            homeGrid.Tap += homeGrid_Tap;
            gardenGrid.Tap += gardenGrid_Tap;
            officeGrid.Tap += officeGrid_Tap;
            outsideGrid.Tap += outsideGrid_Tap;
            onthegoGrid.Tap += onthegoGrid_Tap;

           
        }

        void addActionMenuItem_Click(object sender, EventArgs e)
        {
            Dispatcher.BeginInvoke(() => NavigationService.Navigate(new Uri("/Forms/AddAction.xaml", UriKind.Relative)));
        }

        void addInboxItemMenuItem_Click(object sender, EventArgs e)
        {
            Dispatcher.BeginInvoke(() => NavigationService.Navigate(new Uri("/Forms/AddInboxItem.xaml", UriKind.Relative)));
        }

        void settings_Click(object sender, EventArgs e)
        {
            Dispatcher.BeginInvoke(() => NavigationService.Navigate(new Uri("/Forms/Settings.xaml", UriKind.Relative)));
        }

        void gotoCurrentContext_Click(object sender, EventArgs e)
        {
            Dispatcher.BeginInvoke(() => NavigationService.Navigate(new Uri("/Pages/NextActions.xaml", UriKind.Relative)));
        }

        void askQuestion_Click(object sender, EventArgs e)
        {
            Dispatcher.BeginInvoke(() => NavigationService.Navigate(new Uri("/Forms/AskQuestion.xaml", UriKind.Relative)));
        }

        void addInboxItem_Click(object sender, EventArgs e)
        {
            Dispatcher.BeginInvoke(() => NavigationService.Navigate(new Uri("/Forms/AddInboxItem.xaml", UriKind.Relative)));
        }

        void onthegoGrid_Tap(object sender, GestureEventArgs e)
        {
            Dispatcher.BeginInvoke(() => NavigationService.Navigate(new Uri("/Pages/NextActions.xaml", UriKind.Relative)));
        }

        void outsideGrid_Tap(object sender, GestureEventArgs e)
        {
            Dispatcher.BeginInvoke(() => NavigationService.Navigate(new Uri("/Pages/NextActions.xaml", UriKind.Relative)));
        }

        void officeGrid_Tap(object sender, GestureEventArgs e)
        {
            Dispatcher.BeginInvoke(() => NavigationService.Navigate(new Uri("/Pages/NextActions.xaml", UriKind.Relative)));
        }

        void gardenGrid_Tap(object sender, GestureEventArgs e)
        {
            Dispatcher.BeginInvoke(() => NavigationService.Navigate(new Uri("/Pages/NextActions.xaml", UriKind.Relative)));
        }

        void homeGrid_Tap(object sender, GestureEventArgs e)
        {
            Dispatcher.BeginInvoke(() => NavigationService.Navigate(new Uri("/Pages/NextActions.xaml", UriKind.Relative)));
        }

        void marketplaceGrid_Tap(object sender, GestureEventArgs e)
        {
            Dispatcher.BeginInvoke(() => NavigationService.Navigate(new Uri("/Pages/Marketplace.xaml", UriKind.Relative)));
        }

        void calendarGrid_Tap(object sender, GestureEventArgs e)
        {
            Dispatcher.BeginInvoke(() => NavigationService.Navigate(new Uri("/Pages/Calendar.xaml", UriKind.Relative)));
        }

        void projectsGrid_Tap(object sender, GestureEventArgs e)
        {
            Dispatcher.BeginInvoke(() => NavigationService.Navigate(new Uri("/Pages/Projects.xaml", UriKind.Relative)));
        }

        void inboxGrid_Tap(object sender, GestureEventArgs e)
        {
            Dispatcher.BeginInvoke(() => NavigationService.Navigate(new Uri("/Pages/Inbox.xaml", UriKind.Relative)));
        }

        private void questionGrid_Tap(object sender, GestureEventArgs e)
        {
            Dispatcher.BeginInvoke(() => NavigationService.Navigate(new Uri("/Pages/Question.xaml", UriKind.Relative)));
        }


        // Load data for the ViewModel Items
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        

        


    }
}