using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_patron_comportamiento_visitor.Interfaces
{
    internal interface IVisitable
    {
        void Accept(IVisitor visitor);
    }
}
