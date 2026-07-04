Imports System.Data.SqlClient
﻿Imports System.Configuration

Public Class Database
    Public Shared ReadOnly Property ConnectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MedicalDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"
    Public Shared Function GetConnectionString() As SqlConnection

        Return New SqlConnection(ConnectionString)
    End Function
End Class