namespace Html.Renderer
{
    internal class Span : HTMLElement
    {
        public Span(Page page)
            : base(page)
        {}

        public override string Render()
        {
            string renderedText = base.Render();

            return "<span>" + renderedText + "</span>";
        }
    }
}