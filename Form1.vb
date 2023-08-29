Imports System.Data

Imports Microsoft.VisualBasic.FileIO

 

Public Class BookStoreForm

 

    ' Declare DataTable to hold book data

    Private bookData As New DataTable

 

    Private Sub BookStoreForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Initialize DataTable columns

        bookData.Columns.Add("Title")

        bookData.Columns.Add("Author")

        bookData.Columns.Add("Stock")

    End Sub





    ' Call procedure to load data from CSV into DataTable LoadButton.Click





    ' Call procedure to filter the book list on SearchTextBox.TextChanged





    ' Call procedure to display book details on BookListBox.SelectedIndexChanged





    Private Sub LoadCSVData()

        ' Clear any existing data

        bookData.Clear()

       

        ' Initialize TextFieldParser and read CSV file

        Using parser As New TextFieldParser("BookData.csv")

            parser.TextFieldType = FieldType.Delimited

            parser.SetDelimiters(",")

            While Not parser.EndOfData

                ' Read fields and add row to DataTable

                Dim fields = parser.ReadFields()

                bookData.Rows.Add(fields)

            End While

        End Using

       

        ' Fill the book list

        FillBookList()

    End Sub

 

    Private Sub FillBookList()

        ' Clear and populate the ListBox from DataTable

        BookListBox.Items.Clear()

        For Each row As DataRow In bookData.Rows

            BookListBox.Items.Add(row("Title").ToString())

        Next

    End Sub

 

    Private Sub FilterBookList()

        ' Filter ListBox items based on search criteria

        Dim filter = SearchTextBox.Text

        BookListBox.Items.Clear()

        For Each row As DataRow In bookData.Rows

            If row("Title").ToString().Contains(filter) Then

                BookListBox.Items.Add(row("Title").ToString())

            End If

        Next

    End Sub

 

    Private Sub DisplayBookDetails()

        ' Display book details in DetailLabel

        Dim selectedTitle = BookListBox.SelectedItem

        If selectedTitle IsNot Nothing Then

            For Each row As DataRow In bookData.Rows

                If row("Title").ToString() = selectedTitle.ToString() Then

                    DetailLabel.Text = $"Title: {row("Title")}" & vbCrLf & $"Author: {row("Author")}" & vbCrLf & $"Stock: {row("Stock")}"
                    Exit For

                End If

            Next

        End If

    End Sub

 

End Class