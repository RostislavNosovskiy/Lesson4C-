using System;
using System.Reflection;

namespace Lesson4
{
    public class Bits : IBeats
    { 
        public long Value { get; private set; } = 0;
        private readonly int size = 0;
        public Bits(long value)
        {
            Value = value;
            size = sizeof(long);
        }

        public static  explicit operator long(Bits bits) => (long)bits.Value;
        public static implicit operator Bits(long b) => new Bits(b);

        public static explicit operator int(Bits bits) => (int)bits.Value;
        public static implicit operator Bits(int b) => new Bits(b);

        public static explicit operator byte(Bits bits) => (byte)bits.Value;
        public static implicit operator Bits(byte b) => new Bits(b);



        public bool this[int index] // Реализация переопределения индексации переменной
        {
            get
            {
                if (index > size || index < 0) return false;
                return((Value >> index)&1) ==1;
            }
            private set
            {
                if (index > size || index < 0) return;
                if (value == true)
                    Value = (long)
                        (Value | (1 << index));
                else
                {
                    var mask = (long)
                        (1 << index);
                    mask = ~mask;
                    Value &= (long)
                        (Value & mask);

                }
           
            }
        }

    
        public bool GetBeat(int number)
        {
            return this[number];
        }

        public void SetBeat(int index, bool value)
        {
            this[index] = value;
        }
    }
}

