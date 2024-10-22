using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCRUD.Models
{
    public class EmployeeService
    {
        EmployeeEntities ObjContext;

       public EmployeeService()
        {
            ObjContext = new EmployeeEntities();
        } 

       public List<EmployeeDTO> GetAll()
        {
            List<EmployeeDTO> ObjEmpList = new List<EmployeeDTO>();
            try
            {
                var qry = from tb_employee in ObjContext.tb_employee
                          select tb_employee;
                foreach(var emp in qry)
                {
                    ObjEmpList.Add(new EmployeeDTO { ID = emp.emp_id, Name = emp.name, Address = emp.address });
                }
            }
            catch (Exception ex)
            {

               // throw ex;
            }
            return ObjEmpList;
        }

       public bool Add(EmployeeDTO ObjNewEmployee)
        {
            bool IsAdded = false;
            if (ObjNewEmployee.Name == null)
                throw new ArgumentNullException("Name is Required.");
            try
            {
                var objEmp = new tb_employee();
                objEmp.emp_id = ObjNewEmployee.ID;
                objEmp.name = ObjNewEmployee.Name;
                objEmp.address = ObjNewEmployee.Address;

                ObjContext.tb_employee.Add(objEmp);
                var recno = ObjContext.SaveChanges();
                IsAdded = recno > 0;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return IsAdded;
        }

       public bool Update(EmployeeDTO ObjUpdEmployee)
        {
            bool IsUpdate = false;
            try
            {
                var ObjUpdEmp = ObjContext.tb_employee.Find(ObjUpdEmployee.ID);
                ObjUpdEmp.name = ObjUpdEmployee.Name;
                ObjUpdEmp.address = ObjUpdEmployee.Address;
                var recno = ObjContext.SaveChanges();
                IsUpdate = recno > 0;

            }
            catch (Exception)
            {

                throw;
            }
            
            return IsUpdate;
        }

       public bool Delete(int id)
        {
            bool IsDelete = false;
            try
            {
                var ObjDelEmp = ObjContext.tb_employee.Find(id);
                ObjContext.tb_employee.Remove(ObjDelEmp);
                var recno = ObjContext.SaveChanges();
                IsDelete = recno > 0;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
            return IsDelete;
        }


       public EmployeeDTO Search(int id)
       {
            EmployeeDTO ObjEmpDTO = null;
            try
            {
                var ObjFindEmp = ObjContext.tb_employee.Find(id);
                if (ObjFindEmp != null)
                {
                    ObjEmpDTO = new EmployeeDTO() { ID = ObjFindEmp.emp_id, Name = ObjFindEmp.name, Address = ObjFindEmp.address };

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return ObjEmpDTO;

        }



    }
}
