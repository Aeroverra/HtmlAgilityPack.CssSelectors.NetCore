﻿using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;

namespace Tech.Aerove.HtmlAgilityPack.CssSelectors.Selectors
{
    internal class ImediateChildrenSelector : CssSelector
    {
        public override bool AllowTraverse => false;

        public override string Token => ">";

        protected internal override IEnumerable<HtmlNode> FilterCore(IEnumerable<HtmlNode> currentNodes)
        {
            return currentNodes.SelectMany(i => i.ChildNodes);
        }
    }
}