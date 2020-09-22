using Core.Model;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.ViewModel
{
    public class DetailViewModel : MvxViewModel<User>
    {
        private string name;
        private string username;
        private string email;
        private string street;
        private string suite;
        private string city;
        private string zipCode;
        private string phone;
        private string website;

        public string Name
        {
            get => name; set
            {
                name = value;
                RaisePropertyChanged(() => Name);
            }
        }
        public string Username
        {
            get => username; set
            {
                username = value;
                RaisePropertyChanged(() => Username);
            }
        }
        public string Email
        {
            get => email; set
            {
                email = value;
                RaisePropertyChanged(() => Email);
            }
        }
        public string Street
        {
            get => street; set
            {
                street = value;
                RaisePropertyChanged(() => Street);
            }
        }
        public string Suite
        {
            get => suite; set
            {
                suite = value;
                RaisePropertyChanged(() => Suite);
            }
        }
        public string City
        {
            get => city; set
            {
                city = value;
                RaisePropertyChanged(() => City);
            }
        }
        public string ZipCode
        {
            get => zipCode; set
            {
                zipCode = value;
                RaisePropertyChanged(() => ZipCode);
            }
        }
        public string Phone
        {
            get => phone; set
            {
                phone = value;
                RaisePropertyChanged(() => Phone);
            }
        }
        public string Website
        {
            get => website; set
            {
                website = value;
                RaisePropertyChanged(() => Website);
            }
        }

        public override void Prepare(User parameter)
        {
            Name = parameter.Name;
            Username = parameter.Username;
            Email = parameter.Email;
            Street = parameter.Address.Street;
            Suite = parameter.Address.Suite;
            City = parameter.Address.City;
            ZipCode = parameter.Address.Zipcode;
            Phone = parameter.Phone;
            Website = parameter.Website;
        }
    }
}
