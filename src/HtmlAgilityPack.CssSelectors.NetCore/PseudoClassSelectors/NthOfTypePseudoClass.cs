using HtmlAgilityPack;
namespace Tech.Aerove.HtmlAgilityPack.CssSelectors.PseudoClassSelectors
{
  [PseudoClassName("nth-of-type")]
  internal class NthOfTypePseudoClass : PseudoClass
  {
    protected override bool CheckNode(HtmlNode node, string parameter)
    {
      return node.GetIndexOnParent() == int.Parse(parameter);
    }
  }
}
