namespace Versionattribute
{
    using System;
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class Versionattributee : System.Attribute
    {
        
        

        public string Version { get; private set; }

        public Versionattributee(string version)
        {
            this.Version = version;
        }


    }
}