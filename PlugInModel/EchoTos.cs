using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlugInModel
{
    public class EchoTos : CommandBase<TcpAppSession, TcpRequestInfo>
    {
      public override void ExecuteCommand(TcpAppSession session, TcpRequestInfo requestInfo)
       {

       }
    }
}
