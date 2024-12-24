using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Manger
{
    internal static class Utility
    {
        public static bool check_internet()
        {
			try
			{
				using (var clint = new WebClient())
				{
					using (clint.OpenRead("https://google.com"))
					{
					return true;

					}
				}
			}
			catch (Exception)
			{
				return false;
				
			}

        }

    }
}
