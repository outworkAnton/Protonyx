using System;
using System.Collections.Generic;

namespace ExtensibilityInterface
{
    public interface IExtensibility
    {
        Dictionary<string, dynamic> GetProperties();

        bool ImportData();
        bool ExportData();
        
    }
    
    
}