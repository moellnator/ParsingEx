Namespace CST
    Public Class Terminating : Inherits Item

        Public Sub New(source As Parser, state As State)
            MyBase.New(source, state)
        End Sub

        Public Overrides ReadOnly Property Begin As Integer
            Get
                Return Me._state.CurrentPosition
            End Get
        End Property

        Public Overrides ReadOnly Property Lenght As Integer
            Get
                Return 1
            End Get
        End Property

        Public Overrides ReadOnly Property Content As String
            Get
                Return Me._state.Current
            End Get
        End Property

        Public Overrides Function GetEnumerator() As IEnumerator(Of Item)
            Return Empty.GetEnumerator
        End Function

    End Class

End Namespace
