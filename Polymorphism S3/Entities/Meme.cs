using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_S3.Entities
{
    public class Meme: IEquatable<Meme>
    {
        private string name;
        private int number;
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

        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }


        #region Equality
        public bool Equals(Meme other)
        {
            if(other == null)
            {
                return false;
            }
            // Check if object is same
            if(ReferenceEquals(this, other))
            {
                return true;
            }
   
            return string.Equals(name, other.name) && Worth == other.Worth;
        }

        /// <summary>
        /// Override Equals method from IEquatable
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            //Conditional expression
            return Equals(obj as Meme);
        }

        public override int GetHashCode()
        {
            // "unchecked" Supress overflow 
          unchecked
            {
                // Method One
                /*
                var hashCode = 13;
                hashCode = (hashCode * 397) ^ number;
                var stringHashCode = !string.IsNullOrEmpty(name) ? name.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ stringHashCode;
                return hashCode;*/
                
                // Method Two
                // int to store hash
                int hash = (int)2166136261;

                // Multiply hash with a second prime number and add each fields hash code
                hash = (hash * 16777619) ^ name.GetHashCode();
                hash = (hash * 16777619) ^ worth.GetHashCode();
                hash = (hash * 16777619) ^ number.GetHashCode();
                return hash;
            }
        }
        #endregion
    }
}