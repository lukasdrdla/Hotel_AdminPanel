using Hotel_AdminPanel.Application.Interfaces;
using Hotel_AdminPanel.Domain.Entities;
using Hotel_AdminPanel.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_AdminPanel.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ApplicationDbContext _context;

        public CustomerService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateCustomerAsync(Customer customer)
        {
            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();

        }

        public async Task DeleteCustomerAsync(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return;
            }

            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();

        }

        public async Task<Customer> GetCustomerByIdAsync(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            return customer;
        }

        public async Task<List<Customer>> GetCustomersAsync()
        {
            var customers = await _context.Customers.ToListAsync();
            return customers;
        }

        public async Task UpdateCustomerAsync(Customer customer)
        {
            var existingCustomer = await _context.Customers.FindAsync(customer.Id);
            if (existingCustomer == null)
            {
                return;

            }

            existingCustomer.FirstName = customer.FirstName;
            existingCustomer.LastName = customer.LastName;
            existingCustomer.DocumentNumber = customer.DocumentNumber;
            existingCustomer.PlaceOfBirth = customer.PlaceOfBirth;
            existingCustomer.DateOfBirth = customer.DateOfBirth;
            existingCustomer.DateOfIssue = customer.DateOfIssue;
            existingCustomer.DateOfExpiry = customer.DateOfExpiry;
            existingCustomer.PersonalIdentificationNumber = customer.PersonalIdentificationNumber;
            existingCustomer.Email = customer.Email;
            existingCustomer.Phone = customer.Phone;
            existingCustomer.Address = customer.Address;
            existingCustomer.City = customer.City;
            existingCustomer.Country = customer.Country;
            existingCustomer.PostalCode = customer.PostalCode;

            _context.Customers.Update(existingCustomer);
            await _context.SaveChangesAsync();
        }
    }
}
