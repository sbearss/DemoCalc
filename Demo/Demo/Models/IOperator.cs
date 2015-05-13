using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    public enum CalcOperator
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }
    /// <summary>
    /// Defines an operator
    /// which is part of a mathmatical expression
    /// example *, +, -, /
    /// </summary>
    public interface IOperator
    {
        CalcOperator Operation { get; set; }
    }
}
