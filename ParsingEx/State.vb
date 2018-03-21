Public Class State : Implements ICloneable, IEnumerator(Of Char)

    Private _code As String
    Private _disposed As Boolean
    Private _current_pos As Integer

    Public ReadOnly Property CurrentPosition As Integer
        Get
            Return Me._current_pos
        End Get
    End Property

    Public ReadOnly Property Code As String
        Get
            Return Me._code
        End Get
    End Property

    Public Sub New(code As String)
        Me._code = code
        Me.Reset()
    End Sub

    Protected Sub New(base As State)
        Me._code = base._code
        Me._current_pos = base._current_pos
    End Sub

    Public ReadOnly Property Current As Char Implements IEnumerator(Of Char).Current
        Get
            Return Me._code(_current_pos)
        End Get
    End Property

    Private ReadOnly Property IEnumerator_Current As Object Implements IEnumerator.Current
        Get
            Return Me.Current
        End Get
    End Property

    Public Sub Reset() Implements IEnumerator.Reset
        Me._current_pos = 0
    End Sub

    Public Function Clone() As Object Implements ICloneable.Clone
        Return New State(Me)
    End Function

    Public Function MoveNext() As Boolean Implements IEnumerator.MoveNext
        Me._current_pos += 1
        Return Me._current_pos >= Me._code.Length
    End Function

    Public Sub Dispose() Implements IDisposable.Dispose
    End Sub

End Class
