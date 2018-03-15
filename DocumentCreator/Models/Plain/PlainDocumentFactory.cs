//
// ICT2106 Software Design - Document Creator example
//
// HTML document factory
//
// Author: Nicholas Sheppard
//

namespace ICT2106.DocumentCreator.Models.Plain
{
    class PlainDocumentFactory : IDocumentFactory
    {
        // constructor
        public PlainDocumentFactory()
        {
            // nothing to do
        }

        // create a heading
        public IHeading CreateHeading(int level, string text)
        {
            return new PlainHeading(level, text);
        }

        // create a paragraph
        public IParagraph CreateParagraph(string text)
        {
            return new PlainParagraph(text);
        }
    }
}
