Imports System
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI
Namespace Telerik.Examples.WinControls.GridView.ObjectRelationalHierarchy
	Partial Public Class Form1
		Inherits ExamplesForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			Dim dataContext As New DataContext()

			Me.radGridView1.DataSource = dataContext.Artists
			Me.radGridView1.AutoGenerateHierarchy = True

			Me.SetupTemplates()

			'''--------------------------------------------------------------------------------------------------------------
			'''
			'auto generate Object-Relational Hierarchy using Entity Framework 
			'currently can not be run in our Demo Application - we have dependency to .NET Framework 2.0
			'will be available for next 4.0 version of Demo application and Code Library project: http://www.telerik.com/community/code-library/winforms.aspx

			'AWModel.AdventureWorksLT2008Entities entities = new AWModel.AdventureWorksLT2008Entities();
			'var query = from productCategory in entities.ProductCategory select productCategory;
			'this.radGridView1.DataSource = query.ToList();
			'this.radGridView1.AutoGenerateHierarchy = true;

			'''--------------------------------------------------------------------------------------------------------------


			'''--------------------------------------------------------------------------------------------------------------
			'''
			'auto generate Object-Relational Hierarchy using our OpenAccess ORM Framework
			'you can found example in our Code Library project: http://www.telerik.com/community/code-library/winforms.aspx

			'using (AdventureWorksLT2008 context = new AdventureWorksLT2008())
			'{
			'    List<ProductCategory> list = context.ProductCategories.ToList();
			'    this.radGridView1.DataSource = list;
			'    this.radGridView1.AutoGenerateHierarchy = true;
			'}

			'''--------------------------------------------------------------------------------------------------------------
		End Sub

		Private Sub SetupTemplates()
			Me.radGridView1.EnableFiltering = True
			Me.radGridView1.Columns("Id").IsVisible = False
			Me.radGridView1.Columns("Albums").IsVisible = False
			Me.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill

			Me.radGridView1.Templates(0).AllowAddNewRow = False
			Me.radGridView1.Templates(0).Columns("Id").IsVisible = False
			Me.radGridView1.Templates(0).Columns("ArtistId").IsVisible = False
			Me.radGridView1.Templates(0).Columns("Tracks").IsVisible = False
			Me.radGridView1.Templates(0).AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill

			Me.radGridView1.Templates(0).Templates(0).AllowAddNewRow = False
			Me.radGridView1.Templates(0).Templates(0).Columns("Id").IsVisible = False
			Me.radGridView1.Templates(0).Templates(0).Columns("Size").IsVisible = False
			Me.radGridView1.Templates(0).Templates(0).AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
		End Sub

		Protected Overrides Function GetExampleDefaultTheme() As String
			Return "ControlDefault"
		End Function
	End Class
End Namespace
