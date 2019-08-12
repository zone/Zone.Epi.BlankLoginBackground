using System;
using System.IO;
using System.Net;
using System.Web;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;

namespace Zone.Epi.BlankLoginBackground.Core.Initialization
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class PlaceBasicImageModule : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            var localDirectory = HttpContext.Current.Server.MapPath("~/");

            // Check to see if the background image was added with the package installation
            if (!File.Exists(localDirectory + Constants.LocalImageLocation + Constants.LocalImageFilename))
            {
                // If not, ensure the folders are made
                Directory.CreateDirectory(localDirectory + "/Static");
                Directory.CreateDirectory(localDirectory + "/Static/Images");
                Directory.CreateDirectory(localDirectory + "/Static/Images/CMS");

                // And download the image
                using (var client = new WebClient())
                {
                    client.DownloadFile(new Uri(Constants.RemoteImageUrl), localDirectory + Constants.LocalImageLocation + Constants.LocalImageFilename);
                }
            }
        }

        public void Uninitialize(InitializationEngine context)
        {
        }

        public void Preload(string[] parameters)
        {
        }
    }
}