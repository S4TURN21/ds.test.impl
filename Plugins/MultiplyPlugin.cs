using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl
{
    /// <summary>
    /// Plugin for calculating multiplication of two integers
    /// </summary>
    class MultiplyPlugin : Plugin
    {
        public MultiplyPlugin() : base("MULT", "1.0.0", Properties.Resources.multiply_plugin_image, "Multiplies two numbers.") { }

        /// <summary>
        /// Calculates multiplication of two integers
        /// </summary>
        /// <returns>Multiplication of two integers</returns>
        public override int Run(int input1, int input2)
        {
            long result = input1;
            result *= input2;

            if (result > int.MaxValue || result < int.MinValue)
            {
                throw new OverflowException($"Result is outside the range of int values '{result}'");
            }

            return (int)result;
        }
    }
}
