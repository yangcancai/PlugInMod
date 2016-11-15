using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlugInModel
{
    /// <summary>
    /// Command basic interface
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        string Name { get; }
    }
    /// <summary>
    /// Command basic interface
    /// </summary>
    /// <typeparam name="TAppSession">The type of the app session.</typeparam>
    /// <typeparam name="TRequestInfo">The type of the request info.</typeparam>
    public interface ICommand<TAppSession, TRequestInfo> : ICommand
        where TRequestInfo : IRequestInfo
        where TAppSession : IAppSession
    {
        /// <summary>
        /// Executes the command.
        /// </summary>
        /// <param name="session">The session.</param>
        /// <param name="requestInfo">The request info.</param>
        void ExecuteCommand(TAppSession session, TRequestInfo requestInfo);
    }
}
