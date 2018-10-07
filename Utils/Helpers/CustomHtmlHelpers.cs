using System.Collections.Generic;
using System.Web.Mvc;

namespace Blog.Utils.Helpers
{
    public static class CustomHtmlHelpers
    {
        public static MvcHtmlString CreateList(this HtmlHelper htmlHelper, IEnumerable<string> items, string htmlTagName)
        {
            if (items == null)
            {
                return new MvcHtmlString(string.Empty);
            }

            TagBuilder list = new TagBuilder(htmlTagName);

            foreach (var item in items)
            {
                TagBuilder li = new TagBuilder("li");
                li.SetInnerText(item);
                list.InnerHtml += li.ToString();
            }

            return new MvcHtmlString(list.ToString());

        }
    }
}