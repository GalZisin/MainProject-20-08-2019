﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManagement
{
    public interface ILoggedInAdministratorFacade
    {
        long CreateNewAirline(LoginToken<Administrator> token, AirlineCompany airline);
        void UpdateAirlineDetails(LoginToken<Administrator> token, AirlineCompany customer);
        void RemoveAirline(LoginToken<Administrator> token, AirlineCompany airline);
        long CreateNewCustomer(LoginToken<Administrator> token, Customer customer);
        void UpdateCustomerDetails(LoginToken<Administrator> token, Customer customer);
        void RemoveCustomer(LoginToken<Administrator> token, Customer customer);
        Customer GetCustomerById(LoginToken<Administrator> token, long customerId);
        AirlineCompany GetAirlineCompanyById(LoginToken<Administrator> token, long airlineCompanyId);
        long CreateNewCountry(LoginToken<Administrator> token, Country country);
        Country GetCountryByCode(LoginToken<Administrator> token, long CountryCode);
        void RemoveCountry(LoginToken<Administrator> token, Country country);
        IList<Customer> GetAllCustomers(LoginToken<Administrator> token);
        Customer GetCustomerByUserName(LoginToken<Administrator> token, string userName);
        Country GetCountryByName(LoginToken<Administrator> token, string countryName);
        AirlineCompany GetAirlineCompanyByAirlineName(LoginToken<Administrator> token, string AirlineName);
    }
}
