using System;
using System.ServiceModel;

namespace LibraryServiceHost
{
    class HostApp
    {
        static void Main(string[] args)
        {
            ServiceHost host = null;
            try
            {
                host = new ServiceHost(typeof(LibraryService.LibraryService));
                host.Open();
                Console.WriteLine("Service running");
            }
            catch (Exception eX)
            {
                host = null;
                Console.WriteLine("Service can not be started \n\nError Message [" + eX.Message + "]");
                Console.ReadKey();
            }

            if (host != null)
            {
                Console.WriteLine("\nPress any key to close the Service");
                Console.ReadKey();
                host.Close();
                host = null;
            }
        }
    }
}
