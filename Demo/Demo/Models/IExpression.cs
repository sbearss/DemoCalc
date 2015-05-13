using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    /// <summary>
    /// A mathmatical expression consisting
    /// which is an operand + an operator + an operand,
    /// which when evaluated results in a single result value
    /// </summary>
    public interface IExpression
    {
        //May return NAN if expression is not valid
        string Evaluate();

        IOperand LeftSideOfEquation { get; set; }
        IOperator Operation { get; set; }
        IOperand RightSideOfEquation { get; set; }

    }
}
