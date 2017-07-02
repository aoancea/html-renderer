namespace Html.Renderer
{
    internal class Label : HTMLElement
    {
        public Label(Page page)
            : base(page)
        { }
        public override string Render()
        {
            string renderedText = base.Render();

            return "<label>" + renderedText + "</label>";
        }
    }
}