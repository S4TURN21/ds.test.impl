using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl
{
    /// <summary>
    /// Plugin for calculating integer part of two integers division
    /// </summary>
    class DividePlugin : Plugin
    {
        public DividePlugin() : base("DIV", "1.0.0", Properties.Resources.divide_plugin_image, "Divides two numbers.") { }

        /// <summary>
        /// Calculates integer part of two integers division
        /// </summary>
        /// <returns>Integer part of two integers division</returns>
        public override int Run(int input1, int input2)
        {
            if (input2 >= 1)
            {
                return input1 / input2;
            }
            else
            {
                throw new ArgumentException($"Second parameter can't be negative or zero '{input2}'");
            }
        }
    }
}
