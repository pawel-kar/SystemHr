using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHr.DataAccessLayer.Models;
using SystemHr.DataAccessLayer.Models.Dictionaries;
using SystemHr.DataAccessLayer.ViewModels;
using SystemHR.UserInterface.Helpers;

namespace SystemHR.UserInterface.Forms.Employees
{
    public partial class EmployeesForm : Form
    {

        #region Fields
        private static EmployeesForm _instance = null;
        private static IList<EmployeeView> fakeEmployees;
        public static EmployeesForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EmployeesForm();
                }
                return _instance;
            }
        }

        public static bool IsNull
        {
            get
            {
                if (_instance == null)
                {
                    return true;
                }
                return false;
            }
        }
        #endregion

        #region Constructor
        private EmployeesForm()
        {
            InitializeComponent();
            fakeEmployees = GetFakeEmployees();
            PrepareEmployeesData();
        }
        #endregion

        #region PrivateMethods
        private void PrepareEmployeesData()
        {
            var fakeEmployeesSorted = fakeEmployees.OrderBy(x => x.Code).ToList();
            bsEmployees.DataSource = new BindingList<EmployeeView>(fakeEmployeesSorted);
            dgvEmployees.DataSource = bsEmployees;
        }

        private IList<EmployeeView> GetFakeEmployees()
        {
            IList<Employee> fakeEmployees = new List<Employee>()
            {
                new Employee()
                {
                    Id=1,
                    LastName = "Andrzejewski",
                    FirstName = "Paweł",
                    Code = 1,
                    Gender = new Gender("Mężczyzna"),
                    DateBirth = new DateTime(1994,9,1),
                    PESEL = "490494213124",
                    PhoneNumber = "555432214",
                    EmailAddress = "kokokoeurospoko@gmail.com",
                    IdentityCardNumber = "AWR203214",
                    IssueDateIdentityCard = new DateTime(2019,9,11),
                    ExpirationDateIdentityCard = new DateTime(2020,10,10),
                    PassportNumber = "ERDSA1212FSA",
                    IssueDatePassport  = new DateTime(2010,10,2),
                    ExpirationDatePassport = new DateTime(2020,10,2),
                    Status = new Status("Wprowadzony")
                },
                new Employee()
                {
                    Id=2,
                    LastName = "Kowalska",
                    FirstName = "Magda",
                    Code = 3,
                    Gender = new Gender("Kobieta"),
                    DateBirth = new DateTime(1991,9,1),
                    PESEL = "3321412312421",
                    PhoneNumber = "333222111",
                    EmailAddress = "magdalenaleee@gmail.com",
                    IdentityCardNumber = "AWR2312412",
                    IssueDateIdentityCard = new DateTime(2016,4,11),
                    ExpirationDateIdentityCard = new DateTime(2021,1,10),
                    PassportNumber = "EASFASD21324",
                    IssueDatePassport  = new DateTime(2015,10,2),
                    ExpirationDatePassport = new DateTime(2025,10,2),
                    Status = new Status("Wprowadzony")
                },
                new Employee()
                {
                    Id=3,
                    LastName = "Kołomyja",
                    FirstName = "Helena",
                    Code = 2,
                    Gender = new Gender("Mężczyzna"),
                    DateBirth = new DateTime(1989,9,11),
                    PESEL = "312421312321412",
                    PhoneNumber = "888777555",
                    EmailAddress = "kekoekoe@gmail.com",
                    IdentityCardNumber = "AWR2033123214",
                    IssueDateIdentityCard = new DateTime(2014,9,10),
                    ExpirationDateIdentityCard = new DateTime(2019,10,10),
                    PassportNumber = "ERDSA12WADSA",
                    IssueDatePassport  = new DateTime(2019,10,2),
                    ExpirationDatePassport = new DateTime(2029,10,2),
                    Status = new Status("Wprowadzony")
                }
            };
            return EmployeeMapper.MapEmployeeToEmployeeView(fakeEmployees);
        }

        private void EmployeesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
        #endregion

    }
}
