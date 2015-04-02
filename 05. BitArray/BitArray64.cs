namespace _05.BitArray
{
    using System;
    using System.Collections.Generic;
    public class BitArray64 : IEnumerable<int>
    {
        private ulong number;

        public BitArray64(ulong number)
        {
            this.Number = number;
        }

        public ulong Number
        {
            get
            {
                return this.number;
            }
            set
            {
                this.number = value;
            }
        }


        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new ArgumentOutOfRangeException("Index is out of range.");
                }
                return ((int)(this.Number >> index) & 1);
            }
            set
            {
                if (index < 0 || index >= 64)
                {
                    throw new IndexOutOfRangeException("Invalid position.");
                }

                if (value != 0 && value != 1)
                {
                    throw new ArgumentException("Invalid bit value.");
                }
                if (value == 1)
                {
                    this.number = this.number | ((ulong)1 << index);
                }
                else
                {
                    this.number = this.number & (~((ulong)1 << index));
                }
            }
        }

        public override bool Equals(object obj)
        {
            var objAsNum = obj as BitArray64;

            if (objAsNum == null)
            {
                return false;
            }
            return this.number == objAsNum.number;
        }

        public override int GetHashCode()
        {
            return this.Number.GetHashCode();
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !(first.Equals(second));
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
