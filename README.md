TumblrMVC
================================
TumblrMVC is basically a way to request posts from a tumblr blog and display them within an MVC site. I found it useful for my own site where the blog itself could be themed within tumblr, but I wanted a summary of the latest blog entries on the homepage. It requests the blog JSON from tumblr, deserialises into POCO classes, then uses RazorEngine to render a razor view for each post. The project contains an HtmlHelper that you supply your blog address, your api key, the number of items you'd like returned and the name of a razor view (in a location that the razor view engine can find it). For example...

    @Html.TumblrTopPosts("chrispont.co.uk", "xxxAPIKeyxxx", 8, "BlogItem");

BlogItem.cshtml is included as an example in the project. Just move it to your Shared view folder. Register the extensions namespace in the web.config in the views folder

    <namespaces>
        ....
        <add namespace="boardwalk.tumblr.Extensions"/>
        ....
    </namespaces>