using System.Collections.Specialized;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using EPiServer.Web.Hosting;

namespace Zone.Epi.BlankLoginBackground.Core.Initialization
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class ChangeLoginImagesModule : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            var host = ServiceLocator.Current.GetInstance<IHostingEnvironment>();
            if (host == null)
                return;

            var virtualPathMappedProvider = new VirtualPathMappedProvider("LoginImage", new NameValueCollection());

            virtualPathMappedProvider.PathMappings.Add("/Util/images/login/Pictures_Page_1-min.jpg", Constants.LocalImageLocation + Constants.LocalImageFilename);
            virtualPathMappedProvider.PathMappings.Add("/Util/images/login/Pictures_Page_2-min.jpg", Constants.LocalImageLocation + Constants.LocalImageFilename);
            virtualPathMappedProvider.PathMappings.Add("/Util/images/login/Pictures_Page_3-min.jpg", Constants.LocalImageLocation + Constants.LocalImageFilename);

            host.RegisterVirtualPathProvider(virtualPathMappedProvider);
        }

        public void Uninitialize(InitializationEngine context)
        {
        }

        public void Preload(string[] parameters)
        {
        }
    }
}