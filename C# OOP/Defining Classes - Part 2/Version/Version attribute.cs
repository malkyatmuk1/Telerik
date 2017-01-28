namespace Versionattribute
{
    using System;

    public class Versionattribute : System.Attribute
    {
        [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
        

        public string Version { get; private set; }

        public Versionattribute(string version)
        {
            this.Version = version;
        }


    }
}