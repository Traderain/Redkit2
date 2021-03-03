using System;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace WolvenKit.Functionality.Extensions
{
    public static class RichTextBoxExtensions
    {
        //https://stackoverflow.com/a/23402165
        public static void AppendText(this RichTextBox box, string text, string color)
        {
            BrushConverter bc = new BrushConverter();
            TextRange tr = new TextRange(box.Document.ContentEnd, box.Document.ContentEnd);
            tr.Text = text;
            try
            {
                tr.ApplyPropertyValue(TextElement.ForegroundProperty,
                    bc.ConvertFromString(color));
            }
            catch (FormatException) { }
        }
    }
}
