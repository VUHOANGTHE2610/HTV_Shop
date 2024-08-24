using SV21T1020178.DataLayers;
using SV21T1020178.DataLayers.SQLServer;
using SV21T1020178.DomainModels;
using SV21T1020178.BusinessLayers;
using Nhom2.DataLayers;
using Nhom2.DataLayers.SQLServer;

namespace Nhom2.BusinessLayers
{
    public static class UserAccountService
    {
        private static readonly IUserAccountDAL employeeAccountDB;

        static UserAccountService()
        {
            employeeAccountDB = new EmployeeAccountDAL(Configuration.ConnectionString);
        }

        public static UserAccount? Authorize(string userName, string password)
        {
            return employeeAccountDB.Authorize(userName, password);
        }

        public static bool ChangePassword(string userName, string oldPassword, string newPassword)
        {
            return employeeAccountDB.ChangePassword(userName, oldPassword, newPassword);
        }

    }
}
