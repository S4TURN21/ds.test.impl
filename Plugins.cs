using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl
{
    /// <summary>
    /// Collection of plugins for integer operations
    /// </summary>
    public static class Plugins
    {
        private static readonly List<IPlugin> plugins = new List<IPlugin>()
        {
            new AddPlugin(),
            new SubtractPlugin(),
            new MultiplyPlugin(),
            new DividePlugin()
        };

        /// <value>Count of plugins</value>
        public static int PluginsCount => plugins.Count;

        /// <value>Array of plugins names</value>
        public static string[] GetPluginNames => plugins.Select(p => p.PluginName).ToArray();

        /// <summary>
        /// Method for getting plugin by plugin's name
        /// </summary>
        /// <returns>Plugin that implements IPlugin interface with corresponding name</returns>
        public static IPlugin GetPlugin(string pluginName)
        {
            var plugin = plugins.SingleOrDefault(p => p.PluginName == pluginName);

            if (plugin == null)
            {
                throw new ArgumentException($"Plugin '{pluginName}' not found.");
            }

            return plugin;
        }
    }
}
