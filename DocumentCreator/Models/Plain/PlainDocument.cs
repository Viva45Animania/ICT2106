//
// ICT2106 Software Design - Document Creator example
//
// HTML document.
//
// Author: Nicholas Sheppard
//
using System.Collections.Generic;
using System.Text;

namespace ICT2106.DocumentCreator.Models.Plain
{
    public class PlainDocument : IDocument
    {
        // the title of the document
        private string title = "";
        private string body = "";
        private string author = "";
        //// the elements making up the body of the document
        //private IList<HtmlElement> body = new List<HtmlElement>();


        // constructor
        public PlainDocument()
        {
            // nothing to do
        }


        //// append an element to the body of the document
        //public void AppendToBody(HtmlElement elementIn)
        //{
        //    body.Add(elementIn);
        //}

        // make a deep clone of the document
        public IDocument Clone()
        {
            PlainDocument clone = new PlainDocument();
            clone.SetTitle(title);
            clone.SetBody(body);
            clone.SetAuthor(author);

            return clone;
        }


        // get a string representing the document
        public string GetString()
        {
            StringBuilder sbuilder = new StringBuilder();
            sbuilder.Append(title);
            sbuilder.Append("\n\n");
            sbuilder.Append(author);
            sbuilder.Append("\n\n");
            sbuilder.Append(body);
            return sbuilder.ToString();
        }


        // set the title of the document
        public void SetTitle(string titleIn)
        {
            title = titleIn;
        }

        // set the title of the document
        public void SetBody(string bodyIn)
        {
            body = bodyIn;
        }

        // set the title of the document
        public void SetAuthor(string authorIn)
        {
            author = authorIn;
        }
    }
}
