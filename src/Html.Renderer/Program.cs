using System;

namespace Html.Renderer
{
    class Program
    {
        static void Main(string[] args)
        {
            Page page = new Page();

            HTMLElement[] htmlElements = new HTMLElement[]
            {
                new Paragraph(page)
                {
                    ID = new Guid("dc2dbcaf-0b75-492a-a412-310695db0880"),
                    Text = "With the XMLHttpRequest object you can update parts of a web page, without reloading the whole page."
                },
                new Paragraph(page)
                {
                    ID = new Guid("8b77c303-a334-4cc9-bb64-2f16acf4b322"),
                    Text = "The XMLHttpRequest object is used to exchange data with a server behind the scenes.{96e76d94-e075-462e-bb55-6f742fb92c50}"
                },
                new Span(page)
                {
                    ID = new Guid("96e76d94-e075-462e-bb55-6f742fb92c50"),
                    Text = "Hello{e35fba3f-f936-47bb-9eca-bb3deb73501f}"
                },
                new Label(page)
                {
                    ID = new Guid("e35fba3f-f936-47bb-9eca-bb3deb73501f"),
                    Text = " Alex"
                }
            };

            page.AddRange_Element(htmlElements);

            string renderedPage = page.Render();

            Console.WriteLine(renderedPage);

            Console.ReadKey();
        }
    }
}