﻿Imports Microsoft.VisualBasic
Imports System
Namespace HowToBindToMDB


	''' <summary>
	'''Represents a strongly typed in-memory cache of data.
	'''</summary>
	<Global.System.Serializable(), Global.System.ComponentModel.DesignerCategoryAttribute("code"), Global.System.ComponentModel.ToolboxItem(True), Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema"), Global.System.Xml.Serialization.XmlRootAttribute("DataSet1"), Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")> _
	Partial Public Class NwindDataSet
		Inherits System.Data.DataSet

		Private tableCategoryProducts As CategoryProductsDataTable

		Private tableSalesPerson As SalesPersonDataTable

		Private tableCustomerReports As CustomerReportsDataTable

		Private tableInvoices As InvoicesDataTable

		Private tableOrderDetails As OrderDetailsDataTable

		Private tableOrderReports As OrderReportsDataTable

		Private tableProductReports As ProductReportsDataTable

		Private _schemaSerializationMode As Global.System.Data.SchemaSerializationMode = Global.System.Data.SchemaSerializationMode.IncludeSchema

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Public Sub New()
			Me.BeginInit()
			Me.InitClass()
			Dim schemaChangedHandler As New Global.System.ComponentModel.CollectionChangeEventHandler(AddressOf Me.SchemaChanged)
			AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
			AddHandler MyBase.Relations.CollectionChanged, schemaChangedHandler
			Me.EndInit()
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
			MyBase.New(info, context, False)
			If (Me.IsBinarySerialized(info, context) = True) Then
				Me.InitVars(False)
				Dim schemaChangedHandler1 As New Global.System.ComponentModel.CollectionChangeEventHandler(AddressOf Me.SchemaChanged)
				AddHandler Me.Tables.CollectionChanged, schemaChangedHandler1
				AddHandler Me.Relations.CollectionChanged, schemaChangedHandler1
				Return
			End If
			Dim strSchema As String = (CStr(info.GetValue("XmlSchema", GetType(String))))
			If (Me.DetermineSchemaSerializationMode(info, context) = Global.System.Data.SchemaSerializationMode.IncludeSchema) Then
				Dim ds As New Global.System.Data.DataSet()
				ds.ReadXmlSchema(New Global.System.Xml.XmlTextReader(New Global.System.IO.StringReader(strSchema)))
				If (ds.Tables("CategoryProducts") IsNot Nothing) Then
					MyBase.Tables.Add(New CategoryProductsDataTable(ds.Tables("CategoryProducts")))
				End If
				If (ds.Tables("SalesPerson") IsNot Nothing) Then
					MyBase.Tables.Add(New SalesPersonDataTable(ds.Tables("SalesPerson")))
				End If
				If (ds.Tables("CustomerReports") IsNot Nothing) Then
					MyBase.Tables.Add(New CustomerReportsDataTable(ds.Tables("CustomerReports")))
				End If
				If (ds.Tables("Invoices") IsNot Nothing) Then
					MyBase.Tables.Add(New InvoicesDataTable(ds.Tables("Invoices")))
				End If
				If (ds.Tables("OrderDetails") IsNot Nothing) Then
					MyBase.Tables.Add(New OrderDetailsDataTable(ds.Tables("OrderDetails")))
				End If
				If (ds.Tables("OrderReports") IsNot Nothing) Then
					MyBase.Tables.Add(New OrderReportsDataTable(ds.Tables("OrderReports")))
				End If
				If (ds.Tables("ProductReports") IsNot Nothing) Then
					MyBase.Tables.Add(New ProductReportsDataTable(ds.Tables("ProductReports")))
				End If
				Me.DataSetName = ds.DataSetName
				Me.Prefix = ds.Prefix
				Me.Namespace = ds.Namespace
				Me.Locale = ds.Locale
				Me.CaseSensitive = ds.CaseSensitive
				Me.EnforceConstraints = ds.EnforceConstraints
				Me.Merge(ds, False, Global.System.Data.MissingSchemaAction.Add)
				Me.InitVars()
			Else
				Me.ReadXmlSchema(New Global.System.Xml.XmlTextReader(New Global.System.IO.StringReader(strSchema)))
			End If
			Me.GetSerializationData(info, context)
			Dim schemaChangedHandler As New Global.System.ComponentModel.CollectionChangeEventHandler(AddressOf Me.SchemaChanged)
			AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
			AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Global.System.ComponentModel.Browsable(False), Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)> _
		Public ReadOnly Property CategoryProducts() As CategoryProductsDataTable
			Get
				Return Me.tableCategoryProducts
			End Get
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Global.System.ComponentModel.Browsable(False), Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)> _
		Public ReadOnly Property SalesPerson() As SalesPersonDataTable
			Get
				Return Me.tableSalesPerson
			End Get
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Global.System.ComponentModel.Browsable(False), Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)> _
		Public ReadOnly Property CustomerReports() As CustomerReportsDataTable
			Get
				Return Me.tableCustomerReports
			End Get
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Global.System.ComponentModel.Browsable(False), Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)> _
		Public ReadOnly Property Invoices() As InvoicesDataTable
			Get
				Return Me.tableInvoices
			End Get
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Global.System.ComponentModel.Browsable(False), Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)> _
		Public ReadOnly Property OrderDetails() As OrderDetailsDataTable
			Get
				Return Me.tableOrderDetails
			End Get
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Global.System.ComponentModel.Browsable(False), Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)> _
		Public ReadOnly Property OrderReports() As OrderReportsDataTable
			Get
				Return Me.tableOrderReports
			End Get
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Global.System.ComponentModel.Browsable(False), Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)> _
		Public ReadOnly Property ProductReports() As ProductReportsDataTable
			Get
				Return Me.tableProductReports
			End Get
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Global.System.ComponentModel.BrowsableAttribute(True), Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Visible)> _
		Public Overrides Property SchemaSerializationMode() As Global.System.Data.SchemaSerializationMode
			Get
				Return Me._schemaSerializationMode
			End Get
			Set(ByVal value As System.Data.SchemaSerializationMode)
				Me._schemaSerializationMode = value
			End Set
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
		Public Shadows ReadOnly Property Tables() As Global.System.Data.DataTableCollection
			Get
				Return MyBase.Tables
			End Get
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
		Public Shadows ReadOnly Property Relations() As Global.System.Data.DataRelationCollection
			Get
				Return MyBase.Relations
			End Get
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Protected Overrides Sub InitializeDerivedDataSet()
			Me.BeginInit()
			Me.InitClass()
			Me.EndInit()
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Public Overrides Function Clone() As Global.System.Data.DataSet
			Dim cln As NwindDataSet = (CType(MyBase.Clone(), NwindDataSet))
			cln.InitVars()
			cln.SchemaSerializationMode = Me.SchemaSerializationMode
			Return cln
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Protected Overrides Function ShouldSerializeTables() As Boolean
			Return False
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Protected Overrides Function ShouldSerializeRelations() As Boolean
			Return False
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Protected Overrides Sub ReadXmlSerializable(ByVal reader As Global.System.Xml.XmlReader)
			If (Me.DetermineSchemaSerializationMode(reader) = Global.System.Data.SchemaSerializationMode.IncludeSchema) Then
				Me.Reset()
				Dim ds As New Global.System.Data.DataSet()
				ds.ReadXml(reader)
				If (ds.Tables("CategoryProducts") IsNot Nothing) Then
					MyBase.Tables.Add(New CategoryProductsDataTable(ds.Tables("CategoryProducts")))
				End If
				If (ds.Tables("SalesPerson") IsNot Nothing) Then
					MyBase.Tables.Add(New SalesPersonDataTable(ds.Tables("SalesPerson")))
				End If
				If (ds.Tables("CustomerReports") IsNot Nothing) Then
					MyBase.Tables.Add(New CustomerReportsDataTable(ds.Tables("CustomerReports")))
				End If
				If (ds.Tables("Invoices") IsNot Nothing) Then
					MyBase.Tables.Add(New InvoicesDataTable(ds.Tables("Invoices")))
				End If
				If (ds.Tables("OrderDetails") IsNot Nothing) Then
					MyBase.Tables.Add(New OrderDetailsDataTable(ds.Tables("OrderDetails")))
				End If
				If (ds.Tables("OrderReports") IsNot Nothing) Then
					MyBase.Tables.Add(New OrderReportsDataTable(ds.Tables("OrderReports")))
				End If
				If (ds.Tables("ProductReports") IsNot Nothing) Then
					MyBase.Tables.Add(New ProductReportsDataTable(ds.Tables("ProductReports")))
				End If
				Me.DataSetName = ds.DataSetName
				Me.Prefix = ds.Prefix
				Me.Namespace = ds.Namespace
				Me.Locale = ds.Locale
				Me.CaseSensitive = ds.CaseSensitive
				Me.EnforceConstraints = ds.EnforceConstraints
				Me.Merge(ds, False, Global.System.Data.MissingSchemaAction.Add)
				Me.InitVars()
			Else
				Me.ReadXml(reader)
				Me.InitVars()
			End If
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Protected Overrides Function GetSchemaSerializable() As Global.System.Xml.Schema.XmlSchema
			Dim stream As New Global.System.IO.MemoryStream()
			Me.WriteXmlSchema(New Global.System.Xml.XmlTextWriter(stream, Nothing))
			stream.Position = 0
			Return Global.System.Xml.Schema.XmlSchema.Read(New Global.System.Xml.XmlTextReader(stream), Nothing)
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Friend Sub InitVars()
			Me.InitVars(True)
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Friend Sub InitVars(ByVal initTable As Boolean)
			Me.tableCategoryProducts = (CType(MyBase.Tables("CategoryProducts"), CategoryProductsDataTable))
			If (initTable = True) Then
				If (Me.tableCategoryProducts IsNot Nothing) Then
					Me.tableCategoryProducts.InitVars()
				End If
			End If
			Me.tableSalesPerson = (CType(MyBase.Tables("SalesPerson"), SalesPersonDataTable))
			If (initTable = True) Then
				If (Me.tableSalesPerson IsNot Nothing) Then
					Me.tableSalesPerson.InitVars()
				End If
			End If
			Me.tableCustomerReports = (CType(MyBase.Tables("CustomerReports"), CustomerReportsDataTable))
			If (initTable = True) Then
				If (Me.tableCustomerReports IsNot Nothing) Then
					Me.tableCustomerReports.InitVars()
				End If
			End If
			Me.tableInvoices = (CType(MyBase.Tables("Invoices"), InvoicesDataTable))
			If (initTable = True) Then
				If (Me.tableInvoices IsNot Nothing) Then
					Me.tableInvoices.InitVars()
				End If
			End If
			Me.tableOrderDetails = (CType(MyBase.Tables("OrderDetails"), OrderDetailsDataTable))
			If (initTable = True) Then
				If (Me.tableOrderDetails IsNot Nothing) Then
					Me.tableOrderDetails.InitVars()
				End If
			End If
			Me.tableOrderReports = (CType(MyBase.Tables("OrderReports"), OrderReportsDataTable))
			If (initTable = True) Then
				If (Me.tableOrderReports IsNot Nothing) Then
					Me.tableOrderReports.InitVars()
				End If
			End If
			Me.tableProductReports = (CType(MyBase.Tables("ProductReports"), ProductReportsDataTable))
			If (initTable = True) Then
				If (Me.tableProductReports IsNot Nothing) Then
					Me.tableProductReports.InitVars()
				End If
			End If
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Private Sub InitClass()
			Me.DataSetName = "DataSet1"
			Me.Prefix = ""
			Me.Namespace = "http://tempuri.org/DataSet1.xsd"
			Me.EnforceConstraints = True
			Me.SchemaSerializationMode = Global.System.Data.SchemaSerializationMode.IncludeSchema
			Me.tableCategoryProducts = New CategoryProductsDataTable()
			MyBase.Tables.Add(Me.tableCategoryProducts)
			Me.tableSalesPerson = New SalesPersonDataTable()
			MyBase.Tables.Add(Me.tableSalesPerson)
			Me.tableCustomerReports = New CustomerReportsDataTable()
			MyBase.Tables.Add(Me.tableCustomerReports)
			Me.tableInvoices = New InvoicesDataTable()
			MyBase.Tables.Add(Me.tableInvoices)
			Me.tableOrderDetails = New OrderDetailsDataTable()
			MyBase.Tables.Add(Me.tableOrderDetails)
			Me.tableOrderReports = New OrderReportsDataTable()
			MyBase.Tables.Add(Me.tableOrderReports)
			Me.tableProductReports = New ProductReportsDataTable()
			MyBase.Tables.Add(Me.tableProductReports)
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Private Function ShouldSerializeCategoryProducts() As Boolean
			Return False
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Private Function ShouldSerializeSalesPerson() As Boolean
			Return False
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Private Function ShouldSerializeCustomerReports() As Boolean
			Return False
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Private Function ShouldSerializeInvoices() As Boolean
			Return False
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Private Function ShouldSerializeOrderDetails() As Boolean
			Return False
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Private Function ShouldSerializeOrderReports() As Boolean
			Return False
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Private Function ShouldSerializeProductReports() As Boolean
			Return False
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Private Sub SchemaChanged(ByVal sender As Object, ByVal e As Global.System.ComponentModel.CollectionChangeEventArgs)
			If (e.Action = Global.System.ComponentModel.CollectionChangeAction.Remove) Then
				Me.InitVars()
			End If
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Public Shared Function GetTypedDataSetSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
			Dim ds As New NwindDataSet()
			Dim type As New Global.System.Xml.Schema.XmlSchemaComplexType()
			Dim sequence As New Global.System.Xml.Schema.XmlSchemaSequence()
			Dim any As New Global.System.Xml.Schema.XmlSchemaAny()
			any.Namespace = ds.Namespace
			sequence.Items.Add(any)
			type.Particle = sequence
			Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable()
			If xs.Contains(dsSchema.TargetNamespace) Then
				Dim s1 As New Global.System.IO.MemoryStream()
				Dim s2 As New Global.System.IO.MemoryStream()
				Try
					Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
					dsSchema.Write(s1)
					Dim schemas As System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
					Do While schemas.MoveNext()
						schema = (CType(schemas.Current, Global.System.Xml.Schema.XmlSchema))
						s2.SetLength(0)
						schema.Write(s2)
						If (s1.Length = s2.Length) Then
							s1.Position = 0
							s2.Position = 0
							Do While ((s1.Position <> s1.Length) AndAlso (s1.ReadByte() = s2.ReadByte()))

							Loop
							If (s1.Position = s1.Length) Then
								Return type
							End If
						End If
					Loop
				Finally
					If (s1 IsNot Nothing) Then
						s1.Close()
					End If
					If (s2 IsNot Nothing) Then
						s2.Close()
					End If
				End Try
			End If
			xs.Add(dsSchema)
			Return type
		End Function

		<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Public Delegate Sub CategoryProductsRowChangeEventHandler(ByVal sender As Object, ByVal e As CategoryProductsRowChangeEvent)

		<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Public Delegate Sub SalesPersonRowChangeEventHandler(ByVal sender As Object, ByVal e As SalesPersonRowChangeEvent)

		<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Public Delegate Sub CustomerReportsRowChangeEventHandler(ByVal sender As Object, ByVal e As CustomerReportsRowChangeEvent)

		<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Public Delegate Sub InvoicesRowChangeEventHandler(ByVal sender As Object, ByVal e As InvoicesRowChangeEvent)

		<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Public Delegate Sub OrderDetailsRowChangeEventHandler(ByVal sender As Object, ByVal e As OrderDetailsRowChangeEvent)

		<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Public Delegate Sub OrderReportsRowChangeEventHandler(ByVal sender As Object, ByVal e As OrderReportsRowChangeEvent)

		<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Public Delegate Sub ProductReportsRowChangeEventHandler(ByVal sender As Object, ByVal e As ProductReportsRowChangeEvent)

		''' <summary>
		'''Represents the strongly named DataTable class.
		'''</summary>
		<Global.System.Serializable(), Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")> _
		Partial Public Class CategoryProductsDataTable
			Inherits System.Data.TypedTableBase(Of CategoryProductsRow)

			Private columnProductID As Global.System.Data.DataColumn

			Private columnSupplierID As Global.System.Data.DataColumn

			Private columnProductName As Global.System.Data.DataColumn

			Private columnCategoryName As Global.System.Data.DataColumn

			Private columnPicture As Global.System.Data.DataColumn

			Private columnDescription As Global.System.Data.DataColumn

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub New()
				Me.TableName = "CategoryProducts"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Friend Sub New(ByVal table As Global.System.Data.DataTable)
				Me.TableName = table.TableName
				If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
					Me.CaseSensitive = table.CaseSensitive
				End If
				If (table.Locale.ToString() <> table.DataSet.Locale.ToString()) Then
					Me.Locale = table.Locale
				End If
				If (table.Namespace <> table.DataSet.Namespace) Then
					Me.Namespace = table.Namespace
				End If
				Me.Prefix = table.Prefix
				Me.MinimumCapacity = table.MinimumCapacity
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
				MyBase.New(info, context)
				Me.InitVars()
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property ProductIDColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnProductID
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property SupplierIDColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnSupplierID
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property ProductNameColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnProductName
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property CategoryNameColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnCategoryName
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property PictureColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnPicture
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property DescriptionColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnDescription
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Global.System.ComponentModel.Browsable(False)> _
			Public ReadOnly Property Count() As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Default Public ReadOnly Property Item(ByVal index As Integer) As CategoryProductsRow
				Get
					Return (CType(Me.Rows(index), CategoryProductsRow))
				End Get
			End Property

			<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Event CategoryProductsRowChanging As CategoryProductsRowChangeEventHandler

			<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Event CategoryProductsRowChanged As CategoryProductsRowChangeEventHandler

			<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Event CategoryProductsRowDeleting As CategoryProductsRowChangeEventHandler

			<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Event CategoryProductsRowDeleted As CategoryProductsRowChangeEventHandler

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub AddCategoryProductsRow(ByVal row As CategoryProductsRow)
				Me.Rows.Add(row)
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function AddCategoryProductsRow(ByVal SupplierID As Integer, ByVal ProductName As String, ByVal CategoryName As String, ByVal Picture() As Byte, ByVal Description As String) As CategoryProductsRow
				Dim rowCategoryProductsRow As CategoryProductsRow = (CType(Me.NewRow(), CategoryProductsRow))
				Dim columnValuesArray() As Object = { Nothing, SupplierID, ProductName, CategoryName, Picture, Description}
				rowCategoryProductsRow.ItemArray = columnValuesArray
				Me.Rows.Add(rowCategoryProductsRow)
				Return rowCategoryProductsRow
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Overrides Function Clone() As Global.System.Data.DataTable
				Dim cln As CategoryProductsDataTable = (CType(MyBase.Clone(), CategoryProductsDataTable))
				cln.InitVars()
				Return cln
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
				Return New CategoryProductsDataTable()
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Friend Sub InitVars()
				Me.columnProductID = MyBase.Columns("ProductID")
				Me.columnSupplierID = MyBase.Columns("SupplierID")
				Me.columnProductName = MyBase.Columns("ProductName")
				Me.columnCategoryName = MyBase.Columns("CategoryName")
				Me.columnPicture = MyBase.Columns("Picture")
				Me.columnDescription = MyBase.Columns("Description")
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Private Sub InitClass()
				Me.columnProductID = New Global.System.Data.DataColumn("ProductID", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnProductID)
				Me.columnSupplierID = New Global.System.Data.DataColumn("SupplierID", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnSupplierID)
				Me.columnProductName = New Global.System.Data.DataColumn("ProductName", GetType(String), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnProductName)
				Me.columnCategoryName = New Global.System.Data.DataColumn("CategoryName", GetType(String), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnCategoryName)
				Me.columnPicture = New Global.System.Data.DataColumn("Picture", GetType(Byte()), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnPicture)
				Me.columnDescription = New Global.System.Data.DataColumn("Description", GetType(String), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnDescription)
				Me.columnProductID.AutoIncrement = True
				Me.columnProductID.AutoIncrementSeed = -1
				Me.columnProductID.AutoIncrementStep = -1
				Me.columnProductName.MaxLength = 40
				Me.columnCategoryName.MaxLength = 15
				Me.columnDescription.MaxLength = 536870910
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function NewCategoryProductsRow() As CategoryProductsRow
				Return (CType(Me.NewRow(), CategoryProductsRow))
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
				Return New CategoryProductsRow(builder)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Function GetRowType() As Global.System.Type
				Return GetType(CategoryProductsRow)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				If (Me.CategoryProductsRowChangedEvent IsNot Nothing) Then
					RaiseEvent CategoryProductsRowChanged(Me, New CategoryProductsRowChangeEvent((CType(e.Row, CategoryProductsRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				If (Me.CategoryProductsRowChangingEvent IsNot Nothing) Then
					RaiseEvent CategoryProductsRowChanging(Me, New CategoryProductsRowChangeEvent((CType(e.Row, CategoryProductsRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				If (Me.CategoryProductsRowDeletedEvent IsNot Nothing) Then
					RaiseEvent CategoryProductsRowDeleted(Me, New CategoryProductsRowChangeEvent((CType(e.Row, CategoryProductsRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				If (Me.CategoryProductsRowDeletingEvent IsNot Nothing) Then
					RaiseEvent CategoryProductsRowDeleting(Me, New CategoryProductsRowChangeEvent((CType(e.Row, CategoryProductsRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub RemoveCategoryProductsRow(ByVal row As CategoryProductsRow)
				Me.Rows.Remove(row)
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
				Dim type As New Global.System.Xml.Schema.XmlSchemaComplexType()
				Dim sequence As New Global.System.Xml.Schema.XmlSchemaSequence()
				Dim ds As New NwindDataSet()
				Dim any1 As New Global.System.Xml.Schema.XmlSchemaAny()
				any1.Namespace = "http://www.w3.org/2001/XMLSchema"
				any1.MinOccurs = New Decimal(0)
				any1.MaxOccurs = Decimal.MaxValue
				any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any1)
				Dim any2 As New Global.System.Xml.Schema.XmlSchemaAny()
				any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
				any2.MinOccurs = New Decimal(1)
				any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any2)
				Dim attribute1 As New Global.System.Xml.Schema.XmlSchemaAttribute()
				attribute1.Name = "namespace"
				attribute1.FixedValue = ds.Namespace
				type.Attributes.Add(attribute1)
				Dim attribute2 As New Global.System.Xml.Schema.XmlSchemaAttribute()
				attribute2.Name = "tableTypeName"
				attribute2.FixedValue = "CategoryProductsDataTable"
				type.Attributes.Add(attribute2)
				type.Particle = sequence
				Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable()
				If xs.Contains(dsSchema.TargetNamespace) Then
					Dim s1 As New Global.System.IO.MemoryStream()
					Dim s2 As New Global.System.IO.MemoryStream()
					Try
						Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
						dsSchema.Write(s1)
						Dim schemas As System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
						Do While schemas.MoveNext()
							schema = (CType(schemas.Current, Global.System.Xml.Schema.XmlSchema))
							s2.SetLength(0)
							schema.Write(s2)
							If (s1.Length = s2.Length) Then
								s1.Position = 0
								s2.Position = 0
								Do While ((s1.Position <> s1.Length) AndAlso (s1.ReadByte() = s2.ReadByte()))

								Loop
								If (s1.Position = s1.Length) Then
									Return type
								End If
							End If
						Loop
					Finally
						If (s1 IsNot Nothing) Then
							s1.Close()
						End If
						If (s2 IsNot Nothing) Then
							s2.Close()
						End If
					End Try
				End If
				xs.Add(dsSchema)
				Return type
			End Function
		End Class

		''' <summary>
		'''Represents the strongly named DataTable class.
		'''</summary>
		<Global.System.Serializable(), Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")> _
		Partial Public Class SalesPersonDataTable
			Inherits System.Data.TypedTableBase(Of SalesPersonRow)

			Private columnOrderID As Global.System.Data.DataColumn

			Private columnCountry As Global.System.Data.DataColumn

			Private columnFirstName As Global.System.Data.DataColumn

			Private columnLastName As Global.System.Data.DataColumn

			Private columnProductName As Global.System.Data.DataColumn

			Private columnCategoryName As Global.System.Data.DataColumn

			Private columnOrderDate As Global.System.Data.DataColumn

			Private columnUnitPrice As Global.System.Data.DataColumn

			Private columnQuantity As Global.System.Data.DataColumn

			Private columnDiscount As Global.System.Data.DataColumn

			Private columnExtended_Price As Global.System.Data.DataColumn

			Private columnSales_Person As Global.System.Data.DataColumn

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub New()
				Me.TableName = "SalesPerson"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Friend Sub New(ByVal table As Global.System.Data.DataTable)
				Me.TableName = table.TableName
				If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
					Me.CaseSensitive = table.CaseSensitive
				End If
				If (table.Locale.ToString() <> table.DataSet.Locale.ToString()) Then
					Me.Locale = table.Locale
				End If
				If (table.Namespace <> table.DataSet.Namespace) Then
					Me.Namespace = table.Namespace
				End If
				Me.Prefix = table.Prefix
				Me.MinimumCapacity = table.MinimumCapacity
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
				MyBase.New(info, context)
				Me.InitVars()
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property OrderIDColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnOrderID
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property CountryColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnCountry
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property FirstNameColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnFirstName
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property LastNameColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnLastName
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property ProductNameColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnProductName
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property CategoryNameColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnCategoryName
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property OrderDateColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnOrderDate
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property UnitPriceColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnUnitPrice
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property QuantityColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnQuantity
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property DiscountColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnDiscount
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property Extended_PriceColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnExtended_Price
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property Sales_PersonColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnSales_Person
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Global.System.ComponentModel.Browsable(False)> _
			Public ReadOnly Property Count() As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Default Public ReadOnly Property Item(ByVal index As Integer) As SalesPersonRow
				Get
					Return (CType(Me.Rows(index), SalesPersonRow))
				End Get
			End Property

			<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Event SalesPersonRowChanging As SalesPersonRowChangeEventHandler

			<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Event SalesPersonRowChanged As SalesPersonRowChangeEventHandler

			<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Event SalesPersonRowDeleting As SalesPersonRowChangeEventHandler

			<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Event SalesPersonRowDeleted As SalesPersonRowChangeEventHandler

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub AddSalesPersonRow(ByVal row As SalesPersonRow)
				Me.Rows.Add(row)
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function AddSalesPersonRow(ByVal Country As String, ByVal FirstName As String, ByVal LastName As String, ByVal ProductName As String, ByVal CategoryName As String, ByVal OrderDate As System.DateTime, ByVal UnitPrice As Decimal, ByVal Quantity As Short, ByVal Discount As Single, ByVal Extended_Price As Decimal, ByVal Sales_Person As String) As SalesPersonRow
				Dim rowSalesPersonRow As SalesPersonRow = (CType(Me.NewRow(), SalesPersonRow))
				Dim columnValuesArray() As Object = { Nothing, Country, FirstName, LastName, ProductName, CategoryName, OrderDate, UnitPrice, Quantity, Discount, Extended_Price, Sales_Person}
				rowSalesPersonRow.ItemArray = columnValuesArray
				Me.Rows.Add(rowSalesPersonRow)
				Return rowSalesPersonRow
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Overrides Function Clone() As Global.System.Data.DataTable
				Dim cln As SalesPersonDataTable = (CType(MyBase.Clone(), SalesPersonDataTable))
				cln.InitVars()
				Return cln
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
				Return New SalesPersonDataTable()
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Friend Sub InitVars()
				Me.columnOrderID = MyBase.Columns("OrderID")
				Me.columnCountry = MyBase.Columns("Country")
				Me.columnFirstName = MyBase.Columns("FirstName")
				Me.columnLastName = MyBase.Columns("LastName")
				Me.columnProductName = MyBase.Columns("ProductName")
				Me.columnCategoryName = MyBase.Columns("CategoryName")
				Me.columnOrderDate = MyBase.Columns("OrderDate")
				Me.columnUnitPrice = MyBase.Columns("UnitPrice")
				Me.columnQuantity = MyBase.Columns("Quantity")
				Me.columnDiscount = MyBase.Columns("Discount")
				Me.columnExtended_Price = MyBase.Columns("Extended Price")
				Me.columnSales_Person = MyBase.Columns("Sales Person")
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Private Sub InitClass()
				Me.columnOrderID = New Global.System.Data.DataColumn("OrderID", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnOrderID)
				Me.columnCountry = New Global.System.Data.DataColumn("Country", GetType(String), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnCountry)
				Me.columnFirstName = New Global.System.Data.DataColumn("FirstName", GetType(String), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnFirstName)
				Me.columnLastName = New Global.System.Data.DataColumn("LastName", GetType(String), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnLastName)
				Me.columnProductName = New Global.System.Data.DataColumn("ProductName", GetType(String), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnProductName)
				Me.columnCategoryName = New Global.System.Data.DataColumn("CategoryName", GetType(String), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnCategoryName)
				Me.columnOrderDate = New Global.System.Data.DataColumn("OrderDate", GetType(Global.System.DateTime), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnOrderDate)
				Me.columnUnitPrice = New Global.System.Data.DataColumn("UnitPrice", GetType(Decimal), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnUnitPrice)
				Me.columnQuantity = New Global.System.Data.DataColumn("Quantity", GetType(Short), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnQuantity)
				Me.columnDiscount = New Global.System.Data.DataColumn("Discount", GetType(Single), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnDiscount)
				Me.columnExtended_Price = New Global.System.Data.DataColumn("Extended Price", GetType(Decimal), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnExtended_Price)
				Me.columnSales_Person = New Global.System.Data.DataColumn("Sales Person", GetType(String), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnSales_Person)
				Me.columnOrderID.AutoIncrement = True
				Me.columnOrderID.AutoIncrementSeed = -1
				Me.columnOrderID.AutoIncrementStep = -1
				Me.columnCountry.MaxLength = 15
				Me.columnFirstName.MaxLength = 10
				Me.columnLastName.MaxLength = 20
				Me.columnProductName.MaxLength = 40
				Me.columnCategoryName.MaxLength = 15
				Me.columnExtended_Price.ReadOnly = True
				Me.columnSales_Person.ReadOnly = True
				Me.columnSales_Person.MaxLength = 255
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function NewSalesPersonRow() As SalesPersonRow
				Return (CType(Me.NewRow(), SalesPersonRow))
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
				Return New SalesPersonRow(builder)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Function GetRowType() As Global.System.Type
				Return GetType(SalesPersonRow)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				If (Me.SalesPersonRowChangedEvent IsNot Nothing) Then
					RaiseEvent SalesPersonRowChanged(Me, New SalesPersonRowChangeEvent((CType(e.Row, SalesPersonRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				If (Me.SalesPersonRowChangingEvent IsNot Nothing) Then
					RaiseEvent SalesPersonRowChanging(Me, New SalesPersonRowChangeEvent((CType(e.Row, SalesPersonRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				If (Me.SalesPersonRowDeletedEvent IsNot Nothing) Then
					RaiseEvent SalesPersonRowDeleted(Me, New SalesPersonRowChangeEvent((CType(e.Row, SalesPersonRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				If (Me.SalesPersonRowDeletingEvent IsNot Nothing) Then
					RaiseEvent SalesPersonRowDeleting(Me, New SalesPersonRowChangeEvent((CType(e.Row, SalesPersonRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub RemoveSalesPersonRow(ByVal row As SalesPersonRow)
				Me.Rows.Remove(row)
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
				Dim type As New Global.System.Xml.Schema.XmlSchemaComplexType()
				Dim sequence As New Global.System.Xml.Schema.XmlSchemaSequence()
				Dim ds As New NwindDataSet()
				Dim any1 As New Global.System.Xml.Schema.XmlSchemaAny()
				any1.Namespace = "http://www.w3.org/2001/XMLSchema"
				any1.MinOccurs = New Decimal(0)
				any1.MaxOccurs = Decimal.MaxValue
				any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any1)
				Dim any2 As New Global.System.Xml.Schema.XmlSchemaAny()
				any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
				any2.MinOccurs = New Decimal(1)
				any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any2)
				Dim attribute1 As New Global.System.Xml.Schema.XmlSchemaAttribute()
				attribute1.Name = "namespace"
				attribute1.FixedValue = ds.Namespace
				type.Attributes.Add(attribute1)
				Dim attribute2 As New Global.System.Xml.Schema.XmlSchemaAttribute()
				attribute2.Name = "tableTypeName"
				attribute2.FixedValue = "SalesPersonDataTable"
				type.Attributes.Add(attribute2)
				type.Particle = sequence
				Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable()
				If xs.Contains(dsSchema.TargetNamespace) Then
					Dim s1 As New Global.System.IO.MemoryStream()
					Dim s2 As New Global.System.IO.MemoryStream()
					Try
						Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
						dsSchema.Write(s1)
						Dim schemas As System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
						Do While schemas.MoveNext()
							schema = (CType(schemas.Current, Global.System.Xml.Schema.XmlSchema))
							s2.SetLength(0)
							schema.Write(s2)
							If (s1.Length = s2.Length) Then
								s1.Position = 0
								s2.Position = 0
								Do While ((s1.Position <> s1.Length) AndAlso (s1.ReadByte() = s2.ReadByte()))

								Loop
								If (s1.Position = s1.Length) Then
									Return type
								End If
							End If
						Loop
					Finally
						If (s1 IsNot Nothing) Then
							s1.Close()
						End If
						If (s2 IsNot Nothing) Then
							s2.Close()
						End If
					End Try
				End If
				xs.Add(dsSchema)
				Return type
			End Function
		End Class

		''' <summary>
		'''Represents the strongly named DataTable class.
		'''</summary>
		<Global.System.Serializable(), Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")> _
		Partial Public Class CustomerReportsDataTable
			Inherits System.Data.TypedTableBase(Of CustomerReportsRow)

			Private columnProductName As Global.System.Data.DataColumn

			Private columnCompanyName As Global.System.Data.DataColumn

			Private columnOrderDate As Global.System.Data.DataColumn

			Private columnProductAmount As Global.System.Data.DataColumn

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub New()
				Me.TableName = "CustomerReports"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Friend Sub New(ByVal table As Global.System.Data.DataTable)
				Me.TableName = table.TableName
				If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
					Me.CaseSensitive = table.CaseSensitive
				End If
				If (table.Locale.ToString() <> table.DataSet.Locale.ToString()) Then
					Me.Locale = table.Locale
				End If
				If (table.Namespace <> table.DataSet.Namespace) Then
					Me.Namespace = table.Namespace
				End If
				Me.Prefix = table.Prefix
				Me.MinimumCapacity = table.MinimumCapacity
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
				MyBase.New(info, context)
				Me.InitVars()
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property ProductNameColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnProductName
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property CompanyNameColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnCompanyName
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property OrderDateColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnOrderDate
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property ProductAmountColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnProductAmount
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Global.System.ComponentModel.Browsable(False)> _
			Public ReadOnly Property Count() As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Default Public ReadOnly Property Item(ByVal index As Integer) As CustomerReportsRow
				Get
					Return (CType(Me.Rows(index), CustomerReportsRow))
				End Get
			End Property

			<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Event CustomerReportsRowChanging As CustomerReportsRowChangeEventHandler

			<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Event CustomerReportsRowChanged As CustomerReportsRowChangeEventHandler

			<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Event CustomerReportsRowDeleting As CustomerReportsRowChangeEventHandler

			<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Event CustomerReportsRowDeleted As CustomerReportsRowChangeEventHandler

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub AddCustomerReportsRow(ByVal row As CustomerReportsRow)
				Me.Rows.Add(row)
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function AddCustomerReportsRow(ByVal ProductName As String, ByVal CompanyName As String, ByVal OrderDate As System.DateTime, ByVal ProductAmount As Decimal) As CustomerReportsRow
				Dim rowCustomerReportsRow As CustomerReportsRow = (CType(Me.NewRow(), CustomerReportsRow))
				Dim columnValuesArray() As Object = { ProductName, CompanyName, OrderDate, ProductAmount}
				rowCustomerReportsRow.ItemArray = columnValuesArray
				Me.Rows.Add(rowCustomerReportsRow)
				Return rowCustomerReportsRow
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Overrides Function Clone() As Global.System.Data.DataTable
				Dim cln As CustomerReportsDataTable = (CType(MyBase.Clone(), CustomerReportsDataTable))
				cln.InitVars()
				Return cln
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
				Return New CustomerReportsDataTable()
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Friend Sub InitVars()
				Me.columnProductName = MyBase.Columns("ProductName")
				Me.columnCompanyName = MyBase.Columns("CompanyName")
				Me.columnOrderDate = MyBase.Columns("OrderDate")
				Me.columnProductAmount = MyBase.Columns("ProductAmount")
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Private Sub InitClass()
				Me.columnProductName = New Global.System.Data.DataColumn("ProductName", GetType(String), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnProductName)
				Me.columnCompanyName = New Global.System.Data.DataColumn("CompanyName", GetType(String), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnCompanyName)
				Me.columnOrderDate = New Global.System.Data.DataColumn("OrderDate", GetType(Global.System.DateTime), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnOrderDate)
				Me.columnProductAmount = New Global.System.Data.DataColumn("ProductAmount", GetType(Decimal), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnProductAmount)
				Me.columnProductName.MaxLength = 40
				Me.columnCompanyName.MaxLength = 40
				Me.columnProductAmount.ReadOnly = True
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function NewCustomerReportsRow() As CustomerReportsRow
				Return (CType(Me.NewRow(), CustomerReportsRow))
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
				Return New CustomerReportsRow(builder)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Function GetRowType() As Global.System.Type
				Return GetType(CustomerReportsRow)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				If (Me.CustomerReportsRowChangedEvent IsNot Nothing) Then
					RaiseEvent CustomerReportsRowChanged(Me, New CustomerReportsRowChangeEvent((CType(e.Row, CustomerReportsRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				If (Me.CustomerReportsRowChangingEvent IsNot Nothing) Then
					RaiseEvent CustomerReportsRowChanging(Me, New CustomerReportsRowChangeEvent((CType(e.Row, CustomerReportsRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				If (Me.CustomerReportsRowDeletedEvent IsNot Nothing) Then
					RaiseEvent CustomerReportsRowDeleted(Me, New CustomerReportsRowChangeEvent((CType(e.Row, CustomerReportsRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				If (Me.CustomerReportsRowDeletingEvent IsNot Nothing) Then
					RaiseEvent CustomerReportsRowDeleting(Me, New CustomerReportsRowChangeEvent((CType(e.Row, CustomerReportsRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub RemoveCustomerReportsRow(ByVal row As CustomerReportsRow)
				Me.Rows.Remove(row)
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
				Dim type As New Global.System.Xml.Schema.XmlSchemaComplexType()
				Dim sequence As New Global.System.Xml.Schema.XmlSchemaSequence()
				Dim ds As New NwindDataSet()
				Dim any1 As New Global.System.Xml.Schema.XmlSchemaAny()
				any1.Namespace = "http://www.w3.org/2001/XMLSchema"
				any1.MinOccurs = New Decimal(0)
				any1.MaxOccurs = Decimal.MaxValue
				any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any1)
				Dim any2 As New Global.System.Xml.Schema.XmlSchemaAny()
				any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
				any2.MinOccurs = New Decimal(1)
				any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any2)
				Dim attribute1 As New Global.System.Xml.Schema.XmlSchemaAttribute()
				attribute1.Name = "namespace"
				attribute1.FixedValue = ds.Namespace
				type.Attributes.Add(attribute1)
				Dim attribute2 As New Global.System.Xml.Schema.XmlSchemaAttribute()
				attribute2.Name = "tableTypeName"
				attribute2.FixedValue = "CustomerReportsDataTable"
				type.Attributes.Add(attribute2)
				type.Particle = sequence
				Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable()
				If xs.Contains(dsSchema.TargetNamespace) Then
					Dim s1 As New Global.System.IO.MemoryStream()
					Dim s2 As New Global.System.IO.MemoryStream()
					Try
						Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
						dsSchema.Write(s1)
						Dim schemas As System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
						Do While schemas.MoveNext()
							schema = (CType(schemas.Current, Global.System.Xml.Schema.XmlSchema))
							s2.SetLength(0)
							schema.Write(s2)
							If (s1.Length = s2.Length) Then
								s1.Position = 0
								s2.Position = 0
								Do While ((s1.Position <> s1.Length) AndAlso (s1.ReadByte() = s2.ReadByte()))

								Loop
								If (s1.Position = s1.Length) Then
									Return type
								End If
							End If
						Loop
					Finally
						If (s1 IsNot Nothing) Then
							s1.Close()
						End If
						If (s2 IsNot Nothing) Then
							s2.Close()
						End If
					End Try
				End If
				xs.Add(dsSchema)
				Return type
			End Function
		End Class

		''' <summary>
		'''Represents the strongly named DataTable class.
		'''</summary>
		<Global.System.Serializable(), Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")> _
		Partial Public Class InvoicesDataTable
			Inherits System.Data.TypedTableBase(Of InvoicesRow)

			Private columnShipName As Global.System.Data.DataColumn

			Private columnShipAddress As Global.System.Data.DataColumn

			Private columnShipCity As Global.System.Data.DataColumn

			Private columnShipRegion As Global.System.Data.DataColumn

			Private columnShipPostalCode As Global.System.Data.DataColumn

			Private columnShipCountry As Global.System.Data.DataColumn

			Private columnCustomerID As Global.System.Data.DataColumn

			Private columnCustomers_CompanyName As Global.System.Data.DataColumn

			Private columnAddress As Global.System.Data.DataColumn

			Private columnCity As Global.System.Data.DataColumn

			Private columnRegion As Global.System.Data.DataColumn

			Private columnPostalCode As Global.System.Data.DataColumn

			Private columnCountry As Global.System.Data.DataColumn

			Private columnSalesperson As Global.System.Data.DataColumn

			Private columnOrderID As Global.System.Data.DataColumn

			Private columnOrderDate As Global.System.Data.DataColumn

			Private columnRequiredDate As Global.System.Data.DataColumn

			Private columnShippedDate As Global.System.Data.DataColumn

			Private columnShippers_CompanyName As Global.System.Data.DataColumn

			Private columnProductID As Global.System.Data.DataColumn

			Private columnProductName As Global.System.Data.DataColumn

			Private columnUnitPrice As Global.System.Data.DataColumn

			Private columnQuantity As Global.System.Data.DataColumn

			Private columnDiscount As Global.System.Data.DataColumn

			Private columnExtendedPrice As Global.System.Data.DataColumn

			Private columnFreight As Global.System.Data.DataColumn

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub New()
				Me.TableName = "Invoices"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Friend Sub New(ByVal table As Global.System.Data.DataTable)
				Me.TableName = table.TableName
				If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
					Me.CaseSensitive = table.CaseSensitive
				End If
				If (table.Locale.ToString() <> table.DataSet.Locale.ToString()) Then
					Me.Locale = table.Locale
				End If
				If (table.Namespace <> table.DataSet.Namespace) Then
					Me.Namespace = table.Namespace
				End If
				Me.Prefix = table.Prefix
				Me.MinimumCapacity = table.MinimumCapacity
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
				MyBase.New(info, context)
				Me.InitVars()
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property ShipNameColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnShipName
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property ShipAddressColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnShipAddress
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property ShipCityColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnShipCity
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property ShipRegionColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnShipRegion
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property ShipPostalCodeColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnShipPostalCode
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property ShipCountryColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnShipCountry
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property CustomerIDColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnCustomerID
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property Customers_CompanyNameColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnCustomers_CompanyName
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property AddressColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnAddress
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property CityColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnCity
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property RegionColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnRegion
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property PostalCodeColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnPostalCode
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property CountryColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnCountry
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property SalespersonColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnSalesperson
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property OrderIDColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnOrderID
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property OrderDateColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnOrderDate
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property RequiredDateColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnRequiredDate
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property ShippedDateColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnShippedDate
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property Shippers_CompanyNameColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnShippers_CompanyName
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property ProductIDColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnProductID
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property ProductNameColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnProductName
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property UnitPriceColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnUnitPrice
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property QuantityColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnQuantity
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property DiscountColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnDiscount
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property ExtendedPriceColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnExtendedPrice
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property FreightColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnFreight
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Global.System.ComponentModel.Browsable(False)> _
			Public ReadOnly Property Count() As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Default Public ReadOnly Property Item(ByVal index As Integer) As InvoicesRow
				Get
					Return (CType(Me.Rows(index), InvoicesRow))
				End Get
			End Property

			<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Event InvoicesRowChanging As InvoicesRowChangeEventHandler

			<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Event InvoicesRowChanged As InvoicesRowChangeEventHandler

			<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Event InvoicesRowDeleting As InvoicesRowChangeEventHandler

			<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Event InvoicesRowDeleted As InvoicesRowChangeEventHandler

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub AddInvoicesRow(ByVal row As InvoicesRow)
				Me.Rows.Add(row)
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function AddInvoicesRow(ByVal ShipName As String, ByVal ShipAddress As String, ByVal ShipCity As String, ByVal ShipRegion As String, ByVal ShipPostalCode As String, ByVal ShipCountry As String, ByVal CustomerID As String, ByVal Customers_CompanyName As String, ByVal Address As String, ByVal City As String, ByVal Region As String, ByVal PostalCode As String, ByVal Country As String, ByVal Salesperson As String, ByVal OrderDate As System.DateTime, ByVal RequiredDate As System.DateTime, ByVal ShippedDate As System.DateTime, ByVal Shippers_CompanyName As String, ByVal ProductID As Integer, ByVal ProductName As String, ByVal UnitPrice As Decimal, ByVal Quantity As Short, ByVal Discount As Single, ByVal ExtendedPrice As Decimal, ByVal Freight As Decimal) As InvoicesRow
				Dim rowInvoicesRow As InvoicesRow = (CType(Me.NewRow(), InvoicesRow))
				Dim columnValuesArray() As Object = { ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry, CustomerID, Customers_CompanyName, Address, City, Region, PostalCode, Country, Salesperson, Nothing, OrderDate, RequiredDate, ShippedDate, Shippers_CompanyName, ProductID, ProductName, UnitPrice, Quantity, Discount, ExtendedPrice, Freight}
				rowInvoicesRow.ItemArray = columnValuesArray
				Me.Rows.Add(rowInvoicesRow)
				Return rowInvoicesRow
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Overrides Function Clone() As Global.System.Data.DataTable
				Dim cln As InvoicesDataTable = (CType(MyBase.Clone(), InvoicesDataTable))
				cln.InitVars()
				Return cln
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
				Return New InvoicesDataTable()
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Friend Sub InitVars()
				Me.columnShipName = MyBase.Columns("ShipName")
				Me.columnShipAddress = MyBase.Columns("ShipAddress")
				Me.columnShipCity = MyBase.Columns("ShipCity")
				Me.columnShipRegion = MyBase.Columns("ShipRegion")
				Me.columnShipPostalCode = MyBase.Columns("ShipPostalCode")
				Me.columnShipCountry = MyBase.Columns("ShipCountry")
				Me.columnCustomerID = MyBase.Columns("CustomerID")
				Me.columnCustomers_CompanyName = MyBase.Columns("Customers_CompanyName")
				Me.columnAddress = MyBase.Columns("Address")
				Me.columnCity = MyBase.Columns("City")
				Me.columnRegion = MyBase.Columns("Region")
				Me.columnPostalCode = MyBase.Columns("PostalCode")
				Me.columnCountry = MyBase.Columns("Country")
				Me.columnSalesperson = MyBase.Columns("Salesperson")
				Me.columnOrderID = MyBase.Columns("OrderID")
				Me.columnOrderDate = MyBase.Columns("OrderDate")
				Me.columnRequiredDate = MyBase.Columns("RequiredDate")
				Me.columnShippedDate = MyBase.Columns("ShippedDate")
				Me.columnShippers_CompanyName = MyBase.Columns("Shippers_CompanyName")
				Me.columnProductID = MyBase.Columns("ProductID")
				Me.columnProductName = MyBase.Columns("ProductName")
				Me.columnUnitPrice = MyBase.Columns("UnitPrice")
				Me.columnQuantity = MyBase.Columns("Quantity")
				Me.columnDiscount = MyBase.Columns("Discount")
				Me.columnExtendedPrice = MyBase.Columns("ExtendedPrice")
				Me.columnFreight = MyBase.Columns("Freight")
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Private Sub InitClass()
				Me.columnShipName = New Global.System.Data.DataColumn("ShipName", GetType(String), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnShipName)
				Me.columnShipAddress = New Global.System.Data.DataColumn("ShipAddress", GetType(String), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnShipAddress)
				Me.columnShipCity = New Global.System.Data.DataColumn("ShipCity", GetType(String), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnShipCity)
				Me.columnShipRegion = New Global.System.Data.DataColumn("ShipRegion", GetType(String), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnShipRegion)
				Me.columnShipPostalCode = New Global.System.Data.DataColumn("ShipPostalCode", GetType(String), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnShipPostalCode)
				Me.columnShipCountry = New Global.System.Data.DataColumn("ShipCountry", GetType(String), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnShipCountry)
				Me.columnCustomerID = New Global.System.Data.DataColumn("CustomerID", GetType(String), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnCustomerID)
				Me.columnCustomers_CompanyName = New Global.System.Data.DataColumn("Customers_CompanyName", GetType(String), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnCustomers_CompanyName)
				Me.columnAddress = New Global.System.Data.DataColumn("Address", GetType(String), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnAddress)
				Me.columnCity = New Global.System.Data.DataColumn("City", GetType(String), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnCity)
				Me.columnRegion = New Global.System.Data.DataColumn("Region", GetType(String), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnRegion)
				Me.columnPostalCode = New Global.System.Data.DataColumn("PostalCode", GetType(String), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnPostalCode)
				Me.columnCountry = New Global.System.Data.DataColumn("Country", GetType(String), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnCountry)
				Me.columnSalesperson = New Global.System.Data.DataColumn("Salesperson", GetType(String), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnSalesperson)
				Me.columnOrderID = New Global.System.Data.DataColumn("OrderID", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnOrderID)
				Me.columnOrderDate = New Global.System.Data.DataColumn("OrderDate", GetType(Global.System.DateTime), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnOrderDate)
				Me.columnRequiredDate = New Global.System.Data.DataColumn("RequiredDate", GetType(Global.System.DateTime), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnRequiredDate)
				Me.columnShippedDate = New Global.System.Data.DataColumn("ShippedDate", GetType(Global.System.DateTime), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnShippedDate)
				Me.columnShippers_CompanyName = New Global.System.Data.DataColumn("Shippers_CompanyName", GetType(String), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnShippers_CompanyName)
				Me.columnProductID = New Global.System.Data.DataColumn("ProductID", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnProductID)
				Me.columnProductName = New Global.System.Data.DataColumn("ProductName", GetType(String), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnProductName)
				Me.columnUnitPrice = New Global.System.Data.DataColumn("UnitPrice", GetType(Decimal), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnUnitPrice)
				Me.columnQuantity = New Global.System.Data.DataColumn("Quantity", GetType(Short), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnQuantity)
				Me.columnDiscount = New Global.System.Data.DataColumn("Discount", GetType(Single), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnDiscount)
				Me.columnExtendedPrice = New Global.System.Data.DataColumn("ExtendedPrice", GetType(Decimal), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnExtendedPrice)
				Me.columnFreight = New Global.System.Data.DataColumn("Freight", GetType(Decimal), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnFreight)
				Me.columnShipName.MaxLength = 40
				Me.columnShipAddress.MaxLength = 60
				Me.columnShipCity.MaxLength = 15
				Me.columnShipRegion.MaxLength = 15
				Me.columnShipPostalCode.MaxLength = 10
				Me.columnShipCountry.MaxLength = 15
				Me.columnCustomerID.MaxLength = 5
				Me.columnCustomers_CompanyName.MaxLength = 40
				Me.columnAddress.MaxLength = 60
				Me.columnCity.MaxLength = 15
				Me.columnRegion.MaxLength = 15
				Me.columnPostalCode.MaxLength = 10
				Me.columnCountry.MaxLength = 15
				Me.columnSalesperson.ReadOnly = True
				Me.columnSalesperson.MaxLength = 255
				Me.columnOrderID.AutoIncrement = True
				Me.columnOrderID.AutoIncrementSeed = -1
				Me.columnOrderID.AutoIncrementStep = -1
				Me.columnShippers_CompanyName.MaxLength = 40
				Me.columnProductName.MaxLength = 40
				Me.columnExtendedPrice.ReadOnly = True
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function NewInvoicesRow() As InvoicesRow
				Return (CType(Me.NewRow(), InvoicesRow))
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
				Return New InvoicesRow(builder)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Function GetRowType() As Global.System.Type
				Return GetType(InvoicesRow)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				If (Me.InvoicesRowChangedEvent IsNot Nothing) Then
					RaiseEvent InvoicesRowChanged(Me, New InvoicesRowChangeEvent((CType(e.Row, InvoicesRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				If (Me.InvoicesRowChangingEvent IsNot Nothing) Then
					RaiseEvent InvoicesRowChanging(Me, New InvoicesRowChangeEvent((CType(e.Row, InvoicesRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				If (Me.InvoicesRowDeletedEvent IsNot Nothing) Then
					RaiseEvent InvoicesRowDeleted(Me, New InvoicesRowChangeEvent((CType(e.Row, InvoicesRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				If (Me.InvoicesRowDeletingEvent IsNot Nothing) Then
					RaiseEvent InvoicesRowDeleting(Me, New InvoicesRowChangeEvent((CType(e.Row, InvoicesRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub RemoveInvoicesRow(ByVal row As InvoicesRow)
				Me.Rows.Remove(row)
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
				Dim type As New Global.System.Xml.Schema.XmlSchemaComplexType()
				Dim sequence As New Global.System.Xml.Schema.XmlSchemaSequence()
				Dim ds As New NwindDataSet()
				Dim any1 As New Global.System.Xml.Schema.XmlSchemaAny()
				any1.Namespace = "http://www.w3.org/2001/XMLSchema"
				any1.MinOccurs = New Decimal(0)
				any1.MaxOccurs = Decimal.MaxValue
				any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any1)
				Dim any2 As New Global.System.Xml.Schema.XmlSchemaAny()
				any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
				any2.MinOccurs = New Decimal(1)
				any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any2)
				Dim attribute1 As New Global.System.Xml.Schema.XmlSchemaAttribute()
				attribute1.Name = "namespace"
				attribute1.FixedValue = ds.Namespace
				type.Attributes.Add(attribute1)
				Dim attribute2 As New Global.System.Xml.Schema.XmlSchemaAttribute()
				attribute2.Name = "tableTypeName"
				attribute2.FixedValue = "InvoicesDataTable"
				type.Attributes.Add(attribute2)
				type.Particle = sequence
				Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable()
				If xs.Contains(dsSchema.TargetNamespace) Then
					Dim s1 As New Global.System.IO.MemoryStream()
					Dim s2 As New Global.System.IO.MemoryStream()
					Try
						Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
						dsSchema.Write(s1)
						Dim schemas As System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
						Do While schemas.MoveNext()
							schema = (CType(schemas.Current, Global.System.Xml.Schema.XmlSchema))
							s2.SetLength(0)
							schema.Write(s2)
							If (s1.Length = s2.Length) Then
								s1.Position = 0
								s2.Position = 0
								Do While ((s1.Position <> s1.Length) AndAlso (s1.ReadByte() = s2.ReadByte()))

								Loop
								If (s1.Position = s1.Length) Then
									Return type
								End If
							End If
						Loop
					Finally
						If (s1 IsNot Nothing) Then
							s1.Close()
						End If
						If (s2 IsNot Nothing) Then
							s2.Close()
						End If
					End Try
				End If
				xs.Add(dsSchema)
				Return type
			End Function
		End Class

		''' <summary>
		'''Represents the strongly named DataTable class.
		'''</summary>
		<Global.System.Serializable(), Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")> _
		Partial Public Class OrderDetailsDataTable
			Inherits System.Data.TypedTableBase(Of OrderDetailsRow)

			Private columnOrderID As Global.System.Data.DataColumn

			Private columnQuantity As Global.System.Data.DataColumn

			Private columnUnitPrice As Global.System.Data.DataColumn

			Private columnDiscount As Global.System.Data.DataColumn

			Private columnProductName As Global.System.Data.DataColumn

			Private columnSupplier As Global.System.Data.DataColumn

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub New()
				Me.TableName = "OrderDetails"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Friend Sub New(ByVal table As Global.System.Data.DataTable)
				Me.TableName = table.TableName
				If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
					Me.CaseSensitive = table.CaseSensitive
				End If
				If (table.Locale.ToString() <> table.DataSet.Locale.ToString()) Then
					Me.Locale = table.Locale
				End If
				If (table.Namespace <> table.DataSet.Namespace) Then
					Me.Namespace = table.Namespace
				End If
				Me.Prefix = table.Prefix
				Me.MinimumCapacity = table.MinimumCapacity
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
				MyBase.New(info, context)
				Me.InitVars()
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property OrderIDColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnOrderID
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property QuantityColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnQuantity
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property UnitPriceColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnUnitPrice
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property DiscountColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnDiscount
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property ProductNameColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnProductName
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property SupplierColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnSupplier
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Global.System.ComponentModel.Browsable(False)> _
			Public ReadOnly Property Count() As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Default Public ReadOnly Property Item(ByVal index As Integer) As OrderDetailsRow
				Get
					Return (CType(Me.Rows(index), OrderDetailsRow))
				End Get
			End Property

			<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Event OrderDetailsRowChanging As OrderDetailsRowChangeEventHandler

			<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Event OrderDetailsRowChanged As OrderDetailsRowChangeEventHandler

			<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Event OrderDetailsRowDeleting As OrderDetailsRowChangeEventHandler

			<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Event OrderDetailsRowDeleted As OrderDetailsRowChangeEventHandler

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub AddOrderDetailsRow(ByVal row As OrderDetailsRow)
				Me.Rows.Add(row)
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function AddOrderDetailsRow(ByVal OrderID As Integer, ByVal Quantity As Short, ByVal UnitPrice As Decimal, ByVal Discount As Single, ByVal ProductName As String, ByVal Supplier As String) As OrderDetailsRow
				Dim rowOrderDetailsRow As OrderDetailsRow = (CType(Me.NewRow(), OrderDetailsRow))
				Dim columnValuesArray() As Object = { OrderID, Quantity, UnitPrice, Discount, ProductName, Supplier}
				rowOrderDetailsRow.ItemArray = columnValuesArray
				Me.Rows.Add(rowOrderDetailsRow)
				Return rowOrderDetailsRow
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Overrides Function Clone() As Global.System.Data.DataTable
				Dim cln As OrderDetailsDataTable = (CType(MyBase.Clone(), OrderDetailsDataTable))
				cln.InitVars()
				Return cln
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
				Return New OrderDetailsDataTable()
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Friend Sub InitVars()
				Me.columnOrderID = MyBase.Columns("OrderID")
				Me.columnQuantity = MyBase.Columns("Quantity")
				Me.columnUnitPrice = MyBase.Columns("UnitPrice")
				Me.columnDiscount = MyBase.Columns("Discount")
				Me.columnProductName = MyBase.Columns("ProductName")
				Me.columnSupplier = MyBase.Columns("Supplier")
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Private Sub InitClass()
				Me.columnOrderID = New Global.System.Data.DataColumn("OrderID", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnOrderID)
				Me.columnQuantity = New Global.System.Data.DataColumn("Quantity", GetType(Short), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnQuantity)
				Me.columnUnitPrice = New Global.System.Data.DataColumn("UnitPrice", GetType(Decimal), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnUnitPrice)
				Me.columnDiscount = New Global.System.Data.DataColumn("Discount", GetType(Single), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnDiscount)
				Me.columnProductName = New Global.System.Data.DataColumn("ProductName", GetType(String), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnProductName)
				Me.columnSupplier = New Global.System.Data.DataColumn("Supplier", GetType(String), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnSupplier)
				Me.columnProductName.MaxLength = 40
				Me.columnSupplier.ReadOnly = True
				Me.columnSupplier.MaxLength = 255
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function NewOrderDetailsRow() As OrderDetailsRow
				Return (CType(Me.NewRow(), OrderDetailsRow))
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
				Return New OrderDetailsRow(builder)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Function GetRowType() As Global.System.Type
				Return GetType(OrderDetailsRow)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				If (Me.OrderDetailsRowChangedEvent IsNot Nothing) Then
					RaiseEvent OrderDetailsRowChanged(Me, New OrderDetailsRowChangeEvent((CType(e.Row, OrderDetailsRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				If (Me.OrderDetailsRowChangingEvent IsNot Nothing) Then
					RaiseEvent OrderDetailsRowChanging(Me, New OrderDetailsRowChangeEvent((CType(e.Row, OrderDetailsRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				If (Me.OrderDetailsRowDeletedEvent IsNot Nothing) Then
					RaiseEvent OrderDetailsRowDeleted(Me, New OrderDetailsRowChangeEvent((CType(e.Row, OrderDetailsRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				If (Me.OrderDetailsRowDeletingEvent IsNot Nothing) Then
					RaiseEvent OrderDetailsRowDeleting(Me, New OrderDetailsRowChangeEvent((CType(e.Row, OrderDetailsRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub RemoveOrderDetailsRow(ByVal row As OrderDetailsRow)
				Me.Rows.Remove(row)
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
				Dim type As New Global.System.Xml.Schema.XmlSchemaComplexType()
				Dim sequence As New Global.System.Xml.Schema.XmlSchemaSequence()
				Dim ds As New NwindDataSet()
				Dim any1 As New Global.System.Xml.Schema.XmlSchemaAny()
				any1.Namespace = "http://www.w3.org/2001/XMLSchema"
				any1.MinOccurs = New Decimal(0)
				any1.MaxOccurs = Decimal.MaxValue
				any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any1)
				Dim any2 As New Global.System.Xml.Schema.XmlSchemaAny()
				any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
				any2.MinOccurs = New Decimal(1)
				any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any2)
				Dim attribute1 As New Global.System.Xml.Schema.XmlSchemaAttribute()
				attribute1.Name = "namespace"
				attribute1.FixedValue = ds.Namespace
				type.Attributes.Add(attribute1)
				Dim attribute2 As New Global.System.Xml.Schema.XmlSchemaAttribute()
				attribute2.Name = "tableTypeName"
				attribute2.FixedValue = "OrderDetailsDataTable"
				type.Attributes.Add(attribute2)
				type.Particle = sequence
				Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable()
				If xs.Contains(dsSchema.TargetNamespace) Then
					Dim s1 As New Global.System.IO.MemoryStream()
					Dim s2 As New Global.System.IO.MemoryStream()
					Try
						Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
						dsSchema.Write(s1)
						Dim schemas As System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
						Do While schemas.MoveNext()
							schema = (CType(schemas.Current, Global.System.Xml.Schema.XmlSchema))
							s2.SetLength(0)
							schema.Write(s2)
							If (s1.Length = s2.Length) Then
								s1.Position = 0
								s2.Position = 0
								Do While ((s1.Position <> s1.Length) AndAlso (s1.ReadByte() = s2.ReadByte()))

								Loop
								If (s1.Position = s1.Length) Then
									Return type
								End If
							End If
						Loop
					Finally
						If (s1 IsNot Nothing) Then
							s1.Close()
						End If
						If (s2 IsNot Nothing) Then
							s2.Close()
						End If
					End Try
				End If
				xs.Add(dsSchema)
				Return type
			End Function
		End Class

		''' <summary>
		'''Represents the strongly named DataTable class.
		'''</summary>
		<Global.System.Serializable(), Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")> _
		Partial Public Class OrderReportsDataTable
			Inherits System.Data.TypedTableBase(Of OrderReportsRow)

			Private columnOrderID As Global.System.Data.DataColumn

			Private columnProductID As Global.System.Data.DataColumn

			Private columnProductName As Global.System.Data.DataColumn

			Private columnUnitPrice As Global.System.Data.DataColumn

			Private columnQuantity As Global.System.Data.DataColumn

			Private columnDiscount As Global.System.Data.DataColumn

			Private columnExtended_Price As Global.System.Data.DataColumn

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub New()
				Me.TableName = "OrderReports"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Friend Sub New(ByVal table As Global.System.Data.DataTable)
				Me.TableName = table.TableName
				If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
					Me.CaseSensitive = table.CaseSensitive
				End If
				If (table.Locale.ToString() <> table.DataSet.Locale.ToString()) Then
					Me.Locale = table.Locale
				End If
				If (table.Namespace <> table.DataSet.Namespace) Then
					Me.Namespace = table.Namespace
				End If
				Me.Prefix = table.Prefix
				Me.MinimumCapacity = table.MinimumCapacity
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
				MyBase.New(info, context)
				Me.InitVars()
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property OrderIDColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnOrderID
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property ProductIDColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnProductID
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property ProductNameColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnProductName
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property UnitPriceColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnUnitPrice
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property QuantityColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnQuantity
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property DiscountColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnDiscount
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property Extended_PriceColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnExtended_Price
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Global.System.ComponentModel.Browsable(False)> _
			Public ReadOnly Property Count() As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Default Public ReadOnly Property Item(ByVal index As Integer) As OrderReportsRow
				Get
					Return (CType(Me.Rows(index), OrderReportsRow))
				End Get
			End Property

			<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Event OrderReportsRowChanging As OrderReportsRowChangeEventHandler

			<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Event OrderReportsRowChanged As OrderReportsRowChangeEventHandler

			<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Event OrderReportsRowDeleting As OrderReportsRowChangeEventHandler

			<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Event OrderReportsRowDeleted As OrderReportsRowChangeEventHandler

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub AddOrderReportsRow(ByVal row As OrderReportsRow)
				Me.Rows.Add(row)
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function AddOrderReportsRow(ByVal OrderID As Integer, ByVal ProductID As Integer, ByVal ProductName As String, ByVal UnitPrice As Decimal, ByVal Quantity As Short, ByVal Discount As Single, ByVal Extended_Price As Decimal) As OrderReportsRow
				Dim rowOrderReportsRow As OrderReportsRow = (CType(Me.NewRow(), OrderReportsRow))
				Dim columnValuesArray() As Object = { OrderID, ProductID, ProductName, UnitPrice, Quantity, Discount, Extended_Price}
				rowOrderReportsRow.ItemArray = columnValuesArray
				Me.Rows.Add(rowOrderReportsRow)
				Return rowOrderReportsRow
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Overrides Function Clone() As Global.System.Data.DataTable
				Dim cln As OrderReportsDataTable = (CType(MyBase.Clone(), OrderReportsDataTable))
				cln.InitVars()
				Return cln
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
				Return New OrderReportsDataTable()
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Friend Sub InitVars()
				Me.columnOrderID = MyBase.Columns("OrderID")
				Me.columnProductID = MyBase.Columns("ProductID")
				Me.columnProductName = MyBase.Columns("ProductName")
				Me.columnUnitPrice = MyBase.Columns("UnitPrice")
				Me.columnQuantity = MyBase.Columns("Quantity")
				Me.columnDiscount = MyBase.Columns("Discount")
				Me.columnExtended_Price = MyBase.Columns("Extended Price")
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Private Sub InitClass()
				Me.columnOrderID = New Global.System.Data.DataColumn("OrderID", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnOrderID)
				Me.columnProductID = New Global.System.Data.DataColumn("ProductID", GetType(Integer), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnProductID)
				Me.columnProductName = New Global.System.Data.DataColumn("ProductName", GetType(String), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnProductName)
				Me.columnUnitPrice = New Global.System.Data.DataColumn("UnitPrice", GetType(Decimal), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnUnitPrice)
				Me.columnQuantity = New Global.System.Data.DataColumn("Quantity", GetType(Short), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnQuantity)
				Me.columnDiscount = New Global.System.Data.DataColumn("Discount", GetType(Single), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnDiscount)
				Me.columnExtended_Price = New Global.System.Data.DataColumn("Extended Price", GetType(Decimal), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnExtended_Price)
				Me.columnProductName.MaxLength = 40
				Me.columnExtended_Price.ReadOnly = True
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function NewOrderReportsRow() As OrderReportsRow
				Return (CType(Me.NewRow(), OrderReportsRow))
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
				Return New OrderReportsRow(builder)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Function GetRowType() As Global.System.Type
				Return GetType(OrderReportsRow)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				If (Me.OrderReportsRowChangedEvent IsNot Nothing) Then
					RaiseEvent OrderReportsRowChanged(Me, New OrderReportsRowChangeEvent((CType(e.Row, OrderReportsRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				If (Me.OrderReportsRowChangingEvent IsNot Nothing) Then
					RaiseEvent OrderReportsRowChanging(Me, New OrderReportsRowChangeEvent((CType(e.Row, OrderReportsRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				If (Me.OrderReportsRowDeletedEvent IsNot Nothing) Then
					RaiseEvent OrderReportsRowDeleted(Me, New OrderReportsRowChangeEvent((CType(e.Row, OrderReportsRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				If (Me.OrderReportsRowDeletingEvent IsNot Nothing) Then
					RaiseEvent OrderReportsRowDeleting(Me, New OrderReportsRowChangeEvent((CType(e.Row, OrderReportsRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub RemoveOrderReportsRow(ByVal row As OrderReportsRow)
				Me.Rows.Remove(row)
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
				Dim type As New Global.System.Xml.Schema.XmlSchemaComplexType()
				Dim sequence As New Global.System.Xml.Schema.XmlSchemaSequence()
				Dim ds As New NwindDataSet()
				Dim any1 As New Global.System.Xml.Schema.XmlSchemaAny()
				any1.Namespace = "http://www.w3.org/2001/XMLSchema"
				any1.MinOccurs = New Decimal(0)
				any1.MaxOccurs = Decimal.MaxValue
				any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any1)
				Dim any2 As New Global.System.Xml.Schema.XmlSchemaAny()
				any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
				any2.MinOccurs = New Decimal(1)
				any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any2)
				Dim attribute1 As New Global.System.Xml.Schema.XmlSchemaAttribute()
				attribute1.Name = "namespace"
				attribute1.FixedValue = ds.Namespace
				type.Attributes.Add(attribute1)
				Dim attribute2 As New Global.System.Xml.Schema.XmlSchemaAttribute()
				attribute2.Name = "tableTypeName"
				attribute2.FixedValue = "OrderReportsDataTable"
				type.Attributes.Add(attribute2)
				type.Particle = sequence
				Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable()
				If xs.Contains(dsSchema.TargetNamespace) Then
					Dim s1 As New Global.System.IO.MemoryStream()
					Dim s2 As New Global.System.IO.MemoryStream()
					Try
						Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
						dsSchema.Write(s1)
						Dim schemas As System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
						Do While schemas.MoveNext()
							schema = (CType(schemas.Current, Global.System.Xml.Schema.XmlSchema))
							s2.SetLength(0)
							schema.Write(s2)
							If (s1.Length = s2.Length) Then
								s1.Position = 0
								s2.Position = 0
								Do While ((s1.Position <> s1.Length) AndAlso (s1.ReadByte() = s2.ReadByte()))

								Loop
								If (s1.Position = s1.Length) Then
									Return type
								End If
							End If
						Loop
					Finally
						If (s1 IsNot Nothing) Then
							s1.Close()
						End If
						If (s2 IsNot Nothing) Then
							s2.Close()
						End If
					End Try
				End If
				xs.Add(dsSchema)
				Return type
			End Function
		End Class

		''' <summary>
		'''Represents the strongly named DataTable class.
		'''</summary>
		<Global.System.Serializable(), Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")> _
		Partial Public Class ProductReportsDataTable
			Inherits System.Data.TypedTableBase(Of ProductReportsRow)

			Private columnCategoryName As Global.System.Data.DataColumn

			Private columnProductName As Global.System.Data.DataColumn

			Private columnProductSales As Global.System.Data.DataColumn

			Private columnShippedDate As Global.System.Data.DataColumn

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub New()
				Me.TableName = "ProductReports"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Friend Sub New(ByVal table As Global.System.Data.DataTable)
				Me.TableName = table.TableName
				If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
					Me.CaseSensitive = table.CaseSensitive
				End If
				If (table.Locale.ToString() <> table.DataSet.Locale.ToString()) Then
					Me.Locale = table.Locale
				End If
				If (table.Namespace <> table.DataSet.Namespace) Then
					Me.Namespace = table.Namespace
				End If
				Me.Prefix = table.Prefix
				Me.MinimumCapacity = table.MinimumCapacity
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
				MyBase.New(info, context)
				Me.InitVars()
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property CategoryNameColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnCategoryName
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property ProductNameColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnProductName
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property ProductSalesColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnProductSales
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property ShippedDateColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnShippedDate
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Global.System.ComponentModel.Browsable(False)> _
			Public ReadOnly Property Count() As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Default Public ReadOnly Property Item(ByVal index As Integer) As ProductReportsRow
				Get
					Return (CType(Me.Rows(index), ProductReportsRow))
				End Get
			End Property

			<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Event ProductReportsRowChanging As ProductReportsRowChangeEventHandler

			<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Event ProductReportsRowChanged As ProductReportsRowChangeEventHandler

			<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Event ProductReportsRowDeleting As ProductReportsRowChangeEventHandler

			<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Event ProductReportsRowDeleted As ProductReportsRowChangeEventHandler

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub AddProductReportsRow(ByVal row As ProductReportsRow)
				Me.Rows.Add(row)
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function AddProductReportsRow(ByVal CategoryName As String, ByVal ProductName As String, ByVal ProductSales As Decimal, ByVal ShippedDate As System.DateTime) As ProductReportsRow
				Dim rowProductReportsRow As ProductReportsRow = (CType(Me.NewRow(), ProductReportsRow))
				Dim columnValuesArray() As Object = { CategoryName, ProductName, ProductSales, ShippedDate}
				rowProductReportsRow.ItemArray = columnValuesArray
				Me.Rows.Add(rowProductReportsRow)
				Return rowProductReportsRow
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Overrides Function Clone() As Global.System.Data.DataTable
				Dim cln As ProductReportsDataTable = (CType(MyBase.Clone(), ProductReportsDataTable))
				cln.InitVars()
				Return cln
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
				Return New ProductReportsDataTable()
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Friend Sub InitVars()
				Me.columnCategoryName = MyBase.Columns("CategoryName")
				Me.columnProductName = MyBase.Columns("ProductName")
				Me.columnProductSales = MyBase.Columns("ProductSales")
				Me.columnShippedDate = MyBase.Columns("ShippedDate")
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Private Sub InitClass()
				Me.columnCategoryName = New Global.System.Data.DataColumn("CategoryName", GetType(String), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnCategoryName)
				Me.columnProductName = New Global.System.Data.DataColumn("ProductName", GetType(String), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnProductName)
				Me.columnProductSales = New Global.System.Data.DataColumn("ProductSales", GetType(Decimal), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnProductSales)
				Me.columnShippedDate = New Global.System.Data.DataColumn("ShippedDate", GetType(Global.System.DateTime), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnShippedDate)
				Me.columnCategoryName.MaxLength = 15
				Me.columnProductName.MaxLength = 40
				Me.columnProductSales.ReadOnly = True
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function NewProductReportsRow() As ProductReportsRow
				Return (CType(Me.NewRow(), ProductReportsRow))
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
				Return New ProductReportsRow(builder)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Function GetRowType() As Global.System.Type
				Return GetType(ProductReportsRow)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				If (Me.ProductReportsRowChangedEvent IsNot Nothing) Then
					RaiseEvent ProductReportsRowChanged(Me, New ProductReportsRowChangeEvent((CType(e.Row, ProductReportsRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				If (Me.ProductReportsRowChangingEvent IsNot Nothing) Then
					RaiseEvent ProductReportsRowChanging(Me, New ProductReportsRowChangeEvent((CType(e.Row, ProductReportsRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				If (Me.ProductReportsRowDeletedEvent IsNot Nothing) Then
					RaiseEvent ProductReportsRowDeleted(Me, New ProductReportsRowChangeEvent((CType(e.Row, ProductReportsRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				If (Me.ProductReportsRowDeletingEvent IsNot Nothing) Then
					RaiseEvent ProductReportsRowDeleting(Me, New ProductReportsRowChangeEvent((CType(e.Row, ProductReportsRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub RemoveProductReportsRow(ByVal row As ProductReportsRow)
				Me.Rows.Remove(row)
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
				Dim type As New Global.System.Xml.Schema.XmlSchemaComplexType()
				Dim sequence As New Global.System.Xml.Schema.XmlSchemaSequence()
				Dim ds As New NwindDataSet()
				Dim any1 As New Global.System.Xml.Schema.XmlSchemaAny()
				any1.Namespace = "http://www.w3.org/2001/XMLSchema"
				any1.MinOccurs = New Decimal(0)
				any1.MaxOccurs = Decimal.MaxValue
				any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any1)
				Dim any2 As New Global.System.Xml.Schema.XmlSchemaAny()
				any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
				any2.MinOccurs = New Decimal(1)
				any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any2)
				Dim attribute1 As New Global.System.Xml.Schema.XmlSchemaAttribute()
				attribute1.Name = "namespace"
				attribute1.FixedValue = ds.Namespace
				type.Attributes.Add(attribute1)
				Dim attribute2 As New Global.System.Xml.Schema.XmlSchemaAttribute()
				attribute2.Name = "tableTypeName"
				attribute2.FixedValue = "ProductReportsDataTable"
				type.Attributes.Add(attribute2)
				type.Particle = sequence
				Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable()
				If xs.Contains(dsSchema.TargetNamespace) Then
					Dim s1 As New Global.System.IO.MemoryStream()
					Dim s2 As New Global.System.IO.MemoryStream()
					Try
						Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
						dsSchema.Write(s1)
						Dim schemas As System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
						Do While schemas.MoveNext()
							schema = (CType(schemas.Current, Global.System.Xml.Schema.XmlSchema))
							s2.SetLength(0)
							schema.Write(s2)
							If (s1.Length = s2.Length) Then
								s1.Position = 0
								s2.Position = 0
								Do While ((s1.Position <> s1.Length) AndAlso (s1.ReadByte() = s2.ReadByte()))

								Loop
								If (s1.Position = s1.Length) Then
									Return type
								End If
							End If
						Loop
					Finally
						If (s1 IsNot Nothing) Then
							s1.Close()
						End If
						If (s2 IsNot Nothing) Then
							s2.Close()
						End If
					End Try
				End If
				xs.Add(dsSchema)
				Return type
			End Function
		End Class

		''' <summary>
		'''Represents strongly named DataRow class.
		'''</summary>
		Partial Public Class CategoryProductsRow
			Inherits System.Data.DataRow

			Private tableCategoryProducts As CategoryProductsDataTable

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
				MyBase.New(rb)
				Me.tableCategoryProducts = (CType(Me.Table, CategoryProductsDataTable))
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property ProductID() As Integer
				Get
					Try
						Return (CInt(Fix(Me(Me.tableCategoryProducts.ProductIDColumn))))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'ProductID' in table 'CategoryProducts' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As Integer)
					Me(Me.tableCategoryProducts.ProductIDColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property SupplierID() As Integer
				Get
					Try
						Return (CInt(Fix(Me(Me.tableCategoryProducts.SupplierIDColumn))))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'SupplierID' in table 'CategoryProducts' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As Integer)
					Me(Me.tableCategoryProducts.SupplierIDColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property ProductName() As String
				Get
					Try
						Return (CStr(Me(Me.tableCategoryProducts.ProductNameColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'ProductName' in table 'CategoryProducts' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableCategoryProducts.ProductNameColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property CategoryName() As String
				Get
					Try
						Return (CStr(Me(Me.tableCategoryProducts.CategoryNameColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'CategoryName' in table 'CategoryProducts' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableCategoryProducts.CategoryNameColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property Picture() As Byte()
				Get
					Try
						Return (CType(Me(Me.tableCategoryProducts.PictureColumn), Byte()))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'Picture' in table 'CategoryProducts' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As Byte())
					Me(Me.tableCategoryProducts.PictureColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property Description() As String
				Get
					Try
						Return (CStr(Me(Me.tableCategoryProducts.DescriptionColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'Description' in table 'CategoryProducts' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableCategoryProducts.DescriptionColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsProductIDNull() As Boolean
				Return Me.IsNull(Me.tableCategoryProducts.ProductIDColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetProductIDNull()
				Me(Me.tableCategoryProducts.ProductIDColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsSupplierIDNull() As Boolean
				Return Me.IsNull(Me.tableCategoryProducts.SupplierIDColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetSupplierIDNull()
				Me(Me.tableCategoryProducts.SupplierIDColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsProductNameNull() As Boolean
				Return Me.IsNull(Me.tableCategoryProducts.ProductNameColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetProductNameNull()
				Me(Me.tableCategoryProducts.ProductNameColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsCategoryNameNull() As Boolean
				Return Me.IsNull(Me.tableCategoryProducts.CategoryNameColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetCategoryNameNull()
				Me(Me.tableCategoryProducts.CategoryNameColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsPictureNull() As Boolean
				Return Me.IsNull(Me.tableCategoryProducts.PictureColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetPictureNull()
				Me(Me.tableCategoryProducts.PictureColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsDescriptionNull() As Boolean
				Return Me.IsNull(Me.tableCategoryProducts.DescriptionColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetDescriptionNull()
				Me(Me.tableCategoryProducts.DescriptionColumn) = Global.System.Convert.DBNull
			End Sub
		End Class

		''' <summary>
		'''Represents strongly named DataRow class.
		'''</summary>
		Partial Public Class SalesPersonRow
			Inherits System.Data.DataRow

			Private tableSalesPerson As SalesPersonDataTable

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
				MyBase.New(rb)
				Me.tableSalesPerson = (CType(Me.Table, SalesPersonDataTable))
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property OrderID() As Integer
				Get
					Try
						Return (CInt(Fix(Me(Me.tableSalesPerson.OrderIDColumn))))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'OrderID' in table 'SalesPerson' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As Integer)
					Me(Me.tableSalesPerson.OrderIDColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property Country() As String
				Get
					Try
						Return (CStr(Me(Me.tableSalesPerson.CountryColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'Country' in table 'SalesPerson' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableSalesPerson.CountryColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property FirstName() As String
				Get
					Try
						Return (CStr(Me(Me.tableSalesPerson.FirstNameColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'FirstName' in table 'SalesPerson' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableSalesPerson.FirstNameColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property LastName() As String
				Get
					Try
						Return (CStr(Me(Me.tableSalesPerson.LastNameColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'LastName' in table 'SalesPerson' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableSalesPerson.LastNameColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property ProductName() As String
				Get
					Try
						Return (CStr(Me(Me.tableSalesPerson.ProductNameColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'ProductName' in table 'SalesPerson' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableSalesPerson.ProductNameColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property CategoryName() As String
				Get
					Try
						Return (CStr(Me(Me.tableSalesPerson.CategoryNameColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'CategoryName' in table 'SalesPerson' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableSalesPerson.CategoryNameColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property OrderDate() As System.DateTime
				Get
					Try
						Return (CDate(Me(Me.tableSalesPerson.OrderDateColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'OrderDate' in table 'SalesPerson' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As System.DateTime)
					Me(Me.tableSalesPerson.OrderDateColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property UnitPrice() As Decimal
				Get
					Try
						Return (CDec(Me(Me.tableSalesPerson.UnitPriceColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'UnitPrice' in table 'SalesPerson' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As Decimal)
					Me(Me.tableSalesPerson.UnitPriceColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property Quantity() As Short
				Get
					Try
						Return (CShort(Fix(Me(Me.tableSalesPerson.QuantityColumn))))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'Quantity' in table 'SalesPerson' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As Short)
					Me(Me.tableSalesPerson.QuantityColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property Discount() As Single
				Get
					Try
						Return (CSng(Me(Me.tableSalesPerson.DiscountColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'Discount' in table 'SalesPerson' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As Single)
					Me(Me.tableSalesPerson.DiscountColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property Extended_Price() As Decimal
				Get
					Try
						Return (CDec(Me(Me.tableSalesPerson.Extended_PriceColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'Extended Price' in table 'SalesPerson' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As Decimal)
					Me(Me.tableSalesPerson.Extended_PriceColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property Sales_Person() As String
				Get
					Try
						Return (CStr(Me(Me.tableSalesPerson.Sales_PersonColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'Sales Person' in table 'SalesPerson' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableSalesPerson.Sales_PersonColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsOrderIDNull() As Boolean
				Return Me.IsNull(Me.tableSalesPerson.OrderIDColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetOrderIDNull()
				Me(Me.tableSalesPerson.OrderIDColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsCountryNull() As Boolean
				Return Me.IsNull(Me.tableSalesPerson.CountryColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetCountryNull()
				Me(Me.tableSalesPerson.CountryColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsFirstNameNull() As Boolean
				Return Me.IsNull(Me.tableSalesPerson.FirstNameColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetFirstNameNull()
				Me(Me.tableSalesPerson.FirstNameColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsLastNameNull() As Boolean
				Return Me.IsNull(Me.tableSalesPerson.LastNameColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetLastNameNull()
				Me(Me.tableSalesPerson.LastNameColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsProductNameNull() As Boolean
				Return Me.IsNull(Me.tableSalesPerson.ProductNameColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetProductNameNull()
				Me(Me.tableSalesPerson.ProductNameColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsCategoryNameNull() As Boolean
				Return Me.IsNull(Me.tableSalesPerson.CategoryNameColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetCategoryNameNull()
				Me(Me.tableSalesPerson.CategoryNameColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsOrderDateNull() As Boolean
				Return Me.IsNull(Me.tableSalesPerson.OrderDateColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetOrderDateNull()
				Me(Me.tableSalesPerson.OrderDateColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsUnitPriceNull() As Boolean
				Return Me.IsNull(Me.tableSalesPerson.UnitPriceColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetUnitPriceNull()
				Me(Me.tableSalesPerson.UnitPriceColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsQuantityNull() As Boolean
				Return Me.IsNull(Me.tableSalesPerson.QuantityColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetQuantityNull()
				Me(Me.tableSalesPerson.QuantityColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsDiscountNull() As Boolean
				Return Me.IsNull(Me.tableSalesPerson.DiscountColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetDiscountNull()
				Me(Me.tableSalesPerson.DiscountColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsExtended_PriceNull() As Boolean
				Return Me.IsNull(Me.tableSalesPerson.Extended_PriceColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetExtended_PriceNull()
				Me(Me.tableSalesPerson.Extended_PriceColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsSales_PersonNull() As Boolean
				Return Me.IsNull(Me.tableSalesPerson.Sales_PersonColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetSales_PersonNull()
				Me(Me.tableSalesPerson.Sales_PersonColumn) = Global.System.Convert.DBNull
			End Sub
		End Class

		''' <summary>
		'''Represents strongly named DataRow class.
		'''</summary>
		Partial Public Class CustomerReportsRow
			Inherits System.Data.DataRow

			Private tableCustomerReports As CustomerReportsDataTable

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
				MyBase.New(rb)
				Me.tableCustomerReports = (CType(Me.Table, CustomerReportsDataTable))
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property ProductName() As String
				Get
					Try
						Return (CStr(Me(Me.tableCustomerReports.ProductNameColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'ProductName' in table 'CustomerReports' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableCustomerReports.ProductNameColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property CompanyName() As String
				Get
					Try
						Return (CStr(Me(Me.tableCustomerReports.CompanyNameColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'CompanyName' in table 'CustomerReports' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableCustomerReports.CompanyNameColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property OrderDate() As System.DateTime
				Get
					Try
						Return (CDate(Me(Me.tableCustomerReports.OrderDateColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'OrderDate' in table 'CustomerReports' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As System.DateTime)
					Me(Me.tableCustomerReports.OrderDateColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property ProductAmount() As Decimal
				Get
					Try
						Return (CDec(Me(Me.tableCustomerReports.ProductAmountColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'ProductAmount' in table 'CustomerReports' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As Decimal)
					Me(Me.tableCustomerReports.ProductAmountColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsProductNameNull() As Boolean
				Return Me.IsNull(Me.tableCustomerReports.ProductNameColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetProductNameNull()
				Me(Me.tableCustomerReports.ProductNameColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsCompanyNameNull() As Boolean
				Return Me.IsNull(Me.tableCustomerReports.CompanyNameColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetCompanyNameNull()
				Me(Me.tableCustomerReports.CompanyNameColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsOrderDateNull() As Boolean
				Return Me.IsNull(Me.tableCustomerReports.OrderDateColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetOrderDateNull()
				Me(Me.tableCustomerReports.OrderDateColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsProductAmountNull() As Boolean
				Return Me.IsNull(Me.tableCustomerReports.ProductAmountColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetProductAmountNull()
				Me(Me.tableCustomerReports.ProductAmountColumn) = Global.System.Convert.DBNull
			End Sub
		End Class

		''' <summary>
		'''Represents strongly named DataRow class.
		'''</summary>
		Partial Public Class InvoicesRow
			Inherits System.Data.DataRow

			Private tableInvoices As InvoicesDataTable

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
				MyBase.New(rb)
				Me.tableInvoices = (CType(Me.Table, InvoicesDataTable))
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property ShipName() As String
				Get
					Try
						Return (CStr(Me(Me.tableInvoices.ShipNameColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'ShipName' in table 'Invoices' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableInvoices.ShipNameColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property ShipAddress() As String
				Get
					Try
						Return (CStr(Me(Me.tableInvoices.ShipAddressColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'ShipAddress' in table 'Invoices' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableInvoices.ShipAddressColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property ShipCity() As String
				Get
					Try
						Return (CStr(Me(Me.tableInvoices.ShipCityColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'ShipCity' in table 'Invoices' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableInvoices.ShipCityColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property ShipRegion() As String
				Get
					Try
						Return (CStr(Me(Me.tableInvoices.ShipRegionColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'ShipRegion' in table 'Invoices' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableInvoices.ShipRegionColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property ShipPostalCode() As String
				Get
					Try
						Return (CStr(Me(Me.tableInvoices.ShipPostalCodeColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'ShipPostalCode' in table 'Invoices' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableInvoices.ShipPostalCodeColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property ShipCountry() As String
				Get
					Try
						Return (CStr(Me(Me.tableInvoices.ShipCountryColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'ShipCountry' in table 'Invoices' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableInvoices.ShipCountryColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property CustomerID() As String
				Get
					Try
						Return (CStr(Me(Me.tableInvoices.CustomerIDColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'CustomerID' in table 'Invoices' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableInvoices.CustomerIDColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property Customers_CompanyName() As String
				Get
					Try
						Return (CStr(Me(Me.tableInvoices.Customers_CompanyNameColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'Customers_CompanyName' in table 'Invoices' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableInvoices.Customers_CompanyNameColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property Address() As String
				Get
					Try
						Return (CStr(Me(Me.tableInvoices.AddressColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'Address' in table 'Invoices' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableInvoices.AddressColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property City() As String
				Get
					Try
						Return (CStr(Me(Me.tableInvoices.CityColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'City' in table 'Invoices' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableInvoices.CityColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property Region() As String
				Get
					Try
						Return (CStr(Me(Me.tableInvoices.RegionColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'Region' in table 'Invoices' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableInvoices.RegionColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property PostalCode() As String
				Get
					Try
						Return (CStr(Me(Me.tableInvoices.PostalCodeColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'PostalCode' in table 'Invoices' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableInvoices.PostalCodeColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property Country() As String
				Get
					Try
						Return (CStr(Me(Me.tableInvoices.CountryColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'Country' in table 'Invoices' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableInvoices.CountryColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property Salesperson() As String
				Get
					Try
						Return (CStr(Me(Me.tableInvoices.SalespersonColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'Salesperson' in table 'Invoices' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableInvoices.SalespersonColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property OrderID() As Integer
				Get
					Try
						Return (CInt(Fix(Me(Me.tableInvoices.OrderIDColumn))))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'OrderID' in table 'Invoices' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As Integer)
					Me(Me.tableInvoices.OrderIDColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property OrderDate() As System.DateTime
				Get
					Try
						Return (CDate(Me(Me.tableInvoices.OrderDateColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'OrderDate' in table 'Invoices' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As System.DateTime)
					Me(Me.tableInvoices.OrderDateColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property RequiredDate() As System.DateTime
				Get
					Try
						Return (CDate(Me(Me.tableInvoices.RequiredDateColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'RequiredDate' in table 'Invoices' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As System.DateTime)
					Me(Me.tableInvoices.RequiredDateColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property ShippedDate() As System.DateTime
				Get
					Try
						Return (CDate(Me(Me.tableInvoices.ShippedDateColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'ShippedDate' in table 'Invoices' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As System.DateTime)
					Me(Me.tableInvoices.ShippedDateColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property Shippers_CompanyName() As String
				Get
					Try
						Return (CStr(Me(Me.tableInvoices.Shippers_CompanyNameColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'Shippers_CompanyName' in table 'Invoices' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableInvoices.Shippers_CompanyNameColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property ProductID() As Integer
				Get
					Try
						Return (CInt(Fix(Me(Me.tableInvoices.ProductIDColumn))))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'ProductID' in table 'Invoices' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As Integer)
					Me(Me.tableInvoices.ProductIDColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property ProductName() As String
				Get
					Try
						Return (CStr(Me(Me.tableInvoices.ProductNameColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'ProductName' in table 'Invoices' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableInvoices.ProductNameColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property UnitPrice() As Decimal
				Get
					Try
						Return (CDec(Me(Me.tableInvoices.UnitPriceColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'UnitPrice' in table 'Invoices' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As Decimal)
					Me(Me.tableInvoices.UnitPriceColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property Quantity() As Short
				Get
					Try
						Return (CShort(Fix(Me(Me.tableInvoices.QuantityColumn))))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'Quantity' in table 'Invoices' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As Short)
					Me(Me.tableInvoices.QuantityColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property Discount() As Single
				Get
					Try
						Return (CSng(Me(Me.tableInvoices.DiscountColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'Discount' in table 'Invoices' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As Single)
					Me(Me.tableInvoices.DiscountColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property ExtendedPrice() As Decimal
				Get
					Try
						Return (CDec(Me(Me.tableInvoices.ExtendedPriceColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'ExtendedPrice' in table 'Invoices' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As Decimal)
					Me(Me.tableInvoices.ExtendedPriceColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property Freight() As Decimal
				Get
					Try
						Return (CDec(Me(Me.tableInvoices.FreightColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'Freight' in table 'Invoices' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As Decimal)
					Me(Me.tableInvoices.FreightColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsShipNameNull() As Boolean
				Return Me.IsNull(Me.tableInvoices.ShipNameColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetShipNameNull()
				Me(Me.tableInvoices.ShipNameColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsShipAddressNull() As Boolean
				Return Me.IsNull(Me.tableInvoices.ShipAddressColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetShipAddressNull()
				Me(Me.tableInvoices.ShipAddressColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsShipCityNull() As Boolean
				Return Me.IsNull(Me.tableInvoices.ShipCityColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetShipCityNull()
				Me(Me.tableInvoices.ShipCityColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsShipRegionNull() As Boolean
				Return Me.IsNull(Me.tableInvoices.ShipRegionColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetShipRegionNull()
				Me(Me.tableInvoices.ShipRegionColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsShipPostalCodeNull() As Boolean
				Return Me.IsNull(Me.tableInvoices.ShipPostalCodeColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetShipPostalCodeNull()
				Me(Me.tableInvoices.ShipPostalCodeColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsShipCountryNull() As Boolean
				Return Me.IsNull(Me.tableInvoices.ShipCountryColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetShipCountryNull()
				Me(Me.tableInvoices.ShipCountryColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsCustomerIDNull() As Boolean
				Return Me.IsNull(Me.tableInvoices.CustomerIDColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetCustomerIDNull()
				Me(Me.tableInvoices.CustomerIDColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsCustomers_CompanyNameNull() As Boolean
				Return Me.IsNull(Me.tableInvoices.Customers_CompanyNameColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetCustomers_CompanyNameNull()
				Me(Me.tableInvoices.Customers_CompanyNameColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsAddressNull() As Boolean
				Return Me.IsNull(Me.tableInvoices.AddressColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetAddressNull()
				Me(Me.tableInvoices.AddressColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsCityNull() As Boolean
				Return Me.IsNull(Me.tableInvoices.CityColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetCityNull()
				Me(Me.tableInvoices.CityColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsRegionNull() As Boolean
				Return Me.IsNull(Me.tableInvoices.RegionColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetRegionNull()
				Me(Me.tableInvoices.RegionColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsPostalCodeNull() As Boolean
				Return Me.IsNull(Me.tableInvoices.PostalCodeColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetPostalCodeNull()
				Me(Me.tableInvoices.PostalCodeColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsCountryNull() As Boolean
				Return Me.IsNull(Me.tableInvoices.CountryColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetCountryNull()
				Me(Me.tableInvoices.CountryColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsSalespersonNull() As Boolean
				Return Me.IsNull(Me.tableInvoices.SalespersonColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetSalespersonNull()
				Me(Me.tableInvoices.SalespersonColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsOrderIDNull() As Boolean
				Return Me.IsNull(Me.tableInvoices.OrderIDColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetOrderIDNull()
				Me(Me.tableInvoices.OrderIDColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsOrderDateNull() As Boolean
				Return Me.IsNull(Me.tableInvoices.OrderDateColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetOrderDateNull()
				Me(Me.tableInvoices.OrderDateColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsRequiredDateNull() As Boolean
				Return Me.IsNull(Me.tableInvoices.RequiredDateColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetRequiredDateNull()
				Me(Me.tableInvoices.RequiredDateColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsShippedDateNull() As Boolean
				Return Me.IsNull(Me.tableInvoices.ShippedDateColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetShippedDateNull()
				Me(Me.tableInvoices.ShippedDateColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsShippers_CompanyNameNull() As Boolean
				Return Me.IsNull(Me.tableInvoices.Shippers_CompanyNameColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetShippers_CompanyNameNull()
				Me(Me.tableInvoices.Shippers_CompanyNameColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsProductIDNull() As Boolean
				Return Me.IsNull(Me.tableInvoices.ProductIDColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetProductIDNull()
				Me(Me.tableInvoices.ProductIDColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsProductNameNull() As Boolean
				Return Me.IsNull(Me.tableInvoices.ProductNameColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetProductNameNull()
				Me(Me.tableInvoices.ProductNameColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsUnitPriceNull() As Boolean
				Return Me.IsNull(Me.tableInvoices.UnitPriceColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetUnitPriceNull()
				Me(Me.tableInvoices.UnitPriceColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsQuantityNull() As Boolean
				Return Me.IsNull(Me.tableInvoices.QuantityColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetQuantityNull()
				Me(Me.tableInvoices.QuantityColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsDiscountNull() As Boolean
				Return Me.IsNull(Me.tableInvoices.DiscountColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetDiscountNull()
				Me(Me.tableInvoices.DiscountColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsExtendedPriceNull() As Boolean
				Return Me.IsNull(Me.tableInvoices.ExtendedPriceColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetExtendedPriceNull()
				Me(Me.tableInvoices.ExtendedPriceColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsFreightNull() As Boolean
				Return Me.IsNull(Me.tableInvoices.FreightColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetFreightNull()
				Me(Me.tableInvoices.FreightColumn) = Global.System.Convert.DBNull
			End Sub
		End Class

		''' <summary>
		'''Represents strongly named DataRow class.
		'''</summary>
		Partial Public Class OrderDetailsRow
			Inherits System.Data.DataRow

			Private tableOrderDetails As OrderDetailsDataTable

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
				MyBase.New(rb)
				Me.tableOrderDetails = (CType(Me.Table, OrderDetailsDataTable))
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property OrderID() As Integer
				Get
					Try
						Return (CInt(Fix(Me(Me.tableOrderDetails.OrderIDColumn))))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'OrderID' in table 'OrderDetails' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As Integer)
					Me(Me.tableOrderDetails.OrderIDColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property Quantity() As Short
				Get
					Try
						Return (CShort(Fix(Me(Me.tableOrderDetails.QuantityColumn))))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'Quantity' in table 'OrderDetails' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As Short)
					Me(Me.tableOrderDetails.QuantityColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property UnitPrice() As Decimal
				Get
					Try
						Return (CDec(Me(Me.tableOrderDetails.UnitPriceColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'UnitPrice' in table 'OrderDetails' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As Decimal)
					Me(Me.tableOrderDetails.UnitPriceColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property Discount() As Single
				Get
					Try
						Return (CSng(Me(Me.tableOrderDetails.DiscountColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'Discount' in table 'OrderDetails' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As Single)
					Me(Me.tableOrderDetails.DiscountColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property ProductName() As String
				Get
					Try
						Return (CStr(Me(Me.tableOrderDetails.ProductNameColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'ProductName' in table 'OrderDetails' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableOrderDetails.ProductNameColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property Supplier() As String
				Get
					Try
						Return (CStr(Me(Me.tableOrderDetails.SupplierColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'Supplier' in table 'OrderDetails' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableOrderDetails.SupplierColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsOrderIDNull() As Boolean
				Return Me.IsNull(Me.tableOrderDetails.OrderIDColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetOrderIDNull()
				Me(Me.tableOrderDetails.OrderIDColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsQuantityNull() As Boolean
				Return Me.IsNull(Me.tableOrderDetails.QuantityColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetQuantityNull()
				Me(Me.tableOrderDetails.QuantityColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsUnitPriceNull() As Boolean
				Return Me.IsNull(Me.tableOrderDetails.UnitPriceColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetUnitPriceNull()
				Me(Me.tableOrderDetails.UnitPriceColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsDiscountNull() As Boolean
				Return Me.IsNull(Me.tableOrderDetails.DiscountColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetDiscountNull()
				Me(Me.tableOrderDetails.DiscountColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsProductNameNull() As Boolean
				Return Me.IsNull(Me.tableOrderDetails.ProductNameColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetProductNameNull()
				Me(Me.tableOrderDetails.ProductNameColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsSupplierNull() As Boolean
				Return Me.IsNull(Me.tableOrderDetails.SupplierColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetSupplierNull()
				Me(Me.tableOrderDetails.SupplierColumn) = Global.System.Convert.DBNull
			End Sub
		End Class

		''' <summary>
		'''Represents strongly named DataRow class.
		'''</summary>
		Partial Public Class OrderReportsRow
			Inherits System.Data.DataRow

			Private tableOrderReports As OrderReportsDataTable

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
				MyBase.New(rb)
				Me.tableOrderReports = (CType(Me.Table, OrderReportsDataTable))
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property OrderID() As Integer
				Get
					Try
						Return (CInt(Fix(Me(Me.tableOrderReports.OrderIDColumn))))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'OrderID' in table 'OrderReports' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As Integer)
					Me(Me.tableOrderReports.OrderIDColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property ProductID() As Integer
				Get
					Try
						Return (CInt(Fix(Me(Me.tableOrderReports.ProductIDColumn))))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'ProductID' in table 'OrderReports' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As Integer)
					Me(Me.tableOrderReports.ProductIDColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property ProductName() As String
				Get
					Try
						Return (CStr(Me(Me.tableOrderReports.ProductNameColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'ProductName' in table 'OrderReports' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableOrderReports.ProductNameColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property UnitPrice() As Decimal
				Get
					Try
						Return (CDec(Me(Me.tableOrderReports.UnitPriceColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'UnitPrice' in table 'OrderReports' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As Decimal)
					Me(Me.tableOrderReports.UnitPriceColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property Quantity() As Short
				Get
					Try
						Return (CShort(Fix(Me(Me.tableOrderReports.QuantityColumn))))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'Quantity' in table 'OrderReports' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As Short)
					Me(Me.tableOrderReports.QuantityColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property Discount() As Single
				Get
					Try
						Return (CSng(Me(Me.tableOrderReports.DiscountColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'Discount' in table 'OrderReports' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As Single)
					Me(Me.tableOrderReports.DiscountColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property Extended_Price() As Decimal
				Get
					Try
						Return (CDec(Me(Me.tableOrderReports.Extended_PriceColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'Extended Price' in table 'OrderReports' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As Decimal)
					Me(Me.tableOrderReports.Extended_PriceColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsOrderIDNull() As Boolean
				Return Me.IsNull(Me.tableOrderReports.OrderIDColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetOrderIDNull()
				Me(Me.tableOrderReports.OrderIDColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsProductIDNull() As Boolean
				Return Me.IsNull(Me.tableOrderReports.ProductIDColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetProductIDNull()
				Me(Me.tableOrderReports.ProductIDColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsProductNameNull() As Boolean
				Return Me.IsNull(Me.tableOrderReports.ProductNameColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetProductNameNull()
				Me(Me.tableOrderReports.ProductNameColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsUnitPriceNull() As Boolean
				Return Me.IsNull(Me.tableOrderReports.UnitPriceColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetUnitPriceNull()
				Me(Me.tableOrderReports.UnitPriceColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsQuantityNull() As Boolean
				Return Me.IsNull(Me.tableOrderReports.QuantityColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetQuantityNull()
				Me(Me.tableOrderReports.QuantityColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsDiscountNull() As Boolean
				Return Me.IsNull(Me.tableOrderReports.DiscountColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetDiscountNull()
				Me(Me.tableOrderReports.DiscountColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsExtended_PriceNull() As Boolean
				Return Me.IsNull(Me.tableOrderReports.Extended_PriceColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetExtended_PriceNull()
				Me(Me.tableOrderReports.Extended_PriceColumn) = Global.System.Convert.DBNull
			End Sub
		End Class

		''' <summary>
		'''Represents strongly named DataRow class.
		'''</summary>
		Partial Public Class ProductReportsRow
			Inherits System.Data.DataRow

			Private tableProductReports As ProductReportsDataTable

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
				MyBase.New(rb)
				Me.tableProductReports = (CType(Me.Table, ProductReportsDataTable))
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property CategoryName() As String
				Get
					Try
						Return (CStr(Me(Me.tableProductReports.CategoryNameColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'CategoryName' in table 'ProductReports' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableProductReports.CategoryNameColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property ProductName() As String
				Get
					Try
						Return (CStr(Me(Me.tableProductReports.ProductNameColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'ProductName' in table 'ProductReports' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableProductReports.ProductNameColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property ProductSales() As Decimal
				Get
					Try
						Return (CDec(Me(Me.tableProductReports.ProductSalesColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'ProductSales' in table 'ProductReports' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As Decimal)
					Me(Me.tableProductReports.ProductSalesColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Property ShippedDate() As System.DateTime
				Get
					Try
						Return (CDate(Me(Me.tableProductReports.ShippedDateColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'ShippedDate' in table 'ProductReports' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As System.DateTime)
					Me(Me.tableProductReports.ShippedDateColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsCategoryNameNull() As Boolean
				Return Me.IsNull(Me.tableProductReports.CategoryNameColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetCategoryNameNull()
				Me(Me.tableProductReports.CategoryNameColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsProductNameNull() As Boolean
				Return Me.IsNull(Me.tableProductReports.ProductNameColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetProductNameNull()
				Me(Me.tableProductReports.ProductNameColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsProductSalesNull() As Boolean
				Return Me.IsNull(Me.tableProductReports.ProductSalesColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetProductSalesNull()
				Me(Me.tableProductReports.ProductSalesColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Function IsShippedDateNull() As Boolean
				Return Me.IsNull(Me.tableProductReports.ShippedDateColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub SetShippedDateNull()
				Me(Me.tableProductReports.ShippedDateColumn) = Global.System.Convert.DBNull
			End Sub
		End Class

		''' <summary>
		'''Row event argument class
		'''</summary>
		<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Public Class CategoryProductsRowChangeEvent
			Inherits System.EventArgs

			Private eventRow As CategoryProductsRow

			Private eventAction As Global.System.Data.DataRowAction

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub New(ByVal row As CategoryProductsRow, ByVal action As Global.System.Data.DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property Row() As CategoryProductsRow
				Get
					Return Me.eventRow
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property Action() As Global.System.Data.DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property
		End Class

		''' <summary>
		'''Row event argument class
		'''</summary>
		<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Public Class SalesPersonRowChangeEvent
			Inherits System.EventArgs

			Private eventRow As SalesPersonRow

			Private eventAction As Global.System.Data.DataRowAction

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub New(ByVal row As SalesPersonRow, ByVal action As Global.System.Data.DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property Row() As SalesPersonRow
				Get
					Return Me.eventRow
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property Action() As Global.System.Data.DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property
		End Class

		''' <summary>
		'''Row event argument class
		'''</summary>
		<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Public Class CustomerReportsRowChangeEvent
			Inherits System.EventArgs

			Private eventRow As CustomerReportsRow

			Private eventAction As Global.System.Data.DataRowAction

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub New(ByVal row As CustomerReportsRow, ByVal action As Global.System.Data.DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property Row() As CustomerReportsRow
				Get
					Return Me.eventRow
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property Action() As Global.System.Data.DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property
		End Class

		''' <summary>
		'''Row event argument class
		'''</summary>
		<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Public Class InvoicesRowChangeEvent
			Inherits System.EventArgs

			Private eventRow As InvoicesRow

			Private eventAction As Global.System.Data.DataRowAction

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub New(ByVal row As InvoicesRow, ByVal action As Global.System.Data.DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property Row() As InvoicesRow
				Get
					Return Me.eventRow
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property Action() As Global.System.Data.DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property
		End Class

		''' <summary>
		'''Row event argument class
		'''</summary>
		<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Public Class OrderDetailsRowChangeEvent
			Inherits System.EventArgs

			Private eventRow As OrderDetailsRow

			Private eventAction As Global.System.Data.DataRowAction

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub New(ByVal row As OrderDetailsRow, ByVal action As Global.System.Data.DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property Row() As OrderDetailsRow
				Get
					Return Me.eventRow
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property Action() As Global.System.Data.DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property
		End Class

		''' <summary>
		'''Row event argument class
		'''</summary>
		<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Public Class OrderReportsRowChangeEvent
			Inherits System.EventArgs

			Private eventRow As OrderReportsRow

			Private eventAction As Global.System.Data.DataRowAction

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub New(ByVal row As OrderReportsRow, ByVal action As Global.System.Data.DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property Row() As OrderReportsRow
				Get
					Return Me.eventRow
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property Action() As Global.System.Data.DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property
		End Class

		''' <summary>
		'''Row event argument class
		'''</summary>
		<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Public Class ProductReportsRowChangeEvent
			Inherits System.EventArgs

			Private eventRow As ProductReportsRow

			Private eventAction As Global.System.Data.DataRowAction

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public Sub New(ByVal row As ProductReportsRow, ByVal action As Global.System.Data.DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property Row() As ProductReportsRow
				Get
					Return Me.eventRow
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Public ReadOnly Property Action() As Global.System.Data.DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property
		End Class
	End Class
End Namespace
Namespace HowToBindToMDB.NwindDataSetTableAdapters


	''' <summary>
	'''Represents the connection and commands used to retrieve and save data.
	'''</summary>
	<Global.System.ComponentModel.DesignerCategoryAttribute("code"), Global.System.ComponentModel.ToolboxItem(True), Global.System.ComponentModel.DataObjectAttribute(True), Global.System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" & ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
	Partial Public Class CategoryProductsTableAdapter
		Inherits System.ComponentModel.Component

		Private _adapter As Global.System.Data.OleDb.OleDbDataAdapter

		Private _connection As Global.System.Data.OleDb.OleDbConnection

		Private _transaction As Global.System.Data.OleDb.OleDbTransaction

		Private _commandCollection() As Global.System.Data.OleDb.OleDbCommand

		Private _clearBeforeFill As Boolean

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Public Sub New()
			Me.ClearBeforeFill = True
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Protected Friend ReadOnly Property Adapter() As Global.System.Data.OleDb.OleDbDataAdapter
			Get
				If (Me._adapter Is Nothing) Then
					Me.InitAdapter()
				End If
				Return Me._adapter
			End Get
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Friend Property Connection() As Global.System.Data.OleDb.OleDbConnection
			Get
				If (Me._connection Is Nothing) Then
					Me.InitConnection()
				End If
				Return Me._connection
			End Get
			Set(ByVal value As System.Data.OleDb.OleDbConnection)
				Me._connection = value
				If (Me.Adapter.InsertCommand IsNot Nothing) Then
					Me.Adapter.InsertCommand.Connection = value
				End If
				If (Me.Adapter.DeleteCommand IsNot Nothing) Then
					Me.Adapter.DeleteCommand.Connection = value
				End If
				If (Me.Adapter.UpdateCommand IsNot Nothing) Then
					Me.Adapter.UpdateCommand.Connection = value
				End If
				Dim i As Integer = 0
				Do While (i < Me.CommandCollection.Length)
					If (Me.CommandCollection(i) IsNot Nothing) Then
						CType(Me.CommandCollection(i), Global.System.Data.OleDb.OleDbCommand).Connection = value
					End If
					i = (i + 1)
				Loop
			End Set
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Friend Property Transaction() As Global.System.Data.OleDb.OleDbTransaction
			Get
				Return Me._transaction
			End Get
			Set(ByVal value As System.Data.OleDb.OleDbTransaction)
				Me._transaction = value
				Dim i As Integer = 0
				Do While (i < Me.CommandCollection.Length)
					Me.CommandCollection(i).Transaction = Me._transaction
					i = (i + 1)
				Loop
				If ((Me.Adapter IsNot Nothing) AndAlso (Me.Adapter.DeleteCommand IsNot Nothing)) Then
					Me.Adapter.DeleteCommand.Transaction = Me._transaction
				End If
				If ((Me.Adapter IsNot Nothing) AndAlso (Me.Adapter.InsertCommand IsNot Nothing)) Then
					Me.Adapter.InsertCommand.Transaction = Me._transaction
				End If
				If ((Me.Adapter IsNot Nothing) AndAlso (Me.Adapter.UpdateCommand IsNot Nothing)) Then
					Me.Adapter.UpdateCommand.Transaction = Me._transaction
				End If
			End Set
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Protected ReadOnly Property CommandCollection() As Global.System.Data.OleDb.OleDbCommand()
			Get
				If (Me._commandCollection Is Nothing) Then
					Me.InitCommandCollection()
				End If
				Return Me._commandCollection
			End Get
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Public Property ClearBeforeFill() As Boolean
			Get
				Return Me._clearBeforeFill
			End Get
			Set(ByVal value As Boolean)
				Me._clearBeforeFill = value
			End Set
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Private Sub InitAdapter()
			Me._adapter = New Global.System.Data.OleDb.OleDbDataAdapter()
			Dim tableMapping As New Global.System.Data.Common.DataTableMapping()
			tableMapping.SourceTable = "Table"
			tableMapping.DataSetTable = "CategoryProducts"
			tableMapping.ColumnMappings.Add("ProductID", "ProductID")
			tableMapping.ColumnMappings.Add("SupplierID", "SupplierID")
			tableMapping.ColumnMappings.Add("ProductName", "ProductName")
			tableMapping.ColumnMappings.Add("CategoryName", "CategoryName")
			tableMapping.ColumnMappings.Add("Picture", "Picture")
			tableMapping.ColumnMappings.Add("Description", "Description")
			Me._adapter.TableMappings.Add(tableMapping)
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Private Sub InitConnection()
			Me._connection = New Global.System.Data.OleDb.OleDbConnection()
			Me._connection.ConnectionString = My.Settings.Default.nwindConnectionString
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Private Sub InitCommandCollection()
			Me._commandCollection = New Global.System.Data.OleDb.OleDbCommand(0){}
			Me._commandCollection(0) = New Global.System.Data.OleDb.OleDbCommand()
			Me._commandCollection(0).Connection = Me.Connection
			Me._commandCollection(0).CommandText = "SELECT ProductID, SupplierID, ProductName, CategoryName, Picture, Description FRO" & "M CategoryProducts"
			Me._commandCollection(0).CommandType = Global.System.Data.CommandType.Text
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"), Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Fill, True)> _
		Public Overridable Function Fill(ByVal dataTable As NwindDataSet.CategoryProductsDataTable) As Integer
			Me.Adapter.SelectCommand = Me.CommandCollection(0)
			If (Me.ClearBeforeFill = True) Then
				dataTable.Clear()
			End If
			Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
			Return returnValue
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"), Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Select, True)> _
		Public Overridable Function GetData() As NwindDataSet.CategoryProductsDataTable
			Me.Adapter.SelectCommand = Me.CommandCollection(0)
			Dim dataTable As New NwindDataSet.CategoryProductsDataTable()
			Me.Adapter.Fill(dataTable)
			Return dataTable
		End Function
	End Class

	''' <summary>
	'''Represents the connection and commands used to retrieve and save data.
	'''</summary>
	<Global.System.ComponentModel.DesignerCategoryAttribute("code"), Global.System.ComponentModel.ToolboxItem(True), Global.System.ComponentModel.DataObjectAttribute(True), Global.System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" & ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
	Partial Public Class SalesPersonTableAdapter
		Inherits System.ComponentModel.Component

		Private _adapter As Global.System.Data.OleDb.OleDbDataAdapter

		Private _connection As Global.System.Data.OleDb.OleDbConnection

		Private _transaction As Global.System.Data.OleDb.OleDbTransaction

		Private _commandCollection() As Global.System.Data.OleDb.OleDbCommand

		Private _clearBeforeFill As Boolean

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Public Sub New()
			Me.ClearBeforeFill = True
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Protected Friend ReadOnly Property Adapter() As Global.System.Data.OleDb.OleDbDataAdapter
			Get
				If (Me._adapter Is Nothing) Then
					Me.InitAdapter()
				End If
				Return Me._adapter
			End Get
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Friend Property Connection() As Global.System.Data.OleDb.OleDbConnection
			Get
				If (Me._connection Is Nothing) Then
					Me.InitConnection()
				End If
				Return Me._connection
			End Get
			Set(ByVal value As System.Data.OleDb.OleDbConnection)
				Me._connection = value
				If (Me.Adapter.InsertCommand IsNot Nothing) Then
					Me.Adapter.InsertCommand.Connection = value
				End If
				If (Me.Adapter.DeleteCommand IsNot Nothing) Then
					Me.Adapter.DeleteCommand.Connection = value
				End If
				If (Me.Adapter.UpdateCommand IsNot Nothing) Then
					Me.Adapter.UpdateCommand.Connection = value
				End If
				Dim i As Integer = 0
				Do While (i < Me.CommandCollection.Length)
					If (Me.CommandCollection(i) IsNot Nothing) Then
						CType(Me.CommandCollection(i), Global.System.Data.OleDb.OleDbCommand).Connection = value
					End If
					i = (i + 1)
				Loop
			End Set
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Friend Property Transaction() As Global.System.Data.OleDb.OleDbTransaction
			Get
				Return Me._transaction
			End Get
			Set(ByVal value As System.Data.OleDb.OleDbTransaction)
				Me._transaction = value
				Dim i As Integer = 0
				Do While (i < Me.CommandCollection.Length)
					Me.CommandCollection(i).Transaction = Me._transaction
					i = (i + 1)
				Loop
				If ((Me.Adapter IsNot Nothing) AndAlso (Me.Adapter.DeleteCommand IsNot Nothing)) Then
					Me.Adapter.DeleteCommand.Transaction = Me._transaction
				End If
				If ((Me.Adapter IsNot Nothing) AndAlso (Me.Adapter.InsertCommand IsNot Nothing)) Then
					Me.Adapter.InsertCommand.Transaction = Me._transaction
				End If
				If ((Me.Adapter IsNot Nothing) AndAlso (Me.Adapter.UpdateCommand IsNot Nothing)) Then
					Me.Adapter.UpdateCommand.Transaction = Me._transaction
				End If
			End Set
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Protected ReadOnly Property CommandCollection() As Global.System.Data.OleDb.OleDbCommand()
			Get
				If (Me._commandCollection Is Nothing) Then
					Me.InitCommandCollection()
				End If
				Return Me._commandCollection
			End Get
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Public Property ClearBeforeFill() As Boolean
			Get
				Return Me._clearBeforeFill
			End Get
			Set(ByVal value As Boolean)
				Me._clearBeforeFill = value
			End Set
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Private Sub InitAdapter()
			Me._adapter = New Global.System.Data.OleDb.OleDbDataAdapter()
			Dim tableMapping As New Global.System.Data.Common.DataTableMapping()
			tableMapping.SourceTable = "Table"
			tableMapping.DataSetTable = "SalesPerson"
			tableMapping.ColumnMappings.Add("OrderID", "OrderID")
			tableMapping.ColumnMappings.Add("Country", "Country")
			tableMapping.ColumnMappings.Add("FirstName", "FirstName")
			tableMapping.ColumnMappings.Add("LastName", "LastName")
			tableMapping.ColumnMappings.Add("ProductName", "ProductName")
			tableMapping.ColumnMappings.Add("CategoryName", "CategoryName")
			tableMapping.ColumnMappings.Add("OrderDate", "OrderDate")
			tableMapping.ColumnMappings.Add("UnitPrice", "UnitPrice")
			tableMapping.ColumnMappings.Add("Quantity", "Quantity")
			tableMapping.ColumnMappings.Add("Discount", "Discount")
			tableMapping.ColumnMappings.Add("Extended Price", "Extended Price")
			tableMapping.ColumnMappings.Add("Sales Person", "Sales Person")
			Me._adapter.TableMappings.Add(tableMapping)
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Private Sub InitConnection()
			Me._connection = New Global.System.Data.OleDb.OleDbConnection()
			Me._connection.ConnectionString = My.Settings.Default.nwindConnectionString
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Private Sub InitCommandCollection()
			Me._commandCollection = New Global.System.Data.OleDb.OleDbCommand(0){}
			Me._commandCollection(0) = New Global.System.Data.OleDb.OleDbCommand()
			Me._commandCollection(0).Connection = Me.Connection
			Me._commandCollection(0).CommandText = "SELECT OrderID, Country, FirstName, LastName, ProductName, CategoryName, OrderDat" & "e, UnitPrice, Quantity, Discount, [Extended Price], [Sales Person] FROM SalesPer" & "son"
			Me._commandCollection(0).CommandType = Global.System.Data.CommandType.Text
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"), Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Fill, True)> _
		Public Overridable Function Fill(ByVal dataTable As NwindDataSet.SalesPersonDataTable) As Integer
			Me.Adapter.SelectCommand = Me.CommandCollection(0)
			If (Me.ClearBeforeFill = True) Then
				dataTable.Clear()
			End If
			Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
			Return returnValue
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"), Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Select, True)> _
		Public Overridable Function GetData() As NwindDataSet.SalesPersonDataTable
			Me.Adapter.SelectCommand = Me.CommandCollection(0)
			Dim dataTable As New NwindDataSet.SalesPersonDataTable()
			Me.Adapter.Fill(dataTable)
			Return dataTable
		End Function
	End Class

	''' <summary>
	'''Represents the connection and commands used to retrieve and save data.
	'''</summary>
	<Global.System.ComponentModel.DesignerCategoryAttribute("code"), Global.System.ComponentModel.ToolboxItem(True), Global.System.ComponentModel.DataObjectAttribute(True), Global.System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" & ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
	Partial Public Class CustomerReportsTableAdapter
		Inherits System.ComponentModel.Component

		Private _adapter As Global.System.Data.OleDb.OleDbDataAdapter

		Private _connection As Global.System.Data.OleDb.OleDbConnection

		Private _transaction As Global.System.Data.OleDb.OleDbTransaction

		Private _commandCollection() As Global.System.Data.OleDb.OleDbCommand

		Private _clearBeforeFill As Boolean

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Public Sub New()
			Me.ClearBeforeFill = True
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Protected Friend ReadOnly Property Adapter() As Global.System.Data.OleDb.OleDbDataAdapter
			Get
				If (Me._adapter Is Nothing) Then
					Me.InitAdapter()
				End If
				Return Me._adapter
			End Get
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Friend Property Connection() As Global.System.Data.OleDb.OleDbConnection
			Get
				If (Me._connection Is Nothing) Then
					Me.InitConnection()
				End If
				Return Me._connection
			End Get
			Set(ByVal value As System.Data.OleDb.OleDbConnection)
				Me._connection = value
				If (Me.Adapter.InsertCommand IsNot Nothing) Then
					Me.Adapter.InsertCommand.Connection = value
				End If
				If (Me.Adapter.DeleteCommand IsNot Nothing) Then
					Me.Adapter.DeleteCommand.Connection = value
				End If
				If (Me.Adapter.UpdateCommand IsNot Nothing) Then
					Me.Adapter.UpdateCommand.Connection = value
				End If
				Dim i As Integer = 0
				Do While (i < Me.CommandCollection.Length)
					If (Me.CommandCollection(i) IsNot Nothing) Then
						CType(Me.CommandCollection(i), Global.System.Data.OleDb.OleDbCommand).Connection = value
					End If
					i = (i + 1)
				Loop
			End Set
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Friend Property Transaction() As Global.System.Data.OleDb.OleDbTransaction
			Get
				Return Me._transaction
			End Get
			Set(ByVal value As System.Data.OleDb.OleDbTransaction)
				Me._transaction = value
				Dim i As Integer = 0
				Do While (i < Me.CommandCollection.Length)
					Me.CommandCollection(i).Transaction = Me._transaction
					i = (i + 1)
				Loop
				If ((Me.Adapter IsNot Nothing) AndAlso (Me.Adapter.DeleteCommand IsNot Nothing)) Then
					Me.Adapter.DeleteCommand.Transaction = Me._transaction
				End If
				If ((Me.Adapter IsNot Nothing) AndAlso (Me.Adapter.InsertCommand IsNot Nothing)) Then
					Me.Adapter.InsertCommand.Transaction = Me._transaction
				End If
				If ((Me.Adapter IsNot Nothing) AndAlso (Me.Adapter.UpdateCommand IsNot Nothing)) Then
					Me.Adapter.UpdateCommand.Transaction = Me._transaction
				End If
			End Set
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Protected ReadOnly Property CommandCollection() As Global.System.Data.OleDb.OleDbCommand()
			Get
				If (Me._commandCollection Is Nothing) Then
					Me.InitCommandCollection()
				End If
				Return Me._commandCollection
			End Get
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Public Property ClearBeforeFill() As Boolean
			Get
				Return Me._clearBeforeFill
			End Get
			Set(ByVal value As Boolean)
				Me._clearBeforeFill = value
			End Set
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Private Sub InitAdapter()
			Me._adapter = New Global.System.Data.OleDb.OleDbDataAdapter()
			Dim tableMapping As New Global.System.Data.Common.DataTableMapping()
			tableMapping.SourceTable = "Table"
			tableMapping.DataSetTable = "CustomerReports"
			tableMapping.ColumnMappings.Add("ProductName", "ProductName")
			tableMapping.ColumnMappings.Add("CompanyName", "CompanyName")
			tableMapping.ColumnMappings.Add("OrderDate", "OrderDate")
			tableMapping.ColumnMappings.Add("ProductAmount", "ProductAmount")
			Me._adapter.TableMappings.Add(tableMapping)
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Private Sub InitConnection()
			Me._connection = New Global.System.Data.OleDb.OleDbConnection()
			Me._connection.ConnectionString = My.Settings.Default.nwindConnectionString
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Private Sub InitCommandCollection()
			Me._commandCollection = New Global.System.Data.OleDb.OleDbCommand(0){}
			Me._commandCollection(0) = New Global.System.Data.OleDb.OleDbCommand()
			Me._commandCollection(0).Connection = Me.Connection
			Me._commandCollection(0).CommandText = "SELECT ProductName, CompanyName, OrderDate, ProductAmount FROM CustomerReports"
			Me._commandCollection(0).CommandType = Global.System.Data.CommandType.Text
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"), Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Fill, True)> _
		Public Overridable Function Fill(ByVal dataTable As NwindDataSet.CustomerReportsDataTable) As Integer
			Me.Adapter.SelectCommand = Me.CommandCollection(0)
			If (Me.ClearBeforeFill = True) Then
				dataTable.Clear()
			End If
			Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
			Return returnValue
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"), Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Select, True)> _
		Public Overridable Function GetData() As NwindDataSet.CustomerReportsDataTable
			Me.Adapter.SelectCommand = Me.CommandCollection(0)
			Dim dataTable As New NwindDataSet.CustomerReportsDataTable()
			Me.Adapter.Fill(dataTable)
			Return dataTable
		End Function
	End Class

	''' <summary>
	'''Represents the connection and commands used to retrieve and save data.
	'''</summary>
	<Global.System.ComponentModel.DesignerCategoryAttribute("code"), Global.System.ComponentModel.ToolboxItem(True), Global.System.ComponentModel.DataObjectAttribute(True), Global.System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" & ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
	Partial Public Class InvoicesTableAdapter
		Inherits System.ComponentModel.Component

		Private _adapter As Global.System.Data.OleDb.OleDbDataAdapter

		Private _connection As Global.System.Data.OleDb.OleDbConnection

		Private _transaction As Global.System.Data.OleDb.OleDbTransaction

		Private _commandCollection() As Global.System.Data.OleDb.OleDbCommand

		Private _clearBeforeFill As Boolean

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Public Sub New()
			Me.ClearBeforeFill = True
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Protected Friend ReadOnly Property Adapter() As Global.System.Data.OleDb.OleDbDataAdapter
			Get
				If (Me._adapter Is Nothing) Then
					Me.InitAdapter()
				End If
				Return Me._adapter
			End Get
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Friend Property Connection() As Global.System.Data.OleDb.OleDbConnection
			Get
				If (Me._connection Is Nothing) Then
					Me.InitConnection()
				End If
				Return Me._connection
			End Get
			Set(ByVal value As System.Data.OleDb.OleDbConnection)
				Me._connection = value
				If (Me.Adapter.InsertCommand IsNot Nothing) Then
					Me.Adapter.InsertCommand.Connection = value
				End If
				If (Me.Adapter.DeleteCommand IsNot Nothing) Then
					Me.Adapter.DeleteCommand.Connection = value
				End If
				If (Me.Adapter.UpdateCommand IsNot Nothing) Then
					Me.Adapter.UpdateCommand.Connection = value
				End If
				Dim i As Integer = 0
				Do While (i < Me.CommandCollection.Length)
					If (Me.CommandCollection(i) IsNot Nothing) Then
						CType(Me.CommandCollection(i), Global.System.Data.OleDb.OleDbCommand).Connection = value
					End If
					i = (i + 1)
				Loop
			End Set
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Friend Property Transaction() As Global.System.Data.OleDb.OleDbTransaction
			Get
				Return Me._transaction
			End Get
			Set(ByVal value As System.Data.OleDb.OleDbTransaction)
				Me._transaction = value
				Dim i As Integer = 0
				Do While (i < Me.CommandCollection.Length)
					Me.CommandCollection(i).Transaction = Me._transaction
					i = (i + 1)
				Loop
				If ((Me.Adapter IsNot Nothing) AndAlso (Me.Adapter.DeleteCommand IsNot Nothing)) Then
					Me.Adapter.DeleteCommand.Transaction = Me._transaction
				End If
				If ((Me.Adapter IsNot Nothing) AndAlso (Me.Adapter.InsertCommand IsNot Nothing)) Then
					Me.Adapter.InsertCommand.Transaction = Me._transaction
				End If
				If ((Me.Adapter IsNot Nothing) AndAlso (Me.Adapter.UpdateCommand IsNot Nothing)) Then
					Me.Adapter.UpdateCommand.Transaction = Me._transaction
				End If
			End Set
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Protected ReadOnly Property CommandCollection() As Global.System.Data.OleDb.OleDbCommand()
			Get
				If (Me._commandCollection Is Nothing) Then
					Me.InitCommandCollection()
				End If
				Return Me._commandCollection
			End Get
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Public Property ClearBeforeFill() As Boolean
			Get
				Return Me._clearBeforeFill
			End Get
			Set(ByVal value As Boolean)
				Me._clearBeforeFill = value
			End Set
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Private Sub InitAdapter()
			Me._adapter = New Global.System.Data.OleDb.OleDbDataAdapter()
			Dim tableMapping As New Global.System.Data.Common.DataTableMapping()
			tableMapping.SourceTable = "Table"
			tableMapping.DataSetTable = "Invoices"
			tableMapping.ColumnMappings.Add("ShipName", "ShipName")
			tableMapping.ColumnMappings.Add("ShipAddress", "ShipAddress")
			tableMapping.ColumnMappings.Add("ShipCity", "ShipCity")
			tableMapping.ColumnMappings.Add("ShipRegion", "ShipRegion")
			tableMapping.ColumnMappings.Add("ShipPostalCode", "ShipPostalCode")
			tableMapping.ColumnMappings.Add("ShipCountry", "ShipCountry")
			tableMapping.ColumnMappings.Add("CustomerID", "CustomerID")
			tableMapping.ColumnMappings.Add("Customers.CompanyName", "Customers_CompanyName")
			tableMapping.ColumnMappings.Add("Address", "Address")
			tableMapping.ColumnMappings.Add("City", "City")
			tableMapping.ColumnMappings.Add("Region", "Region")
			tableMapping.ColumnMappings.Add("PostalCode", "PostalCode")
			tableMapping.ColumnMappings.Add("Country", "Country")
			tableMapping.ColumnMappings.Add("Salesperson", "Salesperson")
			tableMapping.ColumnMappings.Add("OrderID", "OrderID")
			tableMapping.ColumnMappings.Add("OrderDate", "OrderDate")
			tableMapping.ColumnMappings.Add("RequiredDate", "RequiredDate")
			tableMapping.ColumnMappings.Add("ShippedDate", "ShippedDate")
			tableMapping.ColumnMappings.Add("Shippers.CompanyName", "Shippers_CompanyName")
			tableMapping.ColumnMappings.Add("ProductID", "ProductID")
			tableMapping.ColumnMappings.Add("ProductName", "ProductName")
			tableMapping.ColumnMappings.Add("UnitPrice", "UnitPrice")
			tableMapping.ColumnMappings.Add("Quantity", "Quantity")
			tableMapping.ColumnMappings.Add("Discount", "Discount")
			tableMapping.ColumnMappings.Add("ExtendedPrice", "ExtendedPrice")
			tableMapping.ColumnMappings.Add("Freight", "Freight")
			Me._adapter.TableMappings.Add(tableMapping)
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Private Sub InitConnection()
			Me._connection = New Global.System.Data.OleDb.OleDbConnection()
			Me._connection.ConnectionString = My.Settings.Default.nwindConnectionString
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Private Sub InitCommandCollection()
			Me._commandCollection = New Global.System.Data.OleDb.OleDbCommand(0){}
			Me._commandCollection(0) = New Global.System.Data.OleDb.OleDbCommand()
			Me._commandCollection(0).Connection = Me.Connection
			Me._commandCollection(0).CommandText = "SELECT ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry, CustomerID, [Customers.CompanyName], Address, City, Region, PostalCode, Country, Salesperson, OrderID, OrderDate, RequiredDate, ShippedDate, [Shippers.CompanyName], ProductID, ProductName, UnitPrice, Quantity, Discount, ExtendedPrice, Freight FROM Invoices"
			Me._commandCollection(0).CommandType = Global.System.Data.CommandType.Text
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"), Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Fill, True)> _
		Public Overridable Function Fill(ByVal dataTable As NwindDataSet.InvoicesDataTable) As Integer
			Me.Adapter.SelectCommand = Me.CommandCollection(0)
			If (Me.ClearBeforeFill = True) Then
				dataTable.Clear()
			End If
			Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
			Return returnValue
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"), Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Select, True)> _
		Public Overridable Function GetData() As NwindDataSet.InvoicesDataTable
			Me.Adapter.SelectCommand = Me.CommandCollection(0)
			Dim dataTable As New NwindDataSet.InvoicesDataTable()
			Me.Adapter.Fill(dataTable)
			Return dataTable
		End Function
	End Class

	''' <summary>
	'''Represents the connection and commands used to retrieve and save data.
	'''</summary>
	<Global.System.ComponentModel.DesignerCategoryAttribute("code"), Global.System.ComponentModel.ToolboxItem(True), Global.System.ComponentModel.DataObjectAttribute(True), Global.System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" & ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
	Partial Public Class OrderDetailsTableAdapter
		Inherits System.ComponentModel.Component

		Private _adapter As Global.System.Data.OleDb.OleDbDataAdapter

		Private _connection As Global.System.Data.OleDb.OleDbConnection

		Private _transaction As Global.System.Data.OleDb.OleDbTransaction

		Private _commandCollection() As Global.System.Data.OleDb.OleDbCommand

		Private _clearBeforeFill As Boolean

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Public Sub New()
			Me.ClearBeforeFill = True
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Protected Friend ReadOnly Property Adapter() As Global.System.Data.OleDb.OleDbDataAdapter
			Get
				If (Me._adapter Is Nothing) Then
					Me.InitAdapter()
				End If
				Return Me._adapter
			End Get
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Friend Property Connection() As Global.System.Data.OleDb.OleDbConnection
			Get
				If (Me._connection Is Nothing) Then
					Me.InitConnection()
				End If
				Return Me._connection
			End Get
			Set(ByVal value As System.Data.OleDb.OleDbConnection)
				Me._connection = value
				If (Me.Adapter.InsertCommand IsNot Nothing) Then
					Me.Adapter.InsertCommand.Connection = value
				End If
				If (Me.Adapter.DeleteCommand IsNot Nothing) Then
					Me.Adapter.DeleteCommand.Connection = value
				End If
				If (Me.Adapter.UpdateCommand IsNot Nothing) Then
					Me.Adapter.UpdateCommand.Connection = value
				End If
				Dim i As Integer = 0
				Do While (i < Me.CommandCollection.Length)
					If (Me.CommandCollection(i) IsNot Nothing) Then
						CType(Me.CommandCollection(i), Global.System.Data.OleDb.OleDbCommand).Connection = value
					End If
					i = (i + 1)
				Loop
			End Set
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Friend Property Transaction() As Global.System.Data.OleDb.OleDbTransaction
			Get
				Return Me._transaction
			End Get
			Set(ByVal value As System.Data.OleDb.OleDbTransaction)
				Me._transaction = value
				Dim i As Integer = 0
				Do While (i < Me.CommandCollection.Length)
					Me.CommandCollection(i).Transaction = Me._transaction
					i = (i + 1)
				Loop
				If ((Me.Adapter IsNot Nothing) AndAlso (Me.Adapter.DeleteCommand IsNot Nothing)) Then
					Me.Adapter.DeleteCommand.Transaction = Me._transaction
				End If
				If ((Me.Adapter IsNot Nothing) AndAlso (Me.Adapter.InsertCommand IsNot Nothing)) Then
					Me.Adapter.InsertCommand.Transaction = Me._transaction
				End If
				If ((Me.Adapter IsNot Nothing) AndAlso (Me.Adapter.UpdateCommand IsNot Nothing)) Then
					Me.Adapter.UpdateCommand.Transaction = Me._transaction
				End If
			End Set
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Protected ReadOnly Property CommandCollection() As Global.System.Data.OleDb.OleDbCommand()
			Get
				If (Me._commandCollection Is Nothing) Then
					Me.InitCommandCollection()
				End If
				Return Me._commandCollection
			End Get
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Public Property ClearBeforeFill() As Boolean
			Get
				Return Me._clearBeforeFill
			End Get
			Set(ByVal value As Boolean)
				Me._clearBeforeFill = value
			End Set
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Private Sub InitAdapter()
			Me._adapter = New Global.System.Data.OleDb.OleDbDataAdapter()
			Dim tableMapping As New Global.System.Data.Common.DataTableMapping()
			tableMapping.SourceTable = "Table"
			tableMapping.DataSetTable = "OrderDetails"
			tableMapping.ColumnMappings.Add("OrderID", "OrderID")
			tableMapping.ColumnMappings.Add("Quantity", "Quantity")
			tableMapping.ColumnMappings.Add("UnitPrice", "UnitPrice")
			tableMapping.ColumnMappings.Add("Discount", "Discount")
			tableMapping.ColumnMappings.Add("ProductName", "ProductName")
			tableMapping.ColumnMappings.Add("Supplier", "Supplier")
			Me._adapter.TableMappings.Add(tableMapping)
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Private Sub InitConnection()
			Me._connection = New Global.System.Data.OleDb.OleDbConnection()
			Me._connection.ConnectionString = My.Settings.Default.nwindConnectionString
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Private Sub InitCommandCollection()
			Me._commandCollection = New Global.System.Data.OleDb.OleDbCommand(0){}
			Me._commandCollection(0) = New Global.System.Data.OleDb.OleDbCommand()
			Me._commandCollection(0).Connection = Me.Connection
			Me._commandCollection(0).CommandText = "SELECT OrderID, Quantity, UnitPrice, Discount, ProductName, Supplier FROM OrderDe" & "tails"
			Me._commandCollection(0).CommandType = Global.System.Data.CommandType.Text
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"), Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Fill, True)> _
		Public Overridable Function Fill(ByVal dataTable As NwindDataSet.OrderDetailsDataTable) As Integer
			Me.Adapter.SelectCommand = Me.CommandCollection(0)
			If (Me.ClearBeforeFill = True) Then
				dataTable.Clear()
			End If
			Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
			Return returnValue
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"), Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Select, True)> _
		Public Overridable Function GetData() As NwindDataSet.OrderDetailsDataTable
			Me.Adapter.SelectCommand = Me.CommandCollection(0)
			Dim dataTable As New NwindDataSet.OrderDetailsDataTable()
			Me.Adapter.Fill(dataTable)
			Return dataTable
		End Function
	End Class

	''' <summary>
	'''Represents the connection and commands used to retrieve and save data.
	'''</summary>
	<Global.System.ComponentModel.DesignerCategoryAttribute("code"), Global.System.ComponentModel.ToolboxItem(True), Global.System.ComponentModel.DataObjectAttribute(True), Global.System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" & ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
	Partial Public Class OrderReportsTableAdapter
		Inherits System.ComponentModel.Component

		Private _adapter As Global.System.Data.OleDb.OleDbDataAdapter

		Private _connection As Global.System.Data.OleDb.OleDbConnection

		Private _transaction As Global.System.Data.OleDb.OleDbTransaction

		Private _commandCollection() As Global.System.Data.OleDb.OleDbCommand

		Private _clearBeforeFill As Boolean

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Public Sub New()
			Me.ClearBeforeFill = True
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Protected Friend ReadOnly Property Adapter() As Global.System.Data.OleDb.OleDbDataAdapter
			Get
				If (Me._adapter Is Nothing) Then
					Me.InitAdapter()
				End If
				Return Me._adapter
			End Get
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Friend Property Connection() As Global.System.Data.OleDb.OleDbConnection
			Get
				If (Me._connection Is Nothing) Then
					Me.InitConnection()
				End If
				Return Me._connection
			End Get
			Set(ByVal value As System.Data.OleDb.OleDbConnection)
				Me._connection = value
				If (Me.Adapter.InsertCommand IsNot Nothing) Then
					Me.Adapter.InsertCommand.Connection = value
				End If
				If (Me.Adapter.DeleteCommand IsNot Nothing) Then
					Me.Adapter.DeleteCommand.Connection = value
				End If
				If (Me.Adapter.UpdateCommand IsNot Nothing) Then
					Me.Adapter.UpdateCommand.Connection = value
				End If
				Dim i As Integer = 0
				Do While (i < Me.CommandCollection.Length)
					If (Me.CommandCollection(i) IsNot Nothing) Then
						CType(Me.CommandCollection(i), Global.System.Data.OleDb.OleDbCommand).Connection = value
					End If
					i = (i + 1)
				Loop
			End Set
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Friend Property Transaction() As Global.System.Data.OleDb.OleDbTransaction
			Get
				Return Me._transaction
			End Get
			Set(ByVal value As System.Data.OleDb.OleDbTransaction)
				Me._transaction = value
				Dim i As Integer = 0
				Do While (i < Me.CommandCollection.Length)
					Me.CommandCollection(i).Transaction = Me._transaction
					i = (i + 1)
				Loop
				If ((Me.Adapter IsNot Nothing) AndAlso (Me.Adapter.DeleteCommand IsNot Nothing)) Then
					Me.Adapter.DeleteCommand.Transaction = Me._transaction
				End If
				If ((Me.Adapter IsNot Nothing) AndAlso (Me.Adapter.InsertCommand IsNot Nothing)) Then
					Me.Adapter.InsertCommand.Transaction = Me._transaction
				End If
				If ((Me.Adapter IsNot Nothing) AndAlso (Me.Adapter.UpdateCommand IsNot Nothing)) Then
					Me.Adapter.UpdateCommand.Transaction = Me._transaction
				End If
			End Set
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Protected ReadOnly Property CommandCollection() As Global.System.Data.OleDb.OleDbCommand()
			Get
				If (Me._commandCollection Is Nothing) Then
					Me.InitCommandCollection()
				End If
				Return Me._commandCollection
			End Get
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Public Property ClearBeforeFill() As Boolean
			Get
				Return Me._clearBeforeFill
			End Get
			Set(ByVal value As Boolean)
				Me._clearBeforeFill = value
			End Set
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Private Sub InitAdapter()
			Me._adapter = New Global.System.Data.OleDb.OleDbDataAdapter()
			Dim tableMapping As New Global.System.Data.Common.DataTableMapping()
			tableMapping.SourceTable = "Table"
			tableMapping.DataSetTable = "OrderReports"
			tableMapping.ColumnMappings.Add("OrderID", "OrderID")
			tableMapping.ColumnMappings.Add("ProductID", "ProductID")
			tableMapping.ColumnMappings.Add("ProductName", "ProductName")
			tableMapping.ColumnMappings.Add("UnitPrice", "UnitPrice")
			tableMapping.ColumnMappings.Add("Quantity", "Quantity")
			tableMapping.ColumnMappings.Add("Discount", "Discount")
			tableMapping.ColumnMappings.Add("Extended Price", "Extended Price")
			Me._adapter.TableMappings.Add(tableMapping)
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Private Sub InitConnection()
			Me._connection = New Global.System.Data.OleDb.OleDbConnection()
			Me._connection.ConnectionString = My.Settings.Default.nwindConnectionString
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Private Sub InitCommandCollection()
			Me._commandCollection = New Global.System.Data.OleDb.OleDbCommand(0){}
			Me._commandCollection(0) = New Global.System.Data.OleDb.OleDbCommand()
			Me._commandCollection(0).Connection = Me.Connection
			Me._commandCollection(0).CommandText = "SELECT OrderID, ProductID, ProductName, UnitPrice, Quantity, Discount, [Extended " & "Price] FROM OrderReports"
			Me._commandCollection(0).CommandType = Global.System.Data.CommandType.Text
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"), Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Fill, True)> _
		Public Overridable Function Fill(ByVal dataTable As NwindDataSet.OrderReportsDataTable) As Integer
			Me.Adapter.SelectCommand = Me.CommandCollection(0)
			If (Me.ClearBeforeFill = True) Then
				dataTable.Clear()
			End If
			Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
			Return returnValue
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"), Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Select, True)> _
		Public Overridable Function GetData() As NwindDataSet.OrderReportsDataTable
			Me.Adapter.SelectCommand = Me.CommandCollection(0)
			Dim dataTable As New NwindDataSet.OrderReportsDataTable()
			Me.Adapter.Fill(dataTable)
			Return dataTable
		End Function
	End Class

	''' <summary>
	'''Represents the connection and commands used to retrieve and save data.
	'''</summary>
	<Global.System.ComponentModel.DesignerCategoryAttribute("code"), Global.System.ComponentModel.ToolboxItem(True), Global.System.ComponentModel.DataObjectAttribute(True), Global.System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" & ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
	Partial Public Class ProductReportsTableAdapter
		Inherits System.ComponentModel.Component

		Private _adapter As Global.System.Data.OleDb.OleDbDataAdapter

		Private _connection As Global.System.Data.OleDb.OleDbConnection

		Private _transaction As Global.System.Data.OleDb.OleDbTransaction

		Private _commandCollection() As Global.System.Data.OleDb.OleDbCommand

		Private _clearBeforeFill As Boolean

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Public Sub New()
			Me.ClearBeforeFill = True
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Protected Friend ReadOnly Property Adapter() As Global.System.Data.OleDb.OleDbDataAdapter
			Get
				If (Me._adapter Is Nothing) Then
					Me.InitAdapter()
				End If
				Return Me._adapter
			End Get
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Friend Property Connection() As Global.System.Data.OleDb.OleDbConnection
			Get
				If (Me._connection Is Nothing) Then
					Me.InitConnection()
				End If
				Return Me._connection
			End Get
			Set(ByVal value As System.Data.OleDb.OleDbConnection)
				Me._connection = value
				If (Me.Adapter.InsertCommand IsNot Nothing) Then
					Me.Adapter.InsertCommand.Connection = value
				End If
				If (Me.Adapter.DeleteCommand IsNot Nothing) Then
					Me.Adapter.DeleteCommand.Connection = value
				End If
				If (Me.Adapter.UpdateCommand IsNot Nothing) Then
					Me.Adapter.UpdateCommand.Connection = value
				End If
				Dim i As Integer = 0
				Do While (i < Me.CommandCollection.Length)
					If (Me.CommandCollection(i) IsNot Nothing) Then
						CType(Me.CommandCollection(i), Global.System.Data.OleDb.OleDbCommand).Connection = value
					End If
					i = (i + 1)
				Loop
			End Set
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Friend Property Transaction() As Global.System.Data.OleDb.OleDbTransaction
			Get
				Return Me._transaction
			End Get
			Set(ByVal value As System.Data.OleDb.OleDbTransaction)
				Me._transaction = value
				Dim i As Integer = 0
				Do While (i < Me.CommandCollection.Length)
					Me.CommandCollection(i).Transaction = Me._transaction
					i = (i + 1)
				Loop
				If ((Me.Adapter IsNot Nothing) AndAlso (Me.Adapter.DeleteCommand IsNot Nothing)) Then
					Me.Adapter.DeleteCommand.Transaction = Me._transaction
				End If
				If ((Me.Adapter IsNot Nothing) AndAlso (Me.Adapter.InsertCommand IsNot Nothing)) Then
					Me.Adapter.InsertCommand.Transaction = Me._transaction
				End If
				If ((Me.Adapter IsNot Nothing) AndAlso (Me.Adapter.UpdateCommand IsNot Nothing)) Then
					Me.Adapter.UpdateCommand.Transaction = Me._transaction
				End If
			End Set
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Protected ReadOnly Property CommandCollection() As Global.System.Data.OleDb.OleDbCommand()
			Get
				If (Me._commandCollection Is Nothing) Then
					Me.InitCommandCollection()
				End If
				Return Me._commandCollection
			End Get
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Public Property ClearBeforeFill() As Boolean
			Get
				Return Me._clearBeforeFill
			End Get
			Set(ByVal value As Boolean)
				Me._clearBeforeFill = value
			End Set
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Private Sub InitAdapter()
			Me._adapter = New Global.System.Data.OleDb.OleDbDataAdapter()
			Dim tableMapping As New Global.System.Data.Common.DataTableMapping()
			tableMapping.SourceTable = "Table"
			tableMapping.DataSetTable = "ProductReports"
			tableMapping.ColumnMappings.Add("CategoryName", "CategoryName")
			tableMapping.ColumnMappings.Add("ProductName", "ProductName")
			tableMapping.ColumnMappings.Add("ProductSales", "ProductSales")
			tableMapping.ColumnMappings.Add("ShippedDate", "ShippedDate")
			Me._adapter.TableMappings.Add(tableMapping)
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Private Sub InitConnection()
			Me._connection = New Global.System.Data.OleDb.OleDbConnection()
			Me._connection.ConnectionString = My.Settings.Default.nwindConnectionString
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Private Sub InitCommandCollection()
			Me._commandCollection = New Global.System.Data.OleDb.OleDbCommand(0){}
			Me._commandCollection(0) = New Global.System.Data.OleDb.OleDbCommand()
			Me._commandCollection(0).Connection = Me.Connection
			Me._commandCollection(0).CommandText = "SELECT CategoryName, ProductName, ProductSales, ShippedDate FROM ProductReports"
			Me._commandCollection(0).CommandType = Global.System.Data.CommandType.Text
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"), Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Fill, True)> _
		Public Overridable Function Fill(ByVal dataTable As NwindDataSet.ProductReportsDataTable) As Integer
			Me.Adapter.SelectCommand = Me.CommandCollection(0)
			If (Me.ClearBeforeFill = True) Then
				dataTable.Clear()
			End If
			Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
			Return returnValue
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"), Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Select, True)> _
		Public Overridable Function GetData() As NwindDataSet.ProductReportsDataTable
			Me.Adapter.SelectCommand = Me.CommandCollection(0)
			Dim dataTable As New NwindDataSet.ProductReportsDataTable()
			Me.Adapter.Fill(dataTable)
			Return dataTable
		End Function
	End Class

	''' <summary>
	'''TableAdapterManager is used to coordinate TableAdapters in the dataset to enable Hierarchical Update scenarios
	'''</summary>
	<Global.System.ComponentModel.DesignerCategoryAttribute("code"), Global.System.ComponentModel.ToolboxItem(True), Global.System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSD" & "esigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapterManager")> _
	Partial Public Class TableAdapterManager
		Inherits System.ComponentModel.Component

		Private _updateOrder As UpdateOrderOption

		Private _backupDataSetBeforeUpdate As Boolean

		Private _connection As Global.System.Data.IDbConnection

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Public Property UpdateOrder() As UpdateOrderOption
			Get
				Return Me._updateOrder
			End Get
			Set(ByVal value As UpdateOrderOption)
				Me._updateOrder = value
			End Set
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Public Property BackupDataSetBeforeUpdate() As Boolean
			Get
				Return Me._backupDataSetBeforeUpdate
			End Get
			Set(ByVal value As Boolean)
				Me._backupDataSetBeforeUpdate = value
			End Set
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Global.System.ComponentModel.Browsable(False)> _
		Public Property Connection() As Global.System.Data.IDbConnection
			Get
				If (Me._connection IsNot Nothing) Then
					Return Me._connection
				End If
				Return Nothing
			End Get
			Set(ByVal value As System.Data.IDbConnection)
				Me._connection = value
			End Set
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Global.System.ComponentModel.Browsable(False)> _
		Public ReadOnly Property TableAdapterInstanceCount() As Integer
			Get
				Dim count As Integer = 0
				Return count
			End Get
		End Property

		''' <summary>
		'''Update rows in top-down order.
		'''</summary>
		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Private Function UpdateUpdatedRows(ByVal dataSet As NwindDataSet, ByVal allChangedRows As Global.System.Collections.Generic.List(Of Global.System.Data.DataRow), ByVal allAddedRows As Global.System.Collections.Generic.List(Of Global.System.Data.DataRow)) As Integer
			Dim result As Integer = 0
			Return result
		End Function

		''' <summary>
		'''Insert rows in top-down order.
		'''</summary>
		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Private Function UpdateInsertedRows(ByVal dataSet As NwindDataSet, ByVal allAddedRows As Global.System.Collections.Generic.List(Of Global.System.Data.DataRow)) As Integer
			Dim result As Integer = 0
			Return result
		End Function

		''' <summary>
		'''Delete rows in bottom-up order.
		'''</summary>
		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Private Function UpdateDeletedRows(ByVal dataSet As NwindDataSet, ByVal allChangedRows As Global.System.Collections.Generic.List(Of Global.System.Data.DataRow)) As Integer
			Dim result As Integer = 0
			Return result
		End Function

		''' <summary>
		'''Remove inserted rows that become updated rows after calling TableAdapter.Update(inserted rows) first
		'''</summary>
		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Private Function GetRealUpdatedRows(ByVal updatedRows() As Global.System.Data.DataRow, ByVal allAddedRows As Global.System.Collections.Generic.List(Of Global.System.Data.DataRow)) As Global.System.Data.DataRow()
			If ((updatedRows Is Nothing) OrElse (updatedRows.Length < 1)) Then
				Return updatedRows
			End If
			If ((allAddedRows Is Nothing) OrElse (allAddedRows.Count < 1)) Then
				Return updatedRows
			End If
			Dim realUpdatedRows As New Global.System.Collections.Generic.List(Of Global.System.Data.DataRow)()
			Dim i As Integer = 0
			Do While (i < updatedRows.Length)
				Dim row As Global.System.Data.DataRow = updatedRows(i)
				If (allAddedRows.Contains(row) = False) Then
					realUpdatedRows.Add(row)
				End If
				i = (i + 1)
			Loop
			Return realUpdatedRows.ToArray()
		End Function

		''' <summary>
		'''Update all changes to the dataset.
		'''</summary>
		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Public Overridable Function UpdateAll(ByVal dataSet As NwindDataSet) As Integer
			If (dataSet Is Nothing) Then
				Throw New Global.System.ArgumentNullException("dataSet")
			End If
			If (dataSet.HasChanges() = False) Then
				Return 0
			End If
			Dim workConnection As Global.System.Data.IDbConnection = Me.Connection
			If (workConnection Is Nothing) Then
				Throw New Global.System.ApplicationException("TableAdapterManager contains no connection information. Set each TableAdapterMana" & "ger TableAdapter property to a valid TableAdapter instance.")
			End If
			Dim workConnOpened As Boolean = False
			If ((workConnection.State And Global.System.Data.ConnectionState.Broken) = Global.System.Data.ConnectionState.Broken) Then
				workConnection.Close()
			End If
            If (workConnection.State = Global.System.Data.ConnectionState.Closed) Then
                workConnection.Open()
                workConnOpened = True
            End If
			Dim workTransaction As Global.System.Data.IDbTransaction = workConnection.BeginTransaction()
			If (workTransaction Is Nothing) Then
				Throw New Global.System.ApplicationException("The transaction cannot begin. The current data connection does not support transa" & "ctions or the current state is not allowing the transaction to begin.")
			End If
			Dim allChangedRows As New Global.System.Collections.Generic.List(Of Global.System.Data.DataRow)()
			Dim allAddedRows As New Global.System.Collections.Generic.List(Of Global.System.Data.DataRow)()
			Dim adaptersWithAcceptChangesDuringUpdate As New Global.System.Collections.Generic.List(Of Global.System.Data.Common.DataAdapter)()
			Dim revertConnections As New Global.System.Collections.Generic.Dictionary(Of Object, Global.System.Data.IDbConnection)()
			Dim result As Integer = 0
			Dim backupDataSet As Global.System.Data.DataSet = Nothing
			If Me.BackupDataSetBeforeUpdate Then
				backupDataSet = New Global.System.Data.DataSet()
				backupDataSet.Merge(dataSet)
			End If
			Try
				' ---- Prepare for update -----------
				'
				' 
				'---- Perform updates -----------
				'
				If (Me.UpdateOrder = UpdateOrderOption.UpdateInsertDelete) Then
					result = (result + Me.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows))
					result = (result + Me.UpdateInsertedRows(dataSet, allAddedRows))
				Else
					result = (result + Me.UpdateInsertedRows(dataSet, allAddedRows))
					result = (result + Me.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows))
				End If
				result = (result + Me.UpdateDeletedRows(dataSet, allChangedRows))
				' 
				'---- Commit updates -----------
				'
				workTransaction.Commit()
				If (0 < allAddedRows.Count) Then
					Dim rows(allAddedRows.Count - 1) As Global.System.Data.DataRow
					allAddedRows.CopyTo(rows)
					Dim i As Integer = 0
					Do While (i < rows.Length)
						Dim row As Global.System.Data.DataRow = rows(i)
						row.AcceptChanges()
						i = (i + 1)
					Loop
				End If
				If (0 < allChangedRows.Count) Then
					Dim rows(allChangedRows.Count - 1) As Global.System.Data.DataRow
					allChangedRows.CopyTo(rows)
					Dim i As Integer = 0
					Do While (i < rows.Length)
						Dim row As Global.System.Data.DataRow = rows(i)
						row.AcceptChanges()
						i = (i + 1)
					Loop
				End If
			Catch ex As Global.System.Exception
				workTransaction.Rollback()
				' ---- Restore the dataset -----------
				If Me.BackupDataSetBeforeUpdate Then
					Global.System.Diagnostics.Debug.Assert((backupDataSet IsNot Nothing))
					dataSet.Clear()
					dataSet.Merge(backupDataSet)
				Else
					If (0 < allAddedRows.Count) Then
						Dim rows(allAddedRows.Count - 1) As Global.System.Data.DataRow
						allAddedRows.CopyTo(rows)
						Dim i As Integer = 0
						Do While (i < rows.Length)
							Dim row As Global.System.Data.DataRow = rows(i)
							row.AcceptChanges()
							row.SetAdded()
							i = (i + 1)
						Loop
					End If
				End If
				Throw ex
			Finally
				If workConnOpened Then
					workConnection.Close()
				End If
				If (0 < adaptersWithAcceptChangesDuringUpdate.Count) Then
					Dim adapters(adaptersWithAcceptChangesDuringUpdate.Count - 1) As Global.System.Data.Common.DataAdapter
					adaptersWithAcceptChangesDuringUpdate.CopyTo(adapters)
					Dim i As Integer = 0
					Do While (i < adapters.Length)
						Dim adapter As Global.System.Data.Common.DataAdapter = adapters(i)
						adapter.AcceptChangesDuringUpdate = True
						i = (i + 1)
					Loop
				End If
			End Try
			Return result
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Protected Overridable Sub SortSelfReferenceRows(ByVal rows() As Global.System.Data.DataRow, ByVal relation As Global.System.Data.DataRelation, ByVal childFirst As Boolean)
			Global.System.Array.Sort(Of Global.System.Data.DataRow)(rows, New SelfReferenceComparer(relation, childFirst))
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Protected Overridable Function MatchTableAdapterConnection(ByVal inputConnection As Global.System.Data.IDbConnection) As Boolean
			If (Me._connection IsNot Nothing) Then
				Return True
			End If
			If ((Me.Connection Is Nothing) OrElse (inputConnection Is Nothing)) Then
				Return True
			End If
			If String.Equals(Me.Connection.ConnectionString, inputConnection.ConnectionString, Global.System.StringComparison.Ordinal) Then
				Return True
			End If
			Return False
		End Function

		''' <summary>
		'''Update Order Option
		'''</summary>
		<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Public Enum UpdateOrderOption

			InsertUpdateDelete = 0

			UpdateInsertDelete = 1
		End Enum

		''' <summary>
		'''Used to sort self-referenced table's rows
		'''</summary>
		<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
		Private Class SelfReferenceComparer
			Inherits Object
			Implements System.Collections.Generic.IComparer(Of System.Data.DataRow)

			Private _relation As Global.System.Data.DataRelation

			Private _childFirst As Integer

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Friend Sub New(ByVal relation As Global.System.Data.DataRelation, ByVal childFirst As Boolean)
				Me._relation = relation
				If childFirst Then
					Me._childFirst = -1
				Else
					Me._childFirst = 1
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
			Private Function GetRoot(ByVal row As Global.System.Data.DataRow, <System.Runtime.InteropServices.Out()> ByRef distance As Integer) As Global.System.Data.DataRow
				Global.System.Diagnostics.Debug.Assert((row IsNot Nothing))
				Dim root As Global.System.Data.DataRow = row
				distance = 0

				Dim traversedRows As Global.System.Collections.Generic.IDictionary(Of Global.System.Data.DataRow, Global.System.Data.DataRow) = New Global.System.Collections.Generic.Dictionary(Of Global.System.Data.DataRow, Global.System.Data.DataRow)()
				traversedRows(row) = row

				Dim parent As Global.System.Data.DataRow = row.GetParentRow(Me._relation, Global.System.Data.DataRowVersion.Default)
				Do While ((parent IsNot Nothing) AndAlso (traversedRows.ContainsKey(parent) = False))
					distance = (distance + 1)
					root = parent
					traversedRows(parent) = parent
					parent = parent.GetParentRow(Me._relation, Global.System.Data.DataRowVersion.Default)
				Loop

				If (distance = 0) Then
					traversedRows.Clear()
					traversedRows(row) = row
					parent = row.GetParentRow(Me._relation, Global.System.Data.DataRowVersion.Original)
					Do While ((parent IsNot Nothing) AndAlso (traversedRows.ContainsKey(parent) = False))
						distance = (distance + 1)
						root = parent
						traversedRows(parent) = parent
						parent = parent.GetParentRow(Me._relation, Global.System.Data.DataRowVersion.Original)
					Loop
				End If

				Return root
			End Function

            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
            Public Function Compare(ByVal row1 As Global.System.Data.DataRow, ByVal row2 As Global.System.Data.DataRow) As Integer Implements System.Collections.Generic.IComparer(Of System.Data.DataRow).Compare
                If Object.ReferenceEquals(row1, row2) Then
                    Return 0
                End If
                If (row1 Is Nothing) Then
                    Return -1
                End If
                If (row2 Is Nothing) Then
                    Return 1
                End If

                Dim distance1 As Integer = 0
                Dim root1 As Global.System.Data.DataRow = Me.GetRoot(row1, distance1)

                Dim distance2 As Integer = 0
                Dim root2 As Global.System.Data.DataRow = Me.GetRoot(row2, distance2)

                If Object.ReferenceEquals(root1, root2) Then
                    Return (Me._childFirst * distance1.CompareTo(distance2))
                Else
                    Global.System.Diagnostics.Debug.Assert(((root1.Table IsNot Nothing) AndAlso (root2.Table IsNot Nothing)))
                    If (root1.Table.Rows.IndexOf(root1) < root2.Table.Rows.IndexOf(root2)) Then
                        Return -1
                    Else
                        Return 1
                    End If
                End If
            End Function
		End Class
	End Class
End Namespace