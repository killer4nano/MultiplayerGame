﻿Imports System.IO
Imports System.Net.Sockets
Imports System.Text

Public Class frmHangman
    Private Sub frmHangman_Load(sender As Object, e As EventArgs) Handles MyBase.Closed
        frmMain.Show()
    End Sub

    Private Sub cmdConnect_Click(sender As Object, e As EventArgs) Handles cmdConnect.Click

        Dim tcpClient As New TcpClient

        tcpClient.Connect("lycan.zone", 5000)

        Dim bw As New IO.BinaryWriter(tcpClient.GetStream)
        If txtName.Text.Length = 8 Then
            txtName.Text = txtName.Text + " "
        End If
        bw.Write(txtName.Text + vbCrLf)
        Dim reader As New BinaryReader(tcpClient.GetStream)
        Dim bytes(tcpClient.ReceiveBufferSize) As Byte
        reader.Read(bytes, 0, CInt(tcpClient.ReceiveBufferSize))
        Dim returndata As String = Encoding.UTF8.GetString(bytes)
        MsgBox(returndata)
        tcpClient.Close()

    End Sub
End Class