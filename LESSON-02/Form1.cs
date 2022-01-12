using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LESSON_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            //sqlconnection
            //sqlcommand
            //sqlparamter
            //MyDataSetTableAdapters.RolesTableAdapter rolesTableAdapter =
            //     new MyDataSetTableAdapters.RolesTableAdapter();

            //MyDataSet.RolesDataTable rolesDataTable =
            //    new MyDataSet.RolesDataTable();

            ////متدهایی که در دیتاست ساختیم رو صدا می زنیم 
            //rolesDataTable =
            //    rolesTableAdapter.GetDataByIsActive();

            ////rolesDataTable =
            ////    rolesTableAdapter.GetRoles();

            ////که در خروجی تعداد رکورد برگشت شده از دیتا بیس را مشخص می کند data table پر کردن 
            ////int result =
            ////    rolesTableAdapter.FillByIsActive(rolesDataTable);

            ////تعداد رکوردهای برگردانده شده از دیتابیس رو مشخص می کند
            //int rowCount = rolesDataTable.Count;


            ////دسترسی داریم  rolesRows  به اولین رکورد در مجموعه ی 
            //dataGridView1.DataSource = rolesDataTable[0];

            //// را بر می گرداند. Roles اولین فیلد داخل جدول 
            //DataColumn dataColumn = rolesDataTable.Columns[0];

            ////بدست آوردن اطلاعات فیلد از طریق نام فیلد
            //DataColumn dataColumn1 = rolesDataTable.Columns["RoleName"];


            ////نام جدول مربوط به فیلد را بر می گرداند
            //string tableName = dataColumn.Table.TableName;

            //// dataGridView1 پر کردن 
            //dataGridView1.DataSource = rolesDataTable;

            //// ها وجود دارد table adapter  این متد ها هم بصورت پیش فرض در تمام 
            //// را انجام داد crud  که می توان عملیات 
            ////rolesTableAdapter.Insert()
            ////rolesTableAdapter.Update()
            ////rolesTableAdapter.Delete()




            //***************************************************
            //             روش دوم ارتباط با جداول
            //***************************************************

            dataGridView1.DataSource = Roles.GetRoles();

            if (Roles.GetRolesByRoleID(roleID: 9002).Count == 0)
            {
                MessageBox.Show("یافت نشد id رکوردی با این ");
            }
            else
            {
                dataGridView2.DataSource = Roles.GetRolesByRoleID(roleID: 9002);
            }
            //bool insertResult =
            //   Roles.InsertRoles(roleID: 100, roleName: "کاربران 2", roleIsActive: true);

            //bool insertResult =
            //Roles.InsertRoles2(roleID: 200, roleName: "کاربران 3", roleIsActive: true);

            //bool updateResult =
            //  Roles.UpdateRoles2(roleID: 100, roleName: "کارمندان ", roleIsActive: false);

            //bool deleteResult =
            //    Roles.DeleteByRoleId(roleId: 200);

            bool deleteResult =
                Roles.DeleteByIsActive(isActive:false);
        }

    }
}
