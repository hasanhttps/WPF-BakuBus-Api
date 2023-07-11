using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WPF_Bind_Map_Lesson.Commands;
using WPF_Bind_Map_Lesson.Models;

namespace WPF_Bind_Map_Lesson.ViewModels {
    public class MainViewModel : INotifyPropertyChanged {

        // Private Fields

        private Bakubus? myBuses;
        private List<string> BusNames = new();
        private List<Pushpin> pushpins = new();
        private ComboBox SearchFilterBus;
        private Map Map;
        private int busCount = 233;

        // Properties

        public ICommand? SearchCommand { get; set; }

        public Bakubus? MyBuses { 
            get => myBuses; 
            set {
                myBuses = value;
                INotifyPropertyChanged();
            } 
        }
        public int BusCount { get => busCount;
            set {
                busCount = value;
                INotifyPropertyChanged();
            }
        }
        public Attributes Bus { get; set; }

        // Constructors

        public MainViewModel() { }
        public MainViewModel(List<string> busNames, List<Pushpin> pushPins, Bakubus bakubuses, ComboBox searchFilterBus, Map map, Attributes attributes) {

            SearchFilterBus = searchFilterBus;
            myBuses = bakubuses;
            BusNames = busNames;
            pushpins = pushPins;
            Map = map;
            Bus = attributes;
            SearchCommand = new RelayCommand(SearchButtonCommand);
        }

        // Command Functions

        private void SearchButtonCommand(object? param) {
            BusCount = 0;
            Map.Children.Clear();
            string routecode = (SearchFilterBus.SelectedItem as string)!;
            if (routecode == "All") {
                foreach (var pushpin in pushpins) {
                    Map.Children.Add(pushpin);
                    BusCount++;
                }
                return; 
            }
            foreach(var busname in BusNames) {
                if (busname == routecode)
                    foreach (var pushpin in pushpins) {
                        if (pushpin.Content.ToString() == routecode) {
                            Map.Children.Add(pushpin);
                            BusCount++;
                        }
                    }
            }

        }

        // INotifyPropertyChanged

        public event PropertyChangedEventHandler? PropertyChanged;
        void INotifyPropertyChanged([CallerMemberName] string? name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
