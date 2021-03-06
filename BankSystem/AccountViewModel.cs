﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Data.Repositories;
using sinkien.IBAN4Net;

namespace BankSystem
{
    public class AccountViewModel
    {
        private Account _account;
        private Client _client;
        private City _city;
        private AccountRepository _accountRepository;
        private ClientRepository _clientRepository;
        private CityRepository _cityRepository;

        public AccountViewModel(int accountId)
        {
            _accountRepository = new AccountRepository();
            _clientRepository = new ClientRepository();
            _cityRepository = new CityRepository();
            _account = _accountRepository.LoadAccount(accountId);
            _client = _clientRepository.LoadClient(_account.IdClient);
            _city = _cityRepository.LoadCity(_client.IdCity);
        }
        public AccountViewModel()
        {
            _accountRepository = new AccountRepository();
            _clientRepository = new ClientRepository();
            _cityRepository = new CityRepository();
            _account = new Account();
            _client = new Client();
            _city = new City();
        }

        #region AccountGetters
        public DateTime GetAccountCreatioDate()
        {
            return _account.CreationDate;
        }
        public DateTime GetAccoutExpireDate()
        {
            return _account.ExpireDate;
        }
        public Decimal GetAccountAmount()
        {
            return _account.Amount;
        }
        public string GetAccountIBA()
        {
            return _account.IBAN;
        }
        public decimal GetAccountActualOverFlow()
        {
            return _account.ActualOverFlow;
        }
        public decimal GetAccountOverFlowLimit()
        {
            return _account.OverFlowLimit;
        }
        #endregion

        #region ClientGetters
        public string GetClientFirstName()
        {
            return _client.FirstName;
        }
        public string GetClientLastName()
        {
            return _client.LastName;
        }
        public string GetClientAdress()
        {
            return _client.Adress;
        }
        public string GetClientIdNumber()
        {
            return _client.IdNumber;
        }
        #endregion

        #region CityGetters
        public string GetCityName()
        {
            return _city.Name;
        }
        public string GetCityPostalCode()
        {
            return _city.PostalCode;
        }
        #endregion

        #region AccountSetters
        public void SetAccountOverFlowLimit(decimal overFlowLImit)
        {
            _account.OverFlowLimit = overFlowLImit;
        }
        public void SetAccountIban(string IBAN)
        {
            _account.IBAN = IBAN;
        }
        #endregion

        #region Client Setters
        public void SetClientFirstName(string firstName)
        {
            _client.FirstName = firstName;
        }
        public void SetClientlastName(string lastName)
        {
            _client.LastName = lastName;
        }
        public void SetClientAdress(string adress)
        {
            _client.Adress = adress;
        }
        public void SetClientIdNumber(string idNumber)
        {
            _client.IdNumber = idNumber;
        }
        #endregion

        #region CitySetters
        public void SetCityName(string cityname)
        {
            _city.Name = cityname;
        }
        public void SetCityPostaCode(string postalCode)
        {
            _city.PostalCode = postalCode;
        }
        #endregion

        public void UpdateAccountOverFlowLimit()
        {
            _accountRepository.UpdateAccountOverFlowLimit(_account);
        }
        public void UpdateClient()
        {
            _clientRepository.UpdateClient(_client);
        }
        public void UpdateCity()
        {
            _cityRepository.UpdateCity(_city);
        }

        public void InsertAccount()
        {
            _accountRepository.InsertAccount(_account);
        }
        public void InserClient()
        {
            _client.Id = _clientRepository.InsertClient(_client);
            _account.IdClient = _client.Id;
        }
        public void InsertCity()
        {
            _city.Id =_cityRepository.InsertCity(_city);
            _client.IdCity = _city.Id;
        }

        public string GenerateIBAN()
        {
            Random r = new Random();
            Iban iban = new IbanBuilder()
                .CountryCode(CountryCode.GetCountryCode("SK"))
                .BankCode(r.Next(10000).ToString())
                .AccountNumberPrefix(r.Next(1000000).ToString())
                .AccountNumber(r.Next(Int32.MaxValue).ToString())
                .Build();
            return iban.Value.ToString();
        }

    }
}
