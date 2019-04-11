Imports System.Collections.Generic
Imports System.Text
Imports System.ComponentModel

Namespace Telerik.Examples.WinControls.PropertyGrid.Validation
    Public Enum Gender
        Male
        Female
    End Enum

    Public Class PersonInfo
        Private m_name As String
        Private m_family As String
        Private m_gender As Gender
        Private m_age As Integer
        Private m_city As String
        Private m_country As String
        Private m_email As String
        Private m_phone As String

        <Category("Personal Information")> _
        <Description("Employee name cannot be blank!")> _
        Public Property Name() As String
            Get
                Return m_name
            End Get
            Set(ByVal value As String)
                m_name = value
            End Set
        End Property

        <Category("Personal Information")> _
        <Description("Employee family cannot be blank!")> _
        Public Property Family() As String
            Get
                Return m_family
            End Get
            Set(ByVal value As String)
                m_family = value
            End Set
        End Property

        <Category("Personal Information")> _
        Public Property Gender() As Gender
            Get
                Return m_gender
            End Get
            Set(ByVal value As Gender)
                m_gender = value
            End Set
        End Property

        <Category("Personal Information")> _
        <Description("Employee age can be between 18 and 56 years.")> _
        Public Property Age() As Integer
            Get
                Return m_age
            End Get
            Set(ByVal value As Integer)
                m_age = value
            End Set
        End Property

        <Category("Address")> _
        <Description("This field represents the city where the employee lives and cannot be blank.")> _
        Public Property City() As String
            Get
                Return m_city
            End Get
            Set(ByVal value As String)
                m_city = value
            End Set
        End Property

        <Category("Address")> _
        <Description("This field represents the country where the employee lives and cannot be blank.")> _
        Public Property Country() As String
            Get
                Return m_country
            End Get
            Set(ByVal value As String)
                m_country = value
            End Set
        End Property

        <Category("Address")> _
        <Description("The EMail field should contain a valid email.")> _
        Public Property EMail() As String
            Get
                Return m_email
            End Get
            Set(ByVal value As String)
                m_email = value
            End Set
        End Property

        <Category("Address")> _
        <Description("The Phone field should contain a valid us style phone number.")> _
        Public Property Phone() As String
            Get
                Return m_phone
            End Get
            Set(ByVal value As String)
                m_phone = value
            End Set
        End Property
    End Class
End Namespace
