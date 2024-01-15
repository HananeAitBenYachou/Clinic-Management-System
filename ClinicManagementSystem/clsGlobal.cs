using ClinicBusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementSystem
{
    internal static class clsGlobal
    {
        public static clsUser CurrentUser { get; set; }
       
        static clsGlobal()
        {
            CurrentUser = clsUser.Find("", "");
        }

    }
}
