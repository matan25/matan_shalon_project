using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication8
{
    /// <summary>
    /// Interaction logic for UpdateTable.xaml
    /// </summary>
    public partial class UpdateEmployeeTable : Window
    {
        private Database1Entities1 db = new Database1Entities1();
        private DataGrid d = new DataGrid();
        private Database1Entities1 dbSave = new Database1Entities1();
        private employee updateworker;
        public UpdateEmployeeTable(DataGrid dg,Database1Entities1 db1)
        {
            dbSave = db1;
            d = dg;
            var results = from table1 in db1.employee.AsEnumerable()
                        //  join table2 in db1.employee_type.AsEnumerable() on (int)table1.employee_type_id equals (int)table2.Id_Employee_Type
                        //  join table3 in db1.Postal_Code_Worker.AsEnumerable() on (int)table1.postal_code_id equals (int)table3.Id_Postal_Code_Worker
                          select new
                          {
                              Employee_Id = (int)table1.Id_Employee,
                              iId_Number = (string)table1.id_number,
                              Name = (string)table1.name,
                              Phone = (string)table1.phone,
                             // Gender = (string)table1.gender,
                              Deleted = (string)table1.deleted,
                              /*employee_type_id = (int)table2.Id_Employee_Type,
                              type = (string)table2.type,
                              salary = (string)table2.salary,
                              postal_code_id = (int)table3.Id_Postal_Code_Worker,
                              city = (string)table3.city,
                              street = (string)table3.street,
                              house_number = (string)table3.house_number*/
                          };
            InitializeComponent();
            updateGrid.ItemsSource = results.ToList();
            this.db = db1;
        }


        private void updateGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
             var updateworker = ChangeType();
             UpdateEmployeeWindow uew = new WpfApplication8.UpdateEmployeeWindow(updateworker,dbSave,d);
            this.db.SaveChanges();
            this.Close();
            uew.ShowDialog(); 
        }

        private employee ChangeType()
        {
            employee i = db.employee.ToList().FindAll(e => e.Id_Employee == (int)updateGrid.SelectedItem.GetType().
            GetProperty("Employee_Id").GetValue(updateGrid.SelectedItem)).FirstOrDefault();
            return i;
        }
    }
}
