using System;
using System.Web;
using Db4objects.Db4o;
using System.IO;

namespace Db40Spike.Infrastructure 
{
    public class ObjectContainerFactory : IObjectContainerFactory
    {    
        private static IObjectServer _server;
        private static IObjectContainer _object_container;
        
        public ObjectContainerFactory(string container_path) {
            if (_server == null) {
                Connect(container_path);
            }
        }

        private void Connect(string container_path) {
            _server = Db4oFactory.OpenServer(container_path, 0);            
        }
        
        public IObjectContainer create()
        {
            return _server.OpenClient();
        }  
    
    }
}
