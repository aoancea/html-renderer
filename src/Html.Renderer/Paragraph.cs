namespace Html.Renderer
{
    public class Paragraph : HTMLElement
    {
        public Paragraph(Page page)
            : base(page)
        { }

        public override string Render()
        {
            string renderedText = base.Render();

            return "<p>" + renderedText + "</p>";
        }
    }
}