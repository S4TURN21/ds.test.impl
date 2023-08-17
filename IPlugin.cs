namespace ds.test.impl
{
    /// <summary>
    /// Interface for plugin. Provides plugin information and allows to run operations on integers.
    /// </summary>
    public interface IPlugin
    {
        /// <value>Name of plugin</value>
        string PluginName { get; }

        /// <value>Version of plugin</value>
        string Version { get; }

        /// <value>Image of plugin</value>
        System.Drawing.Image Image { get; }

        /// <value>Description of plugin</value>
        string Description { get; }

        /// <summary>
        /// Run operation on integers
        /// </summary>
        /// <returns>Operation result</returns>
        int Run(int input1, int input2);
    }
}
