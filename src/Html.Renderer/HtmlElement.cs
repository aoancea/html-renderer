using System;
using System.Collections.Generic;
using System.Linq;

namespace Html.Renderer
{
    public class HTMLElement
    {
        private readonly Page page;

        public string Text { get; set; }
        public Guid ID { get; set; }

        public List<Literal> Literals { get; set; }

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

            Literals = literals.ToList();

            return literals;
        }

        private string Render_Internal(string text, Literal[] literals)
        {
            return string.Empty;
        }

        private Literal[] Parse_Literals(string text, List<HTMLElement> hTMLElements)
        {
            List<Literal> literals = new List<Literal>();

            bool isOpenning = false;

            string id = string.Empty;

            foreach (char c in text)
            {
                if (!isOpenning && c == '{')
                {
                    isOpenning = true;
                }
                else if (isOpenning && c == '}')
                {
                    isOpenning = false;

                    Guid elementId = Guid.Parse(id);

                    HTMLElement htmlElement = null; // hTMLElements.First(element => element.ID == elementId);

                    foreach (HTMLElement element in hTMLElements)
                    {
                        if (element.ID == elementId)
                        {
                            htmlElement = element;
                            break;
                        }
                    }

                    literals.Add(new Literal() { ID = elementId, Element = htmlElement });
                }
                else if (isOpenning)
                {
                    // read ID

                    id += c;
                }
            }


            return literals.ToArray();
        }
    }
}