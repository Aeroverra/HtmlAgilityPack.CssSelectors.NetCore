using System.Collections.Generic;
using HtmlAgilityPack;

namespace Tech.Aerove.HtmlAgilityPack.CssSelectors.Selectors
{
    internal class AllSelector : CssSelector
    {
        public override string Token => "*";

        protected internal override IEnumerable<HtmlNode> FilterCore(IEnumerable<HtmlNode> currentNodes)
        {
            return currentNodes;
        }
    }
}