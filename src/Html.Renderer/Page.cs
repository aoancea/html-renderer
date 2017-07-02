using System.Collections.Generic;

namespace Html.Renderer
{
    public class Page
    {
        public List<HTMLElement> Elements { get; set; }

        public Page()
        {
            Elements = new List<HTMLElement>();
        }

        public void Add_Element(HTMLElement htmlElement)
        {
            Elements.Add(htmlElement);
        }

        public void AddRange_Element(HTMLElement[] htmlElements)
        {
            Elements.AddRange(htmlElements);
        }

        public string Render()
        {
            string text = string.Empty;

            foreach (HTMLElement element in Elements)
            {
                text += element.Render(); // convert to StringBuilder
            }

            return text;
        }
    }
}