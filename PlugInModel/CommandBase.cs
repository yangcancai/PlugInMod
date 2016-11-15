using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlugInModel
{
    public abstract class  CommandBase<TAppSession, TRequestInfo> : ICommand<TAppSession, TRequestInfo>
        where TAppSession : IAppSession,new()
        where TRequestInfo : IRequestInfo
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        public virtual string Name
        {
            get { return this.GetType().Name; }
        }
        /// <summary>
        /// Executes the command.
        /// </summary>
        /// <param name="session">The session.</param>
        /// <param name="requestInfo">The request info.</param>
        public abstract void ExecuteCommand(TAppSession session, TRequestInfo requestInfo);
    }
}
