using System;

namespace Html.Renderer
{
    public class HTMLElement
    {
        private readonly Page page;

        public string Text { get; set; }
        public Guid ID { get; set; }

        public HTMLElement(Page page)
        {
            this.page = page;
        }

        public virtual string Render()
        {
            Literal[] literals = GetLiterals();

            string renderedHTML = Render_Internal(Text, literals);

            return renderedHTML;
        }

        private Literal[] GetLiterals()
        {
            Literal[] literals = Parse_Literals(Text, page.Elements);

            return literals;
        }

        private string Render_Internal(string text, Literal[] literals)
        {
            return string.Empty;
        }

        private Literal[] Parse_Literals(string text, object hTMLElements)
        {
            return new Literal[0];
        }
    }
}