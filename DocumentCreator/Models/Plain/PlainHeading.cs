﻿//
// ICT2106 Software Design - Document Creator example
//
// HTML heading.
//
// Author: Nicholas Sheppard
//

namespace ICT2106.DocumentCreator.Models.Plain
{
    class PlainHeading : IHeading
    {
        private int level;
        private string text;





        // constructor
        public PlainHeading(int levelIn, string textIn)
        {
            level = levelIn;
            text = textIn;

            // HTML supports heading levels of 1 through 6, so make sure the level is one of these
            //if (level < 1)
            //    level = 1;
            //else if (level > 6)
                //level = 6;
        }

        // // create a deep clone of the heading
        // public override HtmlElement Clone()
        // {
        //     return new HtmlHeading(level, text);
        // }

		// headings in HTML are denoted by "<hN>...</hN>" where N is the level of the header
        public string String => text + "\n";

      

		// get the level of the header
		public int GetLevel()
        {
            return level;
        }

        int IHeading.GetLevel()
        {
            throw new System.NotImplementedException();
        }
    }
}
