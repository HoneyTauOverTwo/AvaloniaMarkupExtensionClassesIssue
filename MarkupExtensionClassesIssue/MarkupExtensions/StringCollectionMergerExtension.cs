using Avalonia.Markup.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarkupExtensionClassesIssue.MarkupExtensions
{
    public class StringCollectionMergerExtension : MarkupExtension
    {
        public List<StringItem> Items { get; set; } = [];

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return string.Join(" ", Items
                .Select(item => item?.Value)
                .Where(s => !string.IsNullOrEmpty(s)));
        }
    }

    public class StringItem
    {
        public string? Value { get; set; }
    }
}
