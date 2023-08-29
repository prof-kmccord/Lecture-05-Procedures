<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookStoreForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        LoadButton = New Button()
        SearchTextBox = New TextBox()
        BookListBox = New ListBox()
        DetailLabel = New Label()
        SuspendLayout()
        ' 
        ' LoadButton
        ' 
        LoadButton.Location = New Point(297, 26)
        LoadButton.Name = "LoadButton"
        LoadButton.Size = New Size(119, 23)
        LoadButton.TabIndex = 0
        LoadButton.Text = "Load Books"
        LoadButton.UseVisualStyleBackColor = True
        ' 
        ' SearchTextBox
        ' 
        SearchTextBox.Location = New Point(55, 26)
        SearchTextBox.Name = "SearchTextBox"
        SearchTextBox.Size = New Size(236, 23)
        SearchTextBox.TabIndex = 1
        ' 
        ' BookListBox
        ' 
        BookListBox.FormattingEnabled = True
        BookListBox.ItemHeight = 15
        BookListBox.Location = New Point(55, 55)
        BookListBox.Name = "BookListBox"
        BookListBox.Size = New Size(361, 139)
        BookListBox.TabIndex = 2
        ' 
        ' DetailLabel
        ' 
        DetailLabel.AutoSize = True
        DetailLabel.Location = New Point(55, 210)
        DetailLabel.Name = "DetailLabel"
        DetailLabel.Size = New Size(127, 15)
        DetailLabel.TabIndex = 3
        DetailLabel.Text = "Addtional Book Details"
        ' 
        ' BookStoreForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DetailLabel)
        Controls.Add(BookListBox)
        Controls.Add(SearchTextBox)
        Controls.Add(LoadButton)
        Name = "BookStoreForm"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LoadButton As Button
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents BookListBox As ListBox
    Friend WithEvents DetailLabel As Label
End Class
