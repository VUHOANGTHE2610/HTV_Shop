using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV21T1020178.BusinessLayers
{
    /// <summary>
    /// cấu hình cho tầng BusinessLayer
    /// </summary>
    public static class Configuration
    {
        public static string ConnectionString { get; private set; } = "";

        public static void Initialize( string connectionString)
        {
            ConnectionString = connectionString; 
        }
    }
}
