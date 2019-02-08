using OfficeOpenXml;

namespace Sorschia.Extension
{
    public static class ExcelWorksheetExtensions
    {
        private static void SetRangeProperties(ExcelRange range, ExcelRangeConfiguration configuration)
        {
            if (configuration.Value != null)
            {
                range.Value = configuration.Value;
            }

            if (configuration.IsMerged != null)
            {
                range.Merge = configuration.IsMerged.Value;
            }

            if (configuration.VerticalAlignment != null)
            {
                range.Style.VerticalAlignment = configuration.VerticalAlignment.Value;
            }

            if (configuration.HorizontalAlignment != null)
            {
                range.Style.HorizontalAlignment = configuration.HorizontalAlignment.Value;
            }

            if (configuration.IsBorderedAll ?? false)
            {
                range.Style.Border.BorderAround(configuration.AllBorderStyle ?? ExcelDefaults.BorderStyle);
            }

            if (configuration.IsBorderedLeft ?? false)
            {
                range.Style.Border.Left.Style = configuration.BorderLeftStyle ?? ExcelDefaults.BorderStyle;
            }

            if (configuration.IsBorderedTop ?? false)
            {
                range.Style.Border.Top.Style = configuration.BorderTopStyle ?? ExcelDefaults.BorderStyle;
            }

            if (configuration.IsBorderedBottom ?? false)
            {
                range.Style.Border.Bottom.Style = configuration.BorderBottomStyle ?? ExcelDefaults.BorderStyle;
            }

            if (configuration.IsBorderedRight ?? false)
            {
                range.Style.Border.Right.Style = configuration.BorderRightStyle ?? ExcelDefaults.BorderStyle;
            }

            if (configuration.NumberFormat != null)
            {
                range.Style.Numberformat.Format = configuration.NumberFormat;
            }

            if (configuration.IsFontBold != null)
            {
                range.Style.Font.Bold = configuration.IsFontBold.Value;
            }

            if (configuration.IsFontItalic != null)
            {
                range.Style.Font.Italic = configuration.IsFontItalic.Value;
            }

            if (configuration.IsFontUnderlined != null)
            {
                range.Style.Font.UnderLine = configuration.IsFontUnderlined.Value;
            }
        }

        public static ExcelWorksheet Range(this ExcelWorksheet instance, string cellAddress, ExcelRangeConfiguration configuration)
        {
            using (var range = instance.Cells[cellAddress])
            {
                SetRangeProperties(range, configuration);
                return instance;
            }
        }

        public static ExcelWorksheet Range(this ExcelWorksheet instance, int row, int column, ExcelRangeConfiguration configuration)
        {
            using (var range = instance.Cells[row, column])
            {
                SetRangeProperties(range, configuration);
                return instance;
            }
        }

        public static ExcelWorksheet Range(this ExcelWorksheet instance, int fromRow, int fromColumn, int toRow, int toColumn, ExcelRangeConfiguration configuration)
        {
            using (var range = instance.Cells[fromRow, fromColumn, toRow, toColumn])
            {
                SetRangeProperties(range, configuration);
                return instance;
            }
        }
    }
}
