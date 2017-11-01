using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using ExtensibilityInterface;

namespace ExtensionLoader
{
    public class ExtensionLoaderFactory
    {
        [ImportMany(typeof(IExtensibility))]
        List<IExtensibility> Extensions { get; set; }

        public List<IExtensibility> GetAllPlugins(string pluginsDirectory)
        {
            try
            {
                var catalog = new DirectoryCatalog(pluginsDirectory, "*.dll");
                using (var container = new CompositionContainer(catalog))
                {
                        Extensions = new List<IExtensibility>();
                        container.ComposeParts(this);
                }
                return Extensions;
            }
            catch (Exception ex)
            {
                throw new FileNotFoundException($"Extensions not found. May be wrong directories. Message: {ex}");
            }
        } 
    }
}