﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ExxerIoT.Domain.Models;
using NetDevPack.Data;

namespace ExxerIoT.Domain.Interfaces
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Task<Customer> GetById(Guid id);
        Task<Customer> GetByEmail(string email);
        Task<IEnumerable<Customer>> GetAll();

        void Add(Customer customer);
        void Update(Customer customer);
        void Remove(Customer customer);
    }
}