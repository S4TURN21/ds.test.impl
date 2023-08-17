using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl
{
    /// <summary>
    /// Plugin for calculating difference between two integers
    /// </summary>
    class SubtractPlugin : Plugin
    {
        public SubtractPlugin() : base("SUB", "1.0.0", Properties.Resources.subtract_plugin_image, "Subtracts two numbers.") { }

        /// <summary>
        /// Calculates difference between two integers
        /// </summary>
        /// <returns>Difference between two given integers</returns>
        public override int Run(int input1, int input2)
        {
            long result = input1;
            result -= input2;

            if (result > int.MaxValue || result < int.MinValue)
            {
                throw new OverflowException($"Result is outside the range of int values '{result}'");
            }

            return (int)result;
        }
    }
}
