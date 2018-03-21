Namespace CST
    Public MustInherit Class Item : Implements IEnumerable(Of Item)

        Private Shared _empty As IEnumerable(Of Item)
        Public Shared ReadOnly Property Empty As IEnumerable(Of Item)
            Get
                If _empty Is Nothing Then _empty = New List(Of Item)
                Return _empty
            End Get
        End Property

        Public MustOverride ReadOnly Property Begin As Integer
        Public MustOverride ReadOnly Property Lenght As Integer
        Public MustOverride ReadOnly Property Content As String

        Public Overridable ReadOnly Property Source As Parser
            Get
                Return Me._source
            End Get
        End Property

        Protected _source As Parser
        Protected _state As State

        Public Sub New(source As Parser, state As State)
            Me._source = source
            Me._state = state.Clone
        End Sub

        Public MustOverride Function GetEnumerator() As IEnumerator(Of Item) Implements IEnumerable(Of Item).GetEnumerator

        Private Function IEnumerable_GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
            Return Me.GetEnumerator
        End Function

    End Class

End Namespace
