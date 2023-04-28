using System;
using System.Collections.Generic;
using System.Text;

namespace SGenLab.EnumGenerators
{
    public readonly struct EnumToGenerate
    {
        public readonly string Name;
        public readonly List<string> Values;

        public EnumToGenerate(string name, List<string> values)
        {
            Name = name;
            Values = values;
        }
    }
}
