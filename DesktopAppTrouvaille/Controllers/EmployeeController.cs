using DesktopAppTrouvaille.Exceptions;
using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille.Processors;
using System;
using System.Collections.Generic;

namespace DesktopAppTrouvaille.Controllers
{  
    public class EmployeeController : Controller
    {
        private List<Employee> _employees;
        private Employee _detailEmployee;
        private EmployeeProcessor _processor = new EmployeeProcessor();

        public override int GetCount()
        {
            return _iterator.Count;
        }

        public override IEnumerable<IModel> GetModels()
        {
            return _employees;
        }

        public Employee GetDetailEmployee()
        {
            return _detailEmployee;
        }

        public override void Search(string searchText)
        {
            // No Search for Employees
        }

        public override void SelectDetailModel(IModel model)
        {
            if(model is Employee)
            {
                _detailEmployee = (Employee)model;
            }
        }

        public async override void UpdateData()
        {
            try
            {
                _iterator.Count = await _processor.GetCount();
                _employees = await _processor.GetEmployees(_iterator.From, _iterator.To);
                _state = State.OK;
                
            }
            catch (GETException e)
            {
                _state = State.ConnectionError;
            }
            finally
            {
                UpdateView();
            }
        }

        public async void SaveNewEmployee(RegisterEmployeeModel employee)
        {
            try
            {
                if(await _processor.RegisterNewEmployee(employee))
                {
                    _state = State.Saved;
                }
                else
                {
                    _state = State.SaveFailed;
                }
            }
            catch(Exception e)
            {
                _state = State.ConnectionError;
            }
            UpdateData();
        }

        public async void UpdateEmployee(Employee employee)
        {
            try
            {
                if (await _processor.UpdateEmployee(new Guid(),employee))
                {
                    _state = State.Updated;
                }
                else
                {
                    _state = State.UpdateFailed;
                }
            }
            catch (Exception e)
            {
                _state = State.ConnectionError;
            }
            UpdateData();
        }

        public async void DeleteEmployee(Employee employee)
        {
            try
            {
                if (await _processor.UpdateEmployee(new Guid(), employee))
                {
                    _state = State.Deleted;
                }
                else
                {
                    _state = State.DeleteFailed;
                }
            }
            catch (Exception e)
            {
                _state = State.ConnectionError;
            }
            UpdateData();
        }


    }
}
