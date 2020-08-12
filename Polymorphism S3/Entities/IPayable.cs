using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_S3.Entities
{
    public interface IPayAble
    {
        bool IsProcessed();
        decimal GetAmount();
    }
}
