﻿using EmployeesManager.Domain.Entities.Employees;
using EmployeesManager.Domain.Interfaces.Repositories;

namespace EmployeesManager.Infra.Repositories
{
    public class ContactRepository : Repository<Contact>, IContactRepository
    {
        public ContactRepository(EmployeesManagerDBContext context) : base(context) { }
    }
}
