using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlugInModel
{
    public class GMTos : CommandBase<HttpAppSession, HttpRequestInfo>
    {
        public override void ExecuteCommand(HttpAppSession session, HttpRequestInfo requestInfo)
        {
            Console.WriteLine("Running GMTos....");
        }
    }
}
