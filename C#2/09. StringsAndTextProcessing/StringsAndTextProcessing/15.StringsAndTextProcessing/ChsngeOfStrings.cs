
// 15.
// Write a program that replaces in a HTML document given as 
// string all the tags <a href="…">…</a> with corresponding 
// tags [URL=…]…/URL]. Sample HTML fragment:
//
// <p>Please visit <a href="http://academy.telerik. com">our 
// site</a> to choose a training course. Also visit 
// <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
//
// <p>Please visit [URL=http://academy.telerik. com]our site[/URL] 
// to choose a training course. Also visit [URL=www.devbg.org]our 
// forum[/URL] to discuss the courses.</p>

using System;
using System.Text.RegularExpressions;

class ChsngeOfStrings
    {
    static void Main()
    {
        string givenText = @"<p>Please visit <a href=""http://academy.telerik. com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
        string pattern = "<a href=\"(.*?)\">(.*?)</a>";
        Console.WriteLine(Regex.Replace(givenText, pattern, "[URL=]$2[/URL=]"));
    }
}