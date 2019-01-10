using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Next_moov.Models
{
	public class NetworkCheck
    {
            public static bool IsInternet()
            {
                if (CrossConnectivity.Current.IsConnected)
                {
                    return true;
                }
                else
                {
                    // write your code if there is no Internet available  
                    return false;
                }
            }
    }
}