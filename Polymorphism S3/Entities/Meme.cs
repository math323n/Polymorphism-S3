using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_S3.Entities
{
    public class Meme : IEquatable<Meme>
    {
        private string name;
        private int worth;

        public Meme(string name, int worth)
        {
            Name = name;
            Worth = worth;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Worth
        {
            get
            {
                return worth;
            }

            set
            {
                worth = value;
            }
        }


        #region Equality
        public bool Equals(Meme other)
        {
            if(other == null)
            {
                return false;
            }

            return string.Equals(name, other.name) && Worth == other.Worth;
        }
        public override bool Equals(object obj)
        {
            if(ReferenceEquals(null, obj)) return false;
            if(ReferenceEquals(this, obj)) return true;
            if(obj.GetType() != GetType()) return false;
            return Equals(obj as Meme);
        }
        #endregion
    }
}
