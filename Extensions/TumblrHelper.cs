using boardwalk.tumblr.Data;
using RazorEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace boardwalk.tumblr.Extensions
{
    public static class HtmlHelperExtensions
    {
        public static MvcHtmlString TumblrTopPosts(this HtmlHelper html, string blog, string consumerKey, int numberOfPosts, string template)
        {
            StringBuilder htmlString = new StringBuilder();
            TumblrRequestHelper request = new TumblrRequestHelper(blog, consumerKey, true);
            TumblrResponse response = request.GetPosts();

            var viewResult = ViewEngines.Engines.FindPartialView(html.ViewContext.Controller.ControllerContext, template);

            if(!(viewResult.View is RazorView))
            {
                throw new Exception("Only razor views are supported");
            }
            var razorView = (RazorView)viewResult.View;
            var viewFile = System.IO.File.ReadAllText(html.ViewContext.HttpContext.Server.MapPath(razorView.ViewPath));

            response.response.posts.Where(p => p.type != "quote")
                .Take(numberOfPosts)
                .ToList()
                .ForEach(p => htmlString.Append(Razor.Parse(viewFile, p)));

            return MvcHtmlString.Create(htmlString.ToString());
        }
    }
}
