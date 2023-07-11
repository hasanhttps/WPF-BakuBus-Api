using System;
using System.Windows;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Media;
using System.ComponentModel;
using WPF_Bind_Map_Lesson.Models;
using System.Collections.Generic;
using Microsoft.Maps.MapControl.WPF;
using WPF_Bind_Map_Lesson.ViewModels;
using WPF_Bind_Map_Lesson.Commands;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Input;

 

namespace WPF_Bind_Map_Lesson.Views {
    public partial class MainView : Window, INotifyPropertyChanged {

        private Bakubus? myBuses;
        private List<string> BusNames = new();
        public Attributes Bus { get; set; } = new();
        public Bakubus? MyBuses { 
            get => myBuses; 
            set {
                myBuses = value;
                INotifyPropertyChanged();
            } 
        }
        private List<Pushpin> pushpins = new();

 

        public MainView() {
            InitializeComponent();
            DataContext = new MainViewModel(BusNames, pushpins, MyBuses, SearchFilterBus, Map, Bus);
        }

 

        private async void Window_Loaded(object sender, RoutedEventArgs e) {
            var client = new HttpClient();
            var jsonStr = await client.GetStringAsync("https://raw.githubusercontent.com/CavidAtamoghlanov/newBakuBus/main/BakuBusApi");

            MyBuses = JsonSerializer.Deserialize<Bakubus>(jsonStr);
            BusNames.Add("All");

 

            foreach(var bus in MyBuses!.BUS) {
                if (!BusNames.Contains(bus.attributes.DISPLAY_ROUTE_CODE))
                    BusNames.Add(bus.attributes.DISPLAY_ROUTE_CODE);

                Pushpin pushpin = new Pushpin();
                pushpin.Content = bus.attributes.DISPLAY_ROUTE_CODE;
                pushpin.Tag = bus.attributes;
                pushpin.MouseEnter += PushPinMouseHover;
                pushpin.ToolTip = new();

                Location location = new Location(Convert.ToDouble(bus.attributes.LATITUDE), Convert.ToDouble(bus.attributes.LONGITUDE));
                pushpin.Location = location;

 

                pushpins.Add(pushpin);
                Map.Children.Add(pushpin);
            }
            SearchFilterBus.ItemsSource = BusNames;

 

            foreach(var busname in BusNames) {
                SolidColorBrush colorBrush = new SolidColorBrush() {
                    Color = Color.FromRgb((byte)Random.Shared.Next(0, 255), (byte)Random.Shared.Next(0, 255), (byte)Random.Shared.Next(0, 255))
                };
                pushpins.ForEach((Pushpin) => {
                    if (busname == Pushpin.Content as string) Pushpin.Background = colorBrush;
                });
            }
        }

 

        private void PushPinMouseHover(object sender, MouseEventArgs e) {
            Attributes attributes = ((sender as Pushpin).Tag as Attributes)!;
            Bus.BUS_ID = attributes.BUS_ID;
            Bus.PREV_STOP = attributes.PREV_STOP;
            Bus.CURRENT_STOP = attributes.CURRENT_STOP;
            Bus.DISPLAY_ROUTE_CODE = attributes.DISPLAY_ROUTE_CODE;
            Bus.ROUTE_NAME = attributes.ROUTE_NAME;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        void INotifyPropertyChanged([CallerMemberName] string? name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}