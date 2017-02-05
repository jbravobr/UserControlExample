using Prism.Services;
using Xamarin.Forms;
using System;

using System.Collections.ObjectModel;
using System.Collections.Generic;

using ViewAsComponentExample.Models;
using PropertyChanged;

namespace ViewAsComponentExample.ViewModels
{
    [ImplementPropertyChanged]
    public class HomePageViewModel : BaseViewModel
    {
        public ObservableCollection<Person> Persons { get; set; }
        public bool isPullToRefreshing { get; set; } = false;

        readonly IConnectivityFunctions _connectivityFunctions;

        public HomePageViewModel(IConnectivityFunctions connectivityFunctions)
        {
            _connectivityFunctions = connectivityFunctions;
            LoadPersons();
        }

        public Command PullToRefresh
        {
            get
            {
                return new Command(async () =>
                {
                    try
                    {
                        if (!await _connectivityFunctions.IsConnected())
                        {
                            InternetConnStatus = false;
                            return;
                        }

                        isPullToRefreshing = true;
                        LoadPersons();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        isPullToRefreshing = false;
                    }
                });
            }
        }

        void LoadPersons()
        {
            if (Persons != null)
                return;

            var persons = new List<Person>();

            if (!isPullToRefreshing)
            {
                var p1 = new Person
                {
                    FirstName = "Rodrigo",
                    LastName = "Amaral",
                    Location = "Rio de Janeiro - Brasil"
                };
                persons.Add(p1);

                var p2 = new Person
                {
                    FirstName = "Débora",
                    LastName = "Emídio",
                    Location = "Rio de Janeiro - Brasil"
                };
                persons.Add(p2);

                var p3 = new Person
                {
                    FirstName = "Renata",
                    LastName = "Amaral",
                    Location = "Rio de Janeiro - Brasil"
                };
                persons.Add(p3);
            }
            else
            {
                var p1 = new Person
                {
                    FirstName = "Renan",
                    LastName = "Amaral",
                    Location = "Rio de Janeiro - Brasil"
                };
                persons.Add(p1);

                var p2 = new Person
                {
                    FirstName = "Daniel",
                    LastName = "Castro",
                    Location = "Rio de Janeiro - Brasil"
                };
                persons.Add(p2);

                var p3 = new Person
                {
                    FirstName = "Paulo",
                    LastName = "Amaral",
                    Location = "Rio de Janeiro - Brasil"
                };
                persons.Add(p3);
            }

            Persons = new ObservableCollection<Person>(persons);
        }
    }
}