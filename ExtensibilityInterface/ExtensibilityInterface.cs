using System;
using System.Collections.Generic;

namespace ExtensibilityInterface
{
    public interface IExtensibility
    {
        Dictionary<string, dynamic> GetProperties();
        IExtensibility ConnectedFrom { get; set; }
        IExtensibility ConnectedTo { get; set; }

        bool ImportData(IExtensibility input);
        IExtensibility ExportData();
        
    }

    public interface IVisualExtension: IExtensibility
    {
        void RenderData();
    }
    
    public interface IManipulateExtension: IExtensibility
    {
        
    }
}