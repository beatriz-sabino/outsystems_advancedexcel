using System;
using System.Collections;
using System.Data;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.RuntimePublic.Db;

namespace OutSystems.NssAdvanced_Excel {

	public class CssAdvanced_Excel: IssAdvanced_Excel {

		/// <summary>
		/// Opens an existing workbook for editing by either specifying a name or the binary data.
		/// </summary>
		/// <param name="ssFileName">Location of the file that you want to open. Set to empty string &quot;&quot; when using binary data</param>
		/// <param name="ssBinary_Data">Binary data of the file that you want to open. Set to nullbinary() if using FileName</param>
		/// <param name="ssWorkbook">The workbook that you want to work with.</param>
		public void MssWorkbook_Open(string ssFileName, byte[] ssBinary_Data, out object ssWorkbook) {
			ssWorkbook = null;
			// TODO: Write implementation for action
		} // MssWorkbook_Open

		/// <summary>
		/// Select a worksheet by its index or by its name
		/// </summary>
		/// <param name="ssWorkbook">The workbook wherein the worksheet exists</param>
		/// <param name="ssWorksheetIndex">The index of the worksheet to find. Indexes start at 1</param>
		/// <param name="ssWorksheetName">The name of the worksheet to find</param>
		/// <param name="ssWorksheet">This is the worksheet object that you have been looking for,</param>
		public void MssWorksheet_Select(object ssWorkbook, int ssWorksheetIndex, string ssWorksheetName, out object ssWorksheet) {
			ssWorksheet = null;
			// TODO: Write implementation for action
		} // MssWorksheet_Select

		/// <summary>
		/// Creates a new excel workbook, optionally specifying the name of the fiirst sheet.
		/// </summary>
		/// <param name="ssWorkbook">The newly created workbook</param>
		/// <param name="ssFirstSheetName">Specify the name of the initial sheet in the workbook. Default = &quot;Sheet1&quot;</param>
		public void MssWorkbook_Create(out object ssWorkbook, string ssFirstSheetName) {
			ssWorkbook = null;
			// TODO: Write implementation for action
		} // MssWorkbook_Create

		/// <summary>
		/// Get the in-memory binary data of the specified workbook
		/// </summary>
		/// <param name="ssWorkbook">The workbook you want the binary data for</param>
		/// <param name="ssBinaryData">The binary data of the file</param>
		public void MssWorkbook_GetBinaryData(object ssWorkbook, out byte[] ssBinaryData) {
			ssBinaryData = new byte[] {};
			// TODO: Write implementation for action
		} // MssWorkbook_GetBinaryData

		/// <summary>
		/// Rename a worksheet
		/// </summary>
		/// <param name="ssWorksheet"></param>
		/// <param name="ssName">The new name for the spreadsheet</param>
		public void MssWorksheet_Rename(object ssWorksheet, string ssName) {
			// TODO: Write implementation for action
		} // MssWorksheet_Rename

		/// <summary>
		/// Closes the excel workbook
		/// </summary>
		/// <param name="ssWorkbook"></param>
		public void MssWorkbook_Close(object ssWorkbook) {
			// TODO: Write implementation for action
		} // MssWorkbook_Close

		/// <summary>
		/// Hides / Shows a Column passed by index
		/// </summary>
		/// <param name="ssWorksheet">The worksheet you want to work with.</param>
		/// <param name="ssColumn">The index of the column within the worksheet that you want to hide/show.</param>
		/// <param name="ssHidden">A Boolean value, set to True to hide the column, and to False to show the column.</param>
		public void MssColumn_Hide_Show(object ssWorksheet, int ssColumn, bool ssHidden) {
			// TODO: Write implementation for action
		} // MssColumn_Hide_Show

		/// <summary>
		/// Reads the value of a cell.
		/// </summary>
		/// <param name="ssWorksheet">Worksheet on which the cell resides</param>
		/// <param name="ssCellName">Name of the cell to read from, i.e. A4. Required if CellRow and CellNumber set to 0.</param>
		/// <param name="ssCellRow">Row number of the cell to read from. Required if CellName not set.</param>
		/// <param name="ssCellColumn">Column number of the cell to read from. Required if CellName not set.</param>
		/// <param name="ssCellValue">The value in the cell, as text.</param>
		/// <param name="ssReadText">If true always reads the cell value as text</param>
		public void MssCell_Read(object ssWorksheet, string ssCellName, int ssCellRow, int ssCellColumn, out string ssCellValue, bool ssReadText) {
			ssCellValue = "";
			// TODO: Write implementation for action
		} // MssCell_Read

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssWorksheet">Worksheet to protect</param>
		/// <param name="sspassword">Password to the protected spreadsheet</param>
		public void MssWorksheet_Protect(object ssWorksheet, string sspassword) {
			// TODO: Write implementation for action
		} // MssWorksheet_Protect

		/// <summary>
		/// Write a converted value to a cell.
		/// </summary>
		/// <param name="ssWorksheet">Worksheet on which the cell resides </param>
		/// <param name="ssCellName">Name of the cell to write to, i.e. A4. Required if CellRow and CellColumn not set</param>
		/// <param name="ssCellRow">Row number of the cell to write to. Required if CellName not set.</param>
		/// <param name="ssCellColumn">Column number of the cell to write to. Required if CellName not set.</param>
		/// <param name="ssCellValue">The value to write to the cell</param>
		/// <param name="ssCellType">Type can be:
		/// text (default),
		/// datetime,
		/// integer,
		/// decimal,
		/// boolean,
		/// formula</param>
		/// <param name="ssCellFormat">CellFormat for the target cell</param>
		public void MssCell_Write(object ssWorksheet, string ssCellName, int ssCellRow, int ssCellColumn, string ssCellValue, string ssCellType, RCCellFormatRecord ssCellFormat) {
			// TODO: Write implementation for action
		} // MssCell_Write

		/// <summary>
		/// Write a dataset to a range of cells.
		/// Accepts format for the target cells
		/// </summary>
		/// <param name="ssWorksheet">Worksheet to write to</param>
		/// <param name="ssRowStart">Start row (integer)</param>
		/// <param name="ssColumnStart">Start column (integer)</param>
		/// <param name="ssDataSet">Data to write</param>
		/// <param name="ssCellFormat">CellFormat for the target cells</param>
		/// <param name="ssExportHeaders">True to include headers in export file. Default value = False</param>
		public void MssCell_WriteRange(object ssWorksheet, int ssRowStart, int ssColumnStart, object ssDataSet, RCCellFormatRecord ssCellFormat, bool ssExportHeaders) {
			// TODO: Write implementation for action
		} // MssCell_WriteRange

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssWorksheet"></param>
		/// <param name="ssWorksheetName"></param>
		public void MssWorksheet_GetName(object ssWorksheet, out string ssWorksheetName) {
			ssWorksheetName = "";
			// TODO: Write implementation for action
		} // MssWorksheet_GetName

		/// <summary>
		/// Get all properties of the workbook
		/// </summary>
		/// <param name="ssWorkbook">The workbook</param>
		/// <param name="ssProperties"></param>
		public void MssWorkbook_GetProperties(object ssWorkbook, out RCWorkbookRecord ssProperties) {
			ssProperties = new RCWorkbookRecord(null);
			// TODO: Write implementation for action
		} // MssWorkbook_GetProperties

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssWorksheet"></param>
		/// <param name="ssProperties"></param>
		public void MssWorksheet_GetProperties(object ssWorksheet, out RCWorksheetRecord ssProperties) {
			ssProperties = new RCWorksheetRecord(null);
			// TODO: Write implementation for action
		} // MssWorksheet_GetProperties

		/// <summary>
		/// Add a worksheet to an existing workbook, optionally at the index specified. Specifying only a name will create a blank sheet. Specifying  a name with binary data, will add the sheet from the existing binary data, and then rename to the newly provided name
		/// </summary>
		/// <param name="ssWorkbook">The workbook that you want to add the sheet to</param>
		/// <param name="ssWorksheetName">The name of the worksheet you want to add. If binary data is nullbinary(), an empty sheet will be added</param>
		/// <param name="ssWorksheet">The worksheet object that you want to add. Set to nullbinary() if adding a new sheet by name</param>
		/// <param name="ssIndexWhereToAdd">The index where to add the new sheet. Default will be highest sheet index plus 1</param>
		public void MssWorkBook_AddSheet(object ssWorkbook, string ssWorksheetName, object ssWorksheet, int ssIndexWhereToAdd) {
			// TODO: Write implementation for action
		} // MssWorkBook_AddSheet

		/// <summary>
		/// Delete a worksheet in a workbook by specifying either the index, or the name of the worksheet.
		/// </summary>
		/// <param name="ssWorkbook">The workbook from which you want to delete the worksheet</param>
		/// <param name="ssIndexToDelete">The index of the worksheet to delete. Set to 0 if using the worksheet name to delete</param>
		/// <param name="ssNameToDelete">The name of the worksheet to delete. Set to empty string &quot;&quot; if using the index to delete.</param>
		public void MssWorksheet_Delete(object ssWorkbook, int ssIndexToDelete, string ssNameToDelete) {
			// TODO: Write implementation for action
		} // MssWorksheet_Delete

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssWorksheet"></param>
		/// <param name="ssChartType">Receives the chart type in text, possible types:
		/// Area3D
		/// AreaStacked3D
		/// AreaStacked1003D
		/// BarClustered3D
		/// BarStacked3D
		/// BarStacked1003D
		/// Column3D
		/// ColumnClustered3D
		/// ColumnStacked3D
		/// ColumnStacked1003D
		/// Line3D
		/// Pie3D
		/// PieExploded3D
		/// Area
		/// AreaStacked
		/// AreaStacked100
		/// BarClustered
		/// BarOfPie
		/// BarStacked
		/// BarStacked100
		/// Bubble
		/// Bubble3DEffect
		/// ColumnClustered
		/// ColumnStacked
		/// ColumnStacked100
		/// ConeBarClustered
		/// ConeBarStacked
		/// ConeBarStacked100
		/// ConeCol
		/// ConeColClustered
		/// ConeColStacked
		/// ConeColStacked100
		/// CylinderBarClustered
		/// CylinderBarStacked
		/// CylinderBarStacked100
		/// CylinderCol
		/// CylinderColClustered
		/// CylinderColStacked
		/// CylinderColStacked100
		/// Doughnut
		/// DoughnutExploded
		/// Line
		/// LineMarkers
		/// LineMarkersStacked
		/// LineMarkersStacked100
		/// LineStacked
		/// LineStacked100
		/// Pie
		/// PieExploded
		/// PieOfPie
		/// PyramidBarClustered
		/// PyramidBarStacked
		/// PyramidBarStacked100
		/// PyramidCol
		/// PyramidColClustered
		/// PyramidColStacked
		/// PyramidColStacked100
		/// Radar
		/// RadarFilled
		/// RadarMarkers
		/// StockHLC
		/// StockOHLC
		/// StockVHLC
		/// StockVOHLC
		/// Surface
		/// SurfaceTopView
		/// SurfaceTopViewWireframe
		/// SurfaceWireframe
		/// XYScatter
		/// XYScatterLines
		/// XYScatterLinesNoMarkers
		/// XYScatterSmooth
		/// XYScatterSmoothNoMarkers=73</param>
		/// <param name="ssChartName"></param>
		/// <param name="ssDataSeries_List">List Of DataSeries</param>
		/// <param name="ssHeight">Expressed in pixels</param>
		/// <param name="ssWidth">Expressed in pixels</param>
		/// <param name="ssRowPos">Row position to place the upper left corner graph</param>
		/// <param name="ssColPos">Column position to place the upper left corner graph</param>
		public void MssChart_Create(object ssWorksheet, string ssChartType, string ssChartName, RLDataSeriesRecordList ssDataSeries_List, int ssHeight, int ssWidth, int ssRowPos, int ssColPos) {
			// TODO: Write implementation for action
		} // MssChart_Create

		/// <summary>
		/// Inserts a new row into the spreadsheet.  Existing rows below the position are shifted down.  All formula are updated to take account of the new row.
		/// </summary>
		/// <param name="ssWorksheet">The worksheet to insert the row(s) into</param>
		/// <param name="ssInsertAt">The position of the new row
		/// </param>
		/// <param name="ssNrRows">Number of rows to insert</param>
		/// <param name="ssCopyStyleFromRow">Copy Styles from this row. Applied to all inserted rows. 0 will not copy any styles</param>
		public void MssRow_Insert(object ssWorksheet, int ssInsertAt, int ssNrRows, int ssCopyStyleFromRow) {
			// TODO: Write implementation for action
		} // MssRow_Insert

		/// <summary>
		/// Change the index of a worksheet in the document
		/// </summary>
		/// <param name="ssWorkbook">The workbook in which the change is to be made.</param>
		/// <param name="ssCurrentIndex">The current index(position) of the sheet in question</param>
		/// <param name="ssNewIndex">The new index for the sheet</param>
		public void MssWorkbook_ChangeSheetIndex(object ssWorkbook, int ssCurrentIndex, int ssNewIndex) {
			// TODO: Write implementation for action
		} // MssWorkbook_ChangeSheetIndex

		/// <summary>
		/// Apply a specified cell format to the range specified for the given worksheet
		/// </summary>
		/// <param name="ssWorksheet">Worksheet object where formatting is to be applied</param>
		/// <param name="ssCellFormat">CellFormat to apply</param>
		/// <param name="ssRange">Range that CellFormat is to be applied to</param>
		public void MssCellFormat_ApplyToRange(object ssWorksheet, RCCellFormatRecord ssCellFormat, RCRangeRecord ssRange) {
			// TODO: Write implementation for action
		} // MssCellFormat_ApplyToRange

		/// <summary>
		/// Find all cells that contain the specified value in the given worksheet
		/// </summary>
		/// <param name="ssWorksheet">The worksheet in which to search</param>
		/// <param name="ssValueToFind">The value to search for</param>
		/// <param name="ssListOfCells">List of cells (ranges) where the value has been found</param>
		public void MssCells_FindByValue(object ssWorksheet, string ssValueToFind, out RLRangeRecordList ssListOfCells) {
			ssListOfCells = new RLRangeRecordList();
			// TODO: Write implementation for action
		} // MssCells_FindByValue

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssWorksheet"></param>
		/// <param name="ssRange"></param>
		/// <param name="ssValue"></param>
		/// <param name="ssParameter1"></param>
		/// <param name="ssFound"></param>
		/// <param name="ssRowIndex"></param>
		/// <param name="ssColumnIndex"></param>
		public void MssContainInRange(object ssWorksheet, string ssRange, string ssValue, string ssParameter1, out bool ssFound, out int ssRowIndex, out int ssColumnIndex) {
			ssFound = false;
			ssRowIndex = 0;
			ssColumnIndex = 0;
			// TODO: Write implementation for action
		} // MssContainInRange

		/// <summary>
		/// Calculate all formulae for the entire workbook provided.
		/// </summary>
		/// <param name="ssWorkbook">The workbook to work with</param>
		public void MssWorkbook_Calculate(object ssWorkbook) {
			// TODO: Write implementation for action
		} // MssWorkbook_Calculate

		/// <summary>
		/// Calculate all formulae on the provided worksheet.
		/// </summary>
		/// <param name="ssWorksheet">The worksheet to work with</param>
		public void MssWorksheet_Calculate(object ssWorksheet) {
			// TODO: Write implementation for action
		} // MssWorksheet_Calculate

		/// <summary>
		/// Hides / Shows Row passed by index
		/// </summary>
		/// <param name="ssWorksheet">Worksheet to work with</param>
		/// <param name="ssRowIndex">Index of the Row to show/hide</param>
		/// <param name="ssHidden">A Boolean value, set to True to hide the row and to False to show the row</param>
		public void MssRow_Hide_Show(object ssWorksheet, int ssRowIndex, bool ssHidden) {
			// TODO: Write implementation for action
		} // MssRow_Hide_Show

		/// <summary>
		/// Hide / Show a worksheet
		/// </summary>
		/// <param name="ssWorksheet">The worksheet to work with</param>
		/// <param name="ssHidden">Visible = 0 - The worksheet is visible
		/// Hidden = 1 - The worksheet is hidden but can be shown by the user via the user interface
		/// VeryHidden = 2 - The worksheet is hidden and cannot be shown by the user via the user interface</param>
		public void MssWorksheet_Hide_Show(object ssWorksheet, int ssHidden) {
			// TODO: Write implementation for action
		} // MssWorksheet_Hide_Show

		/// <summary>
		/// Add a rule for conditionally formatting a range of cells.
		/// </summary>
		/// <param name="ssWorksheet">The worksheet to work with</param>
		/// <param name="ssConditionalFormatRecord">The conditional formatting to apply to the Address Range</param>
		public void MssConditionalFormatting_AddRule(object ssWorksheet, RCConditionalFormatItemRecord ssConditionalFormatRecord) {
			// TODO: Write implementation for action
		} // MssConditionalFormatting_AddRule

		/// <summary>
		/// Get a list of all the conditional formatting rules in a worksheet.
		/// </summary>
		/// <param name="ssWorksheet">The worksheet to work with</param>
		/// <param name="ssListOfRule">List of conditional formatting rules</param>
		public void MssConditionalFormatting_GetAllRules(object ssWorksheet, out RLConditionalFormatItemRecordList ssListOfRule) {
			ssListOfRule = new RLConditionalFormatItemRecordList();
			// TODO: Write implementation for action
		} // MssConditionalFormatting_GetAllRules

		/// <summary>
		/// Merge cells in the range provided
		/// </summary>
		/// <param name="ssWorksheet">The worksheet to work with</param>
		/// <param name="ssRangeToMerge">The range of the cells to merge</param>
		public void MssCell_Merge(object ssWorksheet, RCRangeRecord ssRangeToMerge) {
			// TODO: Write implementation for action
		} // MssCell_Merge

		/// <summary>
		/// Un-Merge cells in the range provided
		/// </summary>
		/// <param name="ssWorksheet">The worksheet to work with</param>
		/// <param name="ssRangeToUnmerge">The range of cell to un-merge</param>
		public void MssCell_UnMerge(object ssWorksheet, RCRangeRecord ssRangeToUnmerge) {
			// TODO: Write implementation for action
		} // MssCell_UnMerge

		/// <summary>
		/// Delete row(s) from a worksheet
		/// </summary>
		/// <param name="ssWorksheet">The worksheet to work with</param>
		/// <param name="ssStartRowNumber">Row number where to start deleting rows.</param>
		/// <param name="ssNumberOfRows">The number of rows to delete. Default = 1.</param>
		public void MssRow_Delete(object ssWorksheet, int ssStartRowNumber, int ssNumberOfRows) {
			// TODO: Write implementation for action
		} // MssRow_Delete

		/// <summary>
		/// Delete column(s) from a worksheet
		/// </summary>
		/// <param name="ssWorksheet">The worksheet to work with</param>
		/// <param name="ssStartColumnNumber">Column number where to start deleting columns.</param>
		/// <param name="ssNumberOfColumns">The number of rows to delete. Default = 1.</param>
		public void MssColumn_Delete(object ssWorksheet, int ssStartColumnNumber, int ssNumberOfColumns) {
			// TODO: Write implementation for action
		} // MssColumn_Delete

		/// <summary>
		/// Delete comment(s) in a specified range
		/// </summary>
		/// <param name="ssWorksheet">The worksheet to work with.</param>
		/// <param name="ssRange">Range to delete comments from.</param>
		public void MssComment_Delete(object ssWorksheet, RCRangeRecord ssRange) {
			// TODO: Write implementation for action
		} // MssComment_Delete

		/// <summary>
		/// Add a comment to a cell
		/// </summary>
		/// <param name="ssWorksheet">The worksheet to work with.</param>
		/// <param name="ssRowNumber">The row number of the cell to add the comment to.</param>
		/// <param name="ssColumnNumber">The column number of the cell to add the comment to.</param>
		/// <param name="ssText">The comment.</param>
		/// <param name="ssAuthor">The author of the comment.</param>
		public void MssComment_Add(object ssWorksheet, int ssRowNumber, int ssColumnNumber, string ssText, string ssAuthor) {
			// TODO: Write implementation for action
		} // MssComment_Add

		/// <summary>
		/// Inserts a new column into the spreadsheet.  Existing columns to the right of the insert index will be shifted right.  All formula are updated to take account of the new column.
		/// </summary>
		/// <param name="ssWorksheet">The worksheet to work with.</param>
		/// <param name="ssInsertAt">Column number where to insert new column.</param>
		/// <param name="ssNumberOfColumns">The number of columns to insert.</param>
		/// <param name="ssCopyStylesFrom">Copy Styles from this column. Applied to all inserted columns. 0 (default) will not copy any styles</param>
		public void MssColumn_Insert(object ssWorksheet, int ssInsertAt, int ssNumberOfColumns, int ssCopyStylesFrom) {
			// TODO: Write implementation for action
		} // MssColumn_Insert

		/// <summary>
		/// Delete a specified Conditional Formatting rule on a worksheet
		/// </summary>
		/// <param name="ssWorksheet">The worksheet to work with.</param>
		/// <param name="ssRuleToDeleteIndex">The index of the rule to be deleted.</param>
		public void MssConditionalFormatting_DeleteRule(object ssWorksheet, int ssRuleToDeleteIndex) {
			// TODO: Write implementation for action
		} // MssConditionalFormatting_DeleteRule

		/// <summary>
		/// Delete ALL Conditional Formatting rules for a worksheet
		/// </summary>
		/// <param name="ssWorksheet">The worksheet to work with.</param>
		public void MssConditionalFormatting_DeleteAllRules(object ssWorksheet) {
			// TODO: Write implementation for action
		} // MssConditionalFormatting_DeleteAllRules

		/// <summary>
		/// Insert an image into a Worksheet
		/// </summary>
		/// <param name="ssWorksheet">The worksheet to work with</param>
		/// <param name="ssImageFile">Binary data of the image to be inserted</param>
		/// <param name="ssImageType">File type. BMP, PNG, JPG</param>
		/// <param name="ssImageName">Name reference for the image in the Worksheet</param>
		/// <param name="ssRowNumber">Row index where to insert image. Ignored if CellName is specified</param>
		/// <param name="ssColumnNumber">Column index where to insert image. Ignored if CellName is specified</param>
		/// <param name="ssCellName">Cell Name where to insert image</param>
		/// <param name="ssImageWidth">The width of the image in pixels</param>
		/// <param name="ssImageHeight">The height of the image in pixels</param>
		public void MssImage_Insert(object ssWorksheet, byte[] ssImageFile, string ssImageType, string ssImageName, int ssRowNumber, int ssColumnNumber, string ssCellName, int ssImageWidth, int ssImageHeight) {
			// TODO: Write implementation for action
		} // MssImage_Insert

		/// <summary>
		/// Apply the column autofit action to the specified range of cells specified in the given worksheet
		/// </summary>
		/// <param name="ssWorksheet">The worksheet to work with</param>
		public void MssWorksheet_AutofitColumns(object ssWorksheet) {
			// TODO: Write implementation for action
		} // MssWorksheet_AutofitColumns

		/// <summary>
		/// Add the automatic filter option of Excel to the specified range of cells.
		/// </summary>
		/// <param name="ssWorksheet">The worksheet to work with.</param>
		/// <param name="ssRangeToFilter">The range where to add the filter. If not supplied, the dimension of the worksheet will be used.</param>
		public void MssWorksheet_AddAutoFilter(object ssWorksheet, RCRangeRecord ssRangeToFilter) {
			// TODO: Write implementation for action
		} // MssWorksheet_AddAutoFilter

	} // CssAdvanced_Excel

} // OutSystems.NssAdvanced_Excel

