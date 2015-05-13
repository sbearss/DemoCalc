using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    /// <summary>
    /// Defines an operand which is part of an expression
    /// Ex: 321  or 4.12 are both operands 
    /// these values are stored in a string
    /// An operand may also consist of an expression
    /// which is an operand + an operator + an operand,
    /// which when evaluated results in a single result value
    /// </summary>
    public interface IOperand
    {
        string NumericValue { get; set; }
         IExpression Expression { get; set; }

    }
}
