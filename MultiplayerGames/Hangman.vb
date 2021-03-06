﻿Imports System.IO
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading

Public Class frmHangman

    Dim messageReceived As String
    Dim br As BinaryReader
    Dim tcpClient As TcpClient
    Dim bw As IO.BinaryWriter
    Dim isLeader As Boolean = False
    Private connection As Thread

    Private Sub frmHangman_onClose(sender As Object, e As EventArgs) Handles MyBase.Closed
        frmMain.Show()
    End Sub

    Private Sub frmHangman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tcpClient = New TcpClient
    End Sub

    Private Sub cmdConnect_Click(sender As Object, e As EventArgs) Handles cmdConnect.Click

        tcpClient.Connect("lycan.zone", 5000)

        bw = New IO.BinaryWriter(tcpClient.GetStream)


        If txtName.Text.Length = 8 Then
            txtName.Text = txtName.Text + " "
        End If
        bw.Write(txtName.Text + vbCrLf)
        readMessage()
        bw.Write("hang" + vbCrLf)
        connection = New Thread(AddressOf ThreadTask)
        connection.IsBackground = True
        connection.Start()

    End Sub

    Private Function readMessage() As String
        Dim bytes(tcpClient.ReceiveBufferSize) As Byte
        br = New BinaryReader(tcpClient.GetStream)
        br.Read(bytes, 0, CInt(tcpClient.ReceiveBufferSize))
        messageReceived = Encoding.UTF8.GetString(bytes)
        If (messageReceived.Contains("lead")) Then
            isLeader = True
        End If
        Return messageReceived
    End Function


    Private Sub ThreadTask()
        While readMessage() IsNot Nothing
            If messageReceived.Contains("lead") Then
                MsgBox("You are the leader of the game!")
            ElseIf messageReceived.Contains("welcome") Then
                MsgBox("Welcome player!")
            End If
        End While
    End Sub
End Class