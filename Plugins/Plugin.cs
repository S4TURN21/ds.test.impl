using System;
using System.Drawing;

namespace ds.test.impl
{
    abstract class Plugin : IPlugin
    {
        public string PluginName { get; private set; }
        public string Version { get; private set; }
        public Image Image { get; private set; }
        public string Description { get; private set; }

        public Plugin(string name, string version, Image image, string description)
        {
            PluginName = name;
            Version = version;
            Image = image;
            Description = description;
        }

        public abstract int Run(int input1, int input2);
    }
}