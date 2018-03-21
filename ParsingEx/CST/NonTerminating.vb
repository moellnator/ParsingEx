Namespace CST
    Public Class NonTerminating : Inherits Item

        Protected _begin As Integer
        Protected _content As Integer
        Protected _length As Integer
        Protected _items As Item()

        Public Sub New(source As Parser, state As State, children As IEnumerable(Of Item))
            MyBase.New(source, state)
            Me._items = children.OrderBy(Function(c) c.Begin).ToArray
            Me._begin = children.First.Begin
            Me._length = children.Sum(Function(c) c.Lenght)
            Me._content = String.Join("", children.Select(Function(c) c.Content))
        End Sub

        Public Overrides ReadOnly Property Begin As Integer
            Get
                Return Me._begin
            End Get
        End Property

        Public Overrides ReadOnly Property Lenght As Integer
            Get
                Return Me._length
            End Get
        End Property

        Public Overrides ReadOnly Property Content As String
            Get
                Return Me._content
            End Get
        End Property

        Public Overrides Function GetEnumerator() As IEnumerator(Of Item)
            Return Me._items.GetEnumerator
        End Function
    End Class

End Namespace
