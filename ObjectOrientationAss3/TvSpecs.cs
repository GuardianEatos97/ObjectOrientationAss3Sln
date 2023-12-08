using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientationAss3
{
    internal class TvSpecs
    {
        public string BrandOfTv;
        public int WidthOfTv;
        public int HeightOfTv;
        public string Resolution;
        string ColorOfTv;
        public bool Power;
        SpeakersSpecs SpeakersSpecs;

        public TvSpecs(string brandoftv, int widthOfTv, int heightOfTv, bool resolution, string speakername, string coloroftv, bool power)
        {
            WidthOfTv = widthOfTv;
            HeightOfTv = heightOfTv;
            BrandOfTv = brandoftv;
            ColorOfTv = coloroftv;
            Power = power;
            SpeakersSpecs = new SpeakersSpecs();
            SpeakersSpecs.Name = speakername;

            if (resolution) 
            {
                Resolution = "is a high resolution tv";
            }
            else
            {
                Resolution = "is not a high resolution tv";
            }
        }
        public bool PowerButton()
        {
            return Power = !Power;
        }
    }

    
}
