using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Blog_my_host
{
    class Program
    {
        static void Main(string[] args)
        {

            using (ServiceHost host = new ServiceHost(typeof(Blog_project.Create_user_Service)))
            {

                host.Open();
                Console.WriteLine("Host Started: " + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}
