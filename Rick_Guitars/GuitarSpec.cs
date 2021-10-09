using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rick_Guitars
{
    class GuitarSpec
    {
        private Builder builder;
        private string model;
        private NumStrings numStrings;
        private Type type;
        private Wood backWood;
        private Wood topWood;

        public GuitarSpec(Builder builder, string model, NumStrings numStrings, Type type, Wood backWood, Wood topWood)
        {
            this.builder = builder;
            this.model = model;
            this.numStrings = numStrings;
            this.type = type;
            this.backWood = backWood;
            this.topWood = topWood;
        }

        public Builder getBuilder()
        {
            return builder;
        }
        public string getModel()
        {
            return model;
        }
        public NumStrings getNumString()
        {
            return numStrings;
        }
        public Type getType()
        {
            return type;
        }
        public Wood getBackWood()
        {
            return backWood;
        }
        public Wood getTopWood()
        {
            return topWood;
        }
    }
}
