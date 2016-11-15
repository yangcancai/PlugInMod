# PlugInMod
* a simple server 
* implement C# Reflection
and memory leak detect use Visual Leak Detector 

# How to Install
* Do it yourself

# How to use?
```java
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
```
# Thanks

  * [SuperSocket](http://www.supersocket.net/)
 
# About author
  If you have any quetions,please contact `710180334@qq.com`