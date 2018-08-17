' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    Private Sub ClickMeButton_Click(sender As Object, e As RoutedEventArgs) Handles ClickMeButton.Click
        ResultTextBlock.Text = "Hello World!"

    End Sub
End Class
