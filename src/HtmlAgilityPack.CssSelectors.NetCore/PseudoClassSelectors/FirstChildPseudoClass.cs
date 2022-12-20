using HtmlAgilityPack;
namespace Tech.Aerove.HtmlAgilityPack.CssSelectors.PseudoClassSelectors
{
    [PseudoClassName("first-child")]
    internal class FirstChildPseudoClass : PseudoClass
    {
        protected override bool CheckNode(HtmlNode node, string parameter)
        {
            return node.GetIndexOnParent() == 0;
        }
    }
}