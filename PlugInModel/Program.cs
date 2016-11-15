using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PlugInModel
{
    class Program
    {
        static void Main(string[] args)
        {
            IAppServer app = new AppServerBase();
            var assembly = app.GetType().Assembly;
            IEnumerable<ICommand<HttpAppSession, HttpRequestInfo>> commands = AssemblyUtil.GetImplementedObjectsByInterface<ICommand<HttpAppSession, HttpRequestInfo>>(assembly);
            HttpAppSession session = new HttpAppSession();
            HttpRequestInfo req = new HttpRequestInfo();
            foreach (var c in commands)
            {
                Console.WriteLine("command name: {0}",c.Name);
                c.ExecuteCommand(session,req);
            }
            Console.ReadKey();
        }
    }
}
