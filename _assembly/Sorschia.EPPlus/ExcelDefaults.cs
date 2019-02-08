using OfficeOpenXml.Style;

namespace Sorschia
{
    public static class ExcelDefaults
    {
        public static ExcelHorizontalAlignment HorizontalAlignment { get; set; } = ExcelHorizontalAlignment.Left;
        public static ExcelVerticalAlignment VerticalAlignment { get; set; } = ExcelVerticalAlignment.Center;
        public static ExcelBorderStyle BorderStyle { get; set; } = ExcelBorderStyle.Thin;
    }
}
