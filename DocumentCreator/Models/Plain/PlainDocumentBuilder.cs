//
// ICT2106 Software Design - Document Creator example
//
// HTML document builder.
//
// Author: Nicholas Sheppard
//

namespace ICT2106.DocumentCreator.Models.Plain
{
    class PlainDocumentBuilder : IDocumentBuilder
    {
        private PlainDocument doc;
        private string title;
        private string author;
        private string body;

        // constructor
        public PlainDocumentBuilder()
        {
            // nothing to do
        }

        // start building a new document
        public void OpenDocument()
        {
             doc = new PlainDocument();

             // erase the title and author
             title = "";
             author = "";
             body = "";
               
        }

        // build the <head> element
        public void BuildHead(string titleIn, string authorIn)
        {
            // save the title and author for later
            title = titleIn.ToUpper();
            author = authorIn;


            // set the title of the document
            doc.SetTitle(title);
            doc.SetAuthor(author);
        }

        // build the <body> element
        public void BuildBody(string bodyIn)
        {

            body = bodyIn;

            // set the title of the document
            doc.SetBody(body);

            //// add a top-level heading containing the title
            //doc.AppendToBody(new PlainHeading(1, title));

            //// add a second-level heading containing the author
            //doc.AppendToBody(new PlainHeading(2, "by " + author));

            //// add a paragraph containing the text
            //doc.AppendToBody(new PlainParagraph(textIn));
        }

        // finish the document
        public void CloseDocument()
        {
            // nothing to do
        }

        // get the document being built
        public IDocument GetDocument()
        {
            return doc;
        }
    }
}
