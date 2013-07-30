using System;
using System.IO;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace ConfigTransformation.Extensions
{
    class IntellisenseHelper : Task
    {
        public void FileContains(string path, string SearchFor, string message)
        {
         
            string content = File.ReadAllText(path);
            if (!content.Contains(SearchFor))
            {
                var messageInternal = string.IsNullOrWhiteSpace(message) ? "File '{0}' does not contain SearchFor '{1}'!" : message;
                Log.LogError(messageInternal, Path.GetFileName(path), SearchFor);
                //Log.LogError("Assert", "404", "", base.BuildEngine.ProjectFileOfTaskNode, base.BuildEngine.LineNumberOfTaskNode, base.BuildEngine.ColumnNumberOfTaskNode, 0, 0, messageInternal);
            }
            
            Log.LogMessage(MessageImportance.Normal, "");

        }
        public override bool Execute()
        {
            
            throw new NotImplementedException();
        }
    }
}
