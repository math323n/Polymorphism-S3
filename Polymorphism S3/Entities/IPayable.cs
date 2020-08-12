using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_S3.Entities
{
    public interface IPayable
    {
        bool IsProcessed();
        decimal GetAmount();
    }
}
