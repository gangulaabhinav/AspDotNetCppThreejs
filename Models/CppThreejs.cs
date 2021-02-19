using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace AspDotNetCppThreejs.Models
{
    public class CppThreejs
    {
        [DllImport("wwwroot/CppLibrary.dll", EntryPoint = "GetCubeSize", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetCubeSize();
        public int CubeSize()
        {
            return GetCubeSize();
        }
    }
}
