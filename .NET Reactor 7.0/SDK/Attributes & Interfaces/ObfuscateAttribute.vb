<AttributeUsage((AttributeTargets.Delegate Or (AttributeTargets.Parameter Or (AttributeTargets.Interface Or (AttributeTargets.Event Or (AttributeTargets.Field Or (AttributeTargets.Property Or (AttributeTargets.Method Or (AttributeTargets.Enum Or (AttributeTargets.Struct Or (AttributeTargets.Class Or AttributeTargets.Assembly)))))))))), AllowMultiple:=True, Inherited:=False)> _
Public NotInheritable Class ObfuscationAttribute
    Inherits Attribute

    Public Property ApplyToMembers() As Boolean
        Get
            Return Me.m_applyToMembers
        End Get
        Set(ByVal value As Boolean)
            Me.m_applyToMembers = value
        End Set
    End Property

    Public Property Exclude() As Boolean
        Get
            Return Me.m_exclude
        End Get
        Set(ByVal value As Boolean)
            Me.m_exclude = value
        End Set
    End Property

    Public Property Feature() As String
        Get
            Return Me.m_feature
        End Get
        Set(ByVal value As String)
            Me.m_feature = value
        End Set
    End Property

    Public Property StripAfterObfuscation() As Boolean
        Get
            Return Me.m_strip
        End Get
        Set(ByVal value As Boolean)
            Me.m_strip = value
        End Set
    End Property

    Private m_applyToMembers As Boolean = True
    Private m_exclude As Boolean = True
    Private m_feature As String = "all"
    Private m_strip As Boolean = True
End Class

 

