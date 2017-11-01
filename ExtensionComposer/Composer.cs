using System;
using System.Collections.Generic;
using ExtensibilityInterface;

namespace ExtensionComposer
{
    public class ExtensionComposerFactory
    {
        private List<IExtensibility> _extensions;
        
        public ExtensionComposerFactory(List<IExtensibility> extensions)
        {
            _extensions = extensions;
        }

        public void Compose()
        {
            
        }
    }
}