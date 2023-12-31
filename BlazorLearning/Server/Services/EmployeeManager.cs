﻿using BlazorLearning.Data.Repository.Interface;
using BlazorLearning.Server.Interfaces;
using BlazorLearning.Shared.ViewModel;

namespace BlazorLearning.Server.Services
{
    public class EmployeeManager : IEmployeeManager
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeManager(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<EmployeeViewModel> AddEmployee(EmployeeViewModel employee)
        {
           return await _employeeRepository.AddEmployee(employee);
        }

        public async Task DeleteEmployee(int id)
        {
            await _employeeRepository.DeleteEmployee(id);
        }

        public async Task<EmployeeViewModel> GetEmployeeData(int id)
        {
            return await _employeeRepository.GetEmployeeData(id);
        }

        public async Task<List<EmployeeViewModel>> GetEmployeeDetails()
        {
            try
            {
                var result = await _employeeRepository.GetEmployeeDetails();
                return result;
            }
            catch (Exception ex)
            {
                return new List<EmployeeViewModel>();
            }

        }

        public async Task<EmployeeViewModel> UpdateEmployeeDetails(EmployeeViewModel employee)
        {
            return await _employeeRepository.UpdateEmployeeDetails(employee);
        }
    }
}
