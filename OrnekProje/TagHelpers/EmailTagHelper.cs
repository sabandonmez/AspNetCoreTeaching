﻿using Microsoft.AspNetCore.Razor.TagHelpers;

namespace OrnekProje.TagHelpers
{
    [HtmlTargetElement("ahmet")]
    public class EmailTagHelper : TagHelper
    {
        public string Email { get; set; }
        public string Display { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.Add("href",$"mailto:{Email}");
            output.Content.Append(Display);

        }

    }
}
