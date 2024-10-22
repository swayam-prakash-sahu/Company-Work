using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using WpfCRUD.Models;
using System.Windows;

namespace WpfCRUD.ViewModels
{
    public class EmployeeVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string ProprtName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(ProprtName));

        }

        EmployeeService objEmpService;
        public EmployeeVM()
        {
            objEmpService = new EmployeeService();
            LoadData();
            currentEmp = new EmployeeDTO();
            saveComd = new RelayCommand(param => Save());
            editComd = new RelayCommand(param => Search((int)param));
            deleteComd = new RelayCommand(param => Delete((int)param));

        }

        private ObservableCollection<EmployeeDTO> empList;
        public ObservableCollection<EmployeeDTO> EmpList
        {
            get { return empList; }
            set { empList = value; OnPropertyChanged("EmpList"); }
        }

        private void LoadData()
        {
            EmpList = new ObservableCollection<EmployeeDTO>(objEmpService.GetAll());

        }

        private EmployeeDTO currentEmp;
        public EmployeeDTO CurrentEmployee
        {
            get { return currentEmp; }
            set { currentEmp = value; OnPropertyChanged("CurrentEmployee");  }
        }

        private string message; 
        public string Message
        {
            get { return message; }
            set { message = value;OnPropertyChanged("Message"); }
        }


        private RelayCommand saveComd;
        public RelayCommand SaveCommand
        {
            get { return saveComd; }
        }

        private void Save()
        {
            try
            {
                if (CurrentEmployee.ID<=0)
                {
                    var IsSaved = objEmpService.Add(CurrentEmployee);
                    MessageBox.Show("Employee added Succesfully");
                }
                else {
                    var IsSaved = objEmpService.Update(CurrentEmployee);
                    Message = "Employee updated Succesfully";
                }
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
            finally
            {
                LoadData();
            }
        }

        private RelayCommand editComd;
        public RelayCommand EditCommand
        {
            get { return editComd; }
        }

        private void Search(int id)
        {
            try
            {
                var ObjEmp = objEmpService.Search(id);
                if (ObjEmp != null)
                {
                    currentEmp.ID = ObjEmp.ID;
                    currentEmp.Name = ObjEmp.Name;
                    currentEmp.Address = ObjEmp.Address;
                }
                else { 
                    Message = "Employee not Found";
                }
            }
            catch (Exception ex)
            {

                Message = ex.Message; 
            }
        }

        private RelayCommand deleteComd;

        public RelayCommand DeleteCommand
        {
            get { return deleteComd; }
        }

        private void Delete(int id)
        {
            try
            {
                var IsDelete = objEmpService.Delete(id);
                if (IsDelete) {
                    Message = "Employee Deleted";
                    LoadData();
                }
                else {
                    Message = "Delete Failed";
                }

            }
            catch (Exception ex)
            {

                Message = ex.Message;
            }
        }







    }
    
}
