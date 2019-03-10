using OfficeOpenXml;
using System;

namespace Sorschia.Extension
{
    public static class ExcelWorksheetExtensions
    {
        public static ExcelWorksheet Range(this ExcelWorksheet instance, string cellAddress, ExcelRangeConfiguration configuration)
        {
            using (var range = instance.Cells[cellAddress])
            {
                ExcelRangeConfigurationImplementor.Instance.Implement(range, configuration);
                return instance;
            }
        }

        public static ExcelWorksheet Range(this ExcelWorksheet instance, int row, int column, ExcelRangeConfiguration configuration)
        {
            using (var range = instance.Cells[row, column])
            {
                ExcelRangeConfigurationImplementor.Instance.Implement(range, configuration);
                return instance;
            }
        }

        public static ExcelWorksheet Range(this ExcelWorksheet instance, int fromRow, int fromColumn, int toRow, int toColumn, ExcelRangeConfiguration configuration)
        {
            using (var range = instance.Cells[fromRow, fromColumn, toRow, toColumn])
            {
                ExcelRangeConfigurationImplementor.Instance.Implement(range, configuration);
                return instance;
            }
        }

        public static ExcelWorksheet Range(this ExcelWorksheet instance, string cellAddress, Action<ExcelRange> configureRange)
        {
            using (var range = instance.Cells[cellAddress])
            {
                configureRange(range);
                return instance;
            }
        }

        public static ExcelWorksheet Range(this ExcelWorksheet instance, int row, int column, Action<ExcelRange> configureRange)
        {
            using (var range = instance.Cells[row, column])
            {
                configureRange(range);
                return instance;
            }
        }

        public static ExcelWorksheet Range(this ExcelWorksheet instance, int fromRow, int fromColumn, int toRow, int toColumn, Action<ExcelRange> configureRange)
        {
            using (var range = instance.Cells[fromRow, fromColumn, toRow, toColumn])
            {
                configureRange(range);
                return instance;
            }
        }
    }
}
