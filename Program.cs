using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SiriusSVCcall.SvcSearch;
using SiriusSVCcall.SvcCreate;
using System.ServiceModel;
namespace SiriusSVCcall
{
    static class Program
    {
        private static PSearchSvcClient searchClient;
        private static HttpCreateClient createClient;

        public static PSearchSvcClient Search {
            get {
                if (searchClient == null) {
                    BasicHttpBinding Binding = new BasicHttpBinding();
                    Binding.MaxBufferPoolSize = 400000000L;
                    Binding.MaxBufferSize = 400000000;
                    Binding.MaxReceivedMessageSize = 400000000L;
                    //b.ReaderQuotas = new System.Xml.XmlDictionaryReaderQuotas();
                    Binding.ReaderQuotas.MaxStringContentLength = 1048576;
                    Binding.ReaderQuotas.MaxArrayLength = 1048576;
                    Binding.ReaderQuotas.MaxBytesPerRead = 1048576;
                    Binding.ReaderQuotas.MaxNameTableCharCount = 1048576;
                    searchClient = new PSearchSvcClient(Binding, new EndpointAddress(new Uri("http://localhost:5100/PSvc/")));
                }
                return searchClient;
            }
        }
        public static HttpCreateClient Create {
            get {
                if (createClient == null) {
                    createClient = new HttpCreateClient(new BasicHttpBinding(), new EndpointAddress(new Uri("http://localhost:5110/PSvc/")));
                }
                return createClient;
            }
        }

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        /// 
        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);
        private const int ATTACH_PARENT_PROCESS = -1;

        [STAThread]
        //static void Main()
        static void Main(string[] args)
        {
            
            // Attach to the parent process via AttachConsole SDK call
            AttachConsole(ATTACH_PARENT_PROCESS);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);            
            Application.Run(new SiriusSVCcall.Form2());
        }
    }
}
