Imports System.Diagnostics
Imports System.Windows.Forms

Public Class frmExplorer

    Private Sub frmExplorer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Configurar la IU
        SetUpListViewColumns()
        LoadTree()
    End Sub

    Private Sub LoadTree()
        ' TODO: Agregar código a elementos en la vista de árbol

        Dim tvRoot As TreeNode
        Dim tvNode As TreeNode

        tvRoot = Me.TreeView.Nodes.Add("Root")
        tvNode = tvRoot.Nodes.Add("TreeItem1")
        tvNode = tvRoot.Nodes.Add("TreeItem2")
        tvNode = tvRoot.Nodes.Add("TreeItem3")
    End Sub

    Private Sub LoadListView()
        ' TODO: agregue código para agregar elementos a la vista de lista en función del elemento seleccionado en la vista de árbol

        Dim lvItem As ListViewItem
        ListView.Items.Clear()

        lvItem = ListView.Items.Add("ListViewItem1")
        lvItem.ImageKey = "Graph1"
        lvItem.SubItems.AddRange(New String() {"Columna2", "Columna3"})

        lvItem = ListView.Items.Add("ListViewItem2")
        lvItem.ImageKey = "Graph2"
        lvItem.SubItems.AddRange(New String() {"Columna2", "Columna3"})

        lvItem = ListView.Items.Add("ListViewItem3")
        lvItem.ImageKey = "Graph3"
        lvItem.SubItems.AddRange(New String() {"Columna2", "Columna3"})
    End Sub

    Private Sub SetUpListViewColumns()

        ' TODO: agregue código para configurar las columnas de la vista de lista
        Dim lvColumnHeader As ColumnHeader

        ' La configuración del ancho de las columnas sólo se aplica a la vista actual, por lo que esta línea
        '  define explícitamente la ListView que se va a mostrar en la vista SmallIcon
        '  antes de configurar el ancho de columna
        SetView(View.SmallIcon)

        lvColumnHeader = ListView.Columns.Add("Columna1")
        ' Defina el ancho de las columnas de la vista SmallIcon en un valor lo suficientemente grande para que los elementos
        '  no se solapen
        ' Tenga en cuenta que la segunda y la tercera columna no aparecen en la vista SmallIcon,
        '  por lo que no es necesario definirlas para la vista SmallIcon
        lvColumnHeader.Width = 90

        ' Cambie la vista Details y defina el ancho de las columnas
        '  apropiado para la vista Details en un valor diferente al de la vista SmallIcon
        SetView(View.Details)

        ' La primera columna debe ser un poco más grande en la vista Details que en
        '  la vista SmallIcon, y Columna2 y Columna3 requieren que el tamaño esté definido explícitamente
        '  para la vista Details
        lvColumnHeader.Width = 100

        lvColumnHeader = ListView.Columns.Add("Columna2")
        lvColumnHeader.Width = 70

        lvColumnHeader = ListView.Columns.Add("Columna3")
        lvColumnHeader.Width = 70

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'Cerrar este formulario
        Me.Close()
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolBarToolStripMenuItem.Click
        'Alternar la visibilidad del elemento ToolStrip y el estado de activación del elemento de menú asociado
        ToolBarToolStripMenuItem.Checked = Not ToolBarToolStripMenuItem.Checked
        ToolStrip.Visible = ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatusBarToolStripMenuItem.Click
        'Alternar la visibilidad del elemento StatusStrip y el estado de activación del elemento de menú asociado
        StatusBarToolStripMenuItem.Checked = Not StatusBarToolStripMenuItem.Checked
        StatusStrip.Visible = StatusBarToolStripMenuItem.Checked
    End Sub

    'Cambiar si se muestra o no el panel de carpetas
    Private Sub ToggleFoldersVisible()
        'Alternar primero el estado de activación del elemento de menú asociado
        FoldersToolStripMenuItem.Checked = Not FoldersToolStripMenuItem.Checked

        'Cambiar el botón de la barra de herramientas de carpetas para que esté sincronizado
        FoldersToolStripButton.Checked = FoldersToolStripMenuItem.Checked

        ' Contraiga el panel que contiene TreeView.
        Me.SplitContainer.Panel1Collapsed = Not FoldersToolStripMenuItem.Checked
    End Sub

    Private Sub FoldersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FoldersToolStripMenuItem.Click
        ToggleFoldersVisible()
    End Sub

    Private Sub FoldersToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FoldersToolStripButton.Click
        ToggleFoldersVisible()
    End Sub

    Private Sub SetView(ByVal View As System.Windows.Forms.View)
        'Averiguar qué elemento de menú se debe activar
        Dim MenuItemToCheck As ToolStripMenuItem = Nothing
        Select Case View
            Case View.Details
                MenuItemToCheck = DetailsToolStripMenuItem
            Case View.LargeIcon
                MenuItemToCheck = LargeIconsToolStripMenuItem
            Case View.List
                MenuItemToCheck = ListToolStripMenuItem
            Case View.SmallIcon
                MenuItemToCheck = SmallIconsToolStripMenuItem
            Case View.Tile
                MenuItemToCheck = TileToolStripMenuItem
            Case Else
                Debug.Fail("Unexpected View")
                View = View.Details
                MenuItemToCheck = DetailsToolStripMenuItem
        End Select

        'Comprobar el elemento de menú adecuado y anular la selección de los demás bajo el menú Vistas
        For Each MenuItem As ToolStripMenuItem In ListViewToolStripButton.DropDownItems
            If MenuItem Is MenuItemToCheck Then
                MenuItem.Checked = True
            Else
                MenuItem.Checked = False
            End If
        Next

        'Por último, establecer la vista solicitada
        ListView.View = View
    End Sub

    Private Sub ListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListToolStripMenuItem.Click
        SetView(View.List)
    End Sub

    Private Sub DetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetailsToolStripMenuItem.Click
        SetView(View.Details)
    End Sub

    Private Sub LargeIconsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LargeIconsToolStripMenuItem.Click
        SetView(View.LargeIcon)
    End Sub

    Private Sub SmallIconsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SmallIconsToolStripMenuItem.Click
        SetView(View.SmallIcon)
    End Sub

    Private Sub TileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TileToolStripMenuItem.Click
        SetView(View.Tile)
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt"
        OpenFileDialog.ShowDialog(Me)

        Dim FileName As String = OpenFileDialog.FileName
        ' TODO: agregue el código para abrir el archivo
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt"
        SaveFileDialog.ShowDialog(Me)

        Dim FileName As String = SaveFileDialog.FileName
        ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
    End Sub

    Private Sub TreeView_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView.AfterSelect
        ' TODO: agregue el código para cambiar el contenido de listview basándose en el nodo seleccionado actualmente de treeview
        LoadListView()
    End Sub

End Class
