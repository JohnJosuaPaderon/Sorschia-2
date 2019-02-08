using OfficeOpenXml.Style;

namespace Sorschia
{
    public struct ExcelRangeConfiguration
    {
        public object Value { get; set; }
        public bool? IsMerged { get; set; }
        public ExcelVerticalAlignment? VerticalAlignment { get; set; }
        public ExcelHorizontalAlignment? HorizontalAlignment { get; set; }
        public bool? IsBorderedAll { get; set; }
        public bool? IsBorderedTop { get; set; }
        public bool? IsBorderedBottom { get; set; }
        public bool? IsBorderedLeft { get; set; }
        public bool? IsBorderedRight { get; set; }
        public ExcelBorderStyle? AllBorderStyle { get; set; }
        public ExcelBorderStyle? BorderTopStyle { get; set; }
        public ExcelBorderStyle? BorderBottomStyle { get; set; }
        public ExcelBorderStyle? BorderLeftStyle { get; set; }
        public ExcelBorderStyle? BorderRightStyle { get; set; }
        public string NumberFormat { get; set; }
        public bool? IsFontBold { get; set; }
        public bool? IsFontItalic { get; set; }
        public bool? IsFontUnderlined { get; set; }
    }
}
