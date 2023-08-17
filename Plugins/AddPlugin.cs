using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl
{
    /// <summary>
    /// Plugin for calculating sum of two integers
    /// </summary>
    class AddPlugin : Plugin
    {
        public AddPlugin() : base("ADD", "1.0.0", Properties.Resources.add_plugin_image, "Adds two numbers together.") { }

        /// <summary>
        /// Calculates sum of two integers
        /// </summary>
        /// <returns>Sum of two given integers</returns>
        public override int Run(int input1, int input2)
        {
            long result = input1;
            result += input2;

            if (result > int.MaxValue || result < int.MinValue)
            {
                throw new OverflowException($"Result is outside the range of int values '{result}'");
            }

            return (int)result;
        }
    }
}
