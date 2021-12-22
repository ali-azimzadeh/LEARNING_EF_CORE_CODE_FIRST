using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON_02
{
    public static class Roles 
    {
        static Roles()
        {
        }


        /// <summary>
        /// کار کرد Roles ایجاد شده تا بتوان با جدول  RolesTableAdapter یک ویژگی از جنس 
        /// </summary>
        private static MyDataSetTableAdapters.RolesTableAdapter _roleAdapter = null;
         //   new MyDataSetTableAdapters.RolesTableAdapter();

        //Readonly Property!
        private static MyDataSetTableAdapters.RolesTableAdapter RoleAdapter
        {
            get
            {
                // Lazy Loading! روش 
                if (_roleAdapter == null)
                {
                    _roleAdapter = 
                        new MyDataSetTableAdapters.RolesTableAdapter();
                }

                return (_roleAdapter);
            }
        }

        /// <summary>
        ///  را بر می گرداند Roles تمامی رکوردهای موجود در جدول 
        /// </summary>
        /// <returns></returns>
        public static MyDataSet.RolesDataTable GetRoles()
        {
            return (RoleAdapter.GetRoles());
        }

        
        /// <summary>
        /// بر می گرداند roleID رکورد را بر اساس یک 
        /// </summary>
        /// <param name="roleID"></param>
        /// <returns></returns>
        public static MyDataSet.RolesDataTable GetRolesByRoleID(int roleID)
        {
            return (RoleAdapter.GetRolesByRoleId(roleID));
        }

        /// <summary>
        /// استفاده می شود  Roles  از این متد برای ایجاد یک رکورد در جدول 
        /// (روش اول)
        /// </summary>
        /// <param name="roleID"></param>
        /// <param name="roleName"></param>
        /// <param name="roleIsActive"></param>
        /// <returns></returns>
        public static bool InsertRoles(int roleID, string roleName, bool roleIsActive)
        {
            MyDataSet.RolesDataTable oRoleData =
                new MyDataSet.RolesDataTable();

            MyDataSet.RolesRow oRoleRow = 
                oRoleData.NewRolesRow();

            if (roleID >= 0)
            {
                oRoleRow.RoleID = roleID;
            }
            else
            {
                oRoleRow.RoleID = 0;
            }

            if (roleName != null)
            {
                oRoleRow.RoleName = roleName;
            }
            else
            {
                oRoleRow.RoleName = "";
            }

            oRoleRow.RoleIsActive = roleIsActive;

            oRoleData.AddRolesRow(oRoleRow);

            int rowsAffected = 
                RoleAdapter.Update(oRoleData);

            return (rowsAffected == 1);
        }

        /// <summary>
        /// استفاده می شود  Roles  از این متد برای ایجاد یک رکورد در جدول 
        /// (روش دوم)
        /// </summary>
        /// <param name="roleID"></param>
        /// <param name="roleName"></param>
        /// <param name="roleIsActive"></param>
        /// <returns></returns>
        public static bool InsertRoles2(int roleID, string roleName, bool roleIsActive)
        {
            int intRowAffected =
                RoleAdapter.Insert(RoleID: roleID, RoleName: roleName, RoleIsActive: roleIsActive);

            return (intRowAffected == 1);
        }


        /// <summary>
        /// استفاده می شود  Roles  از این متد برای اصلاح یک رکورد در جدول 
        /// (روش اول)
        /// </summary>
        /// <param name="roleID"></param>
        /// <param name="roleName"></param>
        /// <param name="roleIsActive"></param>
        /// <returns></returns>
        public static bool UpdateRoles(int roleID, string roleName, bool roleIsActive)
        {
            MyDataSet.RolesDataTable oRoleData = 
                RoleAdapter.GetRolesByRoleId(roleID);

            if (oRoleData.Count == 0)
            {
                return (false);
            }

            MyDataSet.RolesRow oRoleRow = oRoleData[0];

            if (roleID >= 0)
            {
                oRoleRow.RoleID = roleID;
            }
            else
            {
                oRoleRow.RoleID = 0;
            }

            if (roleName != null)
            {
                oRoleRow.RoleName = roleName;
            }
            else
            {
                oRoleRow.RoleName = "";
            }

            oRoleRow.RoleIsActive = roleIsActive;

            int rowsAffected = 
                RoleAdapter.Update(oRoleData);

            return (rowsAffected == 1);
        }

        /// <summary>
        /// استفاده می شود  Roles  از این متد برای اصلاح یک رکورد در جدول 
        /// (روش دوم)
        /// </summary>
        /// <param name="roleID"></param>
        /// <param name="roleName"></param>
        /// <param name="roleIsActive"></param>
        /// <returns></returns>
        public static bool UpdateRoles2(int roleID, string roleName, bool roleIsActive)
        {
            int intRowAffected =
                RoleAdapter.UpdateRoles(RoleName: roleName, 
                RoleIsActive: roleIsActive,
                Original_RoleID: roleID);

            return (intRowAffected == 1);
        }

        public static bool DeleteByRoleId(int roleId)
        {
            int intRowAffected =
                RoleAdapter.DeleteByRoleId(Original_RoleID: roleId);

            return (intRowAffected == 1);
        }

        public static bool DeleteByIsActive(bool isActive)
        {
            int intRowAffected =
                RoleAdapter.DeleteByIsActive(Original_RoleIsActive: isActive);

            return (intRowAffected == 1);
        }
    }
}
