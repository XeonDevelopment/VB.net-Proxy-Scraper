Imports System.Text
Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If ChkChecked.Checked Then

            If ChkHttp.Checked Then

                If ChkAnonAnon.Checked Then
                    Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://proxyscrape.com/api?request=getproxies&proxytype=http&timeout=" + txtTimeout.Text + "&country=all&ssl=yes&anonymity=anonymous")
                    Dim response As System.Net.HttpWebResponse = request.GetResponse
                    Dim reader As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream)
                    Dim readcode As String = reader.ReadToEnd
                    Dim checker As New System.Text.RegularExpressions.Regex("[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}:[0-9]{1,5}")
                    Dim right As MatchCollection = checker.Matches(readcode)
                    For Each itemcode As Match In right
                        ListBox1.Items.Add(itemcode)
                    Next
                End If

                If ChkAnonElite.Checked Then
                    Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://proxyscrape.com/api?request=getproxies&proxytype=http&timeout=" + txtTimeout.Text + "&country=all&ssl=yes&anonymity=elite")
                    Dim response As System.Net.HttpWebResponse = request.GetResponse
                    Dim reader As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream)
                    Dim readcode As String = reader.ReadToEnd
                    Dim checker As New System.Text.RegularExpressions.Regex("[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}:[0-9]{1,5}")
                    Dim right As MatchCollection = checker.Matches(readcode)
                    For Each itemcode As Match In right
                        ListBox1.Items.Add(itemcode)
                    Next
                End If

                If ChkAnonTrans.Checked Then
                    Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://proxyscrape.com/api?request=getproxies&proxytype=http&timeout=" + txtTimeout.Text + "&country=all&ssl=yes&anonymity=elite")
                    Dim response As System.Net.HttpWebResponse = request.GetResponse
                    Dim reader As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream)
                    Dim readcode As String = reader.ReadToEnd
                    Dim checker As New System.Text.RegularExpressions.Regex("[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}:[0-9]{1,5}")
                    Dim right As MatchCollection = checker.Matches(readcode)
                    For Each itemcode As Match In right
                        ListBox1.Items.Add(itemcode)
                    Next
                End If
            End If

            If ChkSocks4.Checked Then
                Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://proxyscrape.com/api?request=getproxies&proxytype=socks4&timeout=" + txtTimeout.Text + "country=all")
                Dim response As System.Net.HttpWebResponse = request.GetResponse
                Dim reader As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream)
                Dim readcode As String = reader.ReadToEnd
                Dim checker As New System.Text.RegularExpressions.Regex("[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}:[0-9]{1,5}")
                Dim right As MatchCollection = checker.Matches(readcode)
                For Each itemcode As Match In right
                    ListBox1.Items.Add(itemcode)
                Next
            End If

            If ChkSocks5.Checked Then
                Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://proxyscrape.com/api?request=getproxies&proxytype=socks5&timeout=" + txtTimeout.Text + "&country=all")
                Dim response As System.Net.HttpWebResponse = request.GetResponse
                Dim reader As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream)
                Dim readcode As String = reader.ReadToEnd
                Dim checker As New System.Text.RegularExpressions.Regex("[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}:[0-9]{1,5}")
                Dim right As MatchCollection = checker.Matches(readcode)
                For Each itemcode As Match In right
                    ListBox1.Items.Add(itemcode)
                Next
            End If

        End If

        If ChkUnchecked.Checked Then
            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://sslproxies24.blogspot.com/feeds/posts/default")
            Dim response As System.Net.HttpWebResponse = request.GetResponse
            Dim reader As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream)
            Dim readcode As String = reader.ReadToEnd
            Dim checker As New System.Text.RegularExpressions.Regex("[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}:[0-9]{1,5}")
            Dim right As MatchCollection = checker.Matches(readcode)
            For Each itemcode As Match In right
                ListBox1.Items.Add(itemcode)
            Next
            Dim request2 As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://proxyserverlist-24.blogspot.com/feeds/posts/default")
            Dim response2 As System.Net.HttpWebResponse = request2.GetResponse
            Dim reader2 As System.IO.StreamReader = New System.IO.StreamReader(response2.GetResponseStream)
            Dim readcode2 As String = reader2.ReadToEnd
            Dim checker2 As New System.Text.RegularExpressions.Regex("[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}:[0-9]{1,5}")
            Dim right2 As MatchCollection = checker2.Matches(readcode2)
            For Each itemcode2 As Match In right2
                ListBox1.Items.Add(itemcode2)
            Next

            Dim request3 As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://newfreshproxies-24.blogspot.com/feeds/posts/default")
            Dim response3 As System.Net.HttpWebResponse = request3.GetResponse
            Dim reader3 As System.IO.StreamReader = New System.IO.StreamReader(response3.GetResponseStream)
            Dim readcode3 As String = reader3.ReadToEnd
            Dim checker3 As New System.Text.RegularExpressions.Regex("[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}:[0-9]{1,5}")
            Dim right3 As MatchCollection = checker3.Matches(readcode3)
            For Each itemcode3 As Match In right3
                ListBox1.Items.Add(itemcode3)
            Next


            Dim request4 As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://www.vipsocks24.net/feeds/posts/default")
            Dim response4 As System.Net.HttpWebResponse = request4.GetResponse
            Dim reader4 As System.IO.StreamReader = New System.IO.StreamReader(response4.GetResponseStream)
            Dim readcode4 As String = reader4.ReadToEnd
            Dim checker4 As New System.Text.RegularExpressions.Regex("[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}:[0-9]{1,5}")
            Dim right4 As MatchCollection = checker4.Matches(readcode4)
            For Each itemcode4 As Match In right4
                ListBox1.Items.Add(itemcode4)
            Next


            Dim request5 As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://www.vipsocks24.net/feeds/posts/default")
            Dim response5 As System.Net.HttpWebResponse = request5.GetResponse
            Dim reader5 As System.IO.StreamReader = New System.IO.StreamReader(response5.GetResponseStream)
            Dim readcode5 As String = reader5.ReadToEnd
            Dim checker5 As New System.Text.RegularExpressions.Regex("[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}:[0-9]{1,5}")
            Dim right5 As MatchCollection = checker5.Matches(readcode5)
            For Each itemcode5 As Match In right5
                ListBox1.Items.Add(itemcode5)
            Next

            Dim request6 As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://www.live-socks.net/feeds/posts/default")
            Dim response6 As System.Net.HttpWebResponse = request6.GetResponse
            Dim reader6 As System.IO.StreamReader = New System.IO.StreamReader(response6.GetResponseStream)
            Dim readcode6 As String = reader6.ReadToEnd
            Dim checker6 As New System.Text.RegularExpressions.Regex("[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}:[0-9]{1,5}")
            Dim right6 As MatchCollection = checker6.Matches(readcode6)
            For Each itemcode6 As Match In right6
                ListBox1.Items.Add(itemcode6)
            Next

            Dim request7 As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://freesocks.blogspot.com/feeds/posts/default")
            Dim response7 As System.Net.HttpWebResponse = request7.GetResponse
            Dim reader7 As System.IO.StreamReader = New System.IO.StreamReader(response7.GetResponseStream)
            Dim readcode7 As String = reader7.ReadToEnd
            Dim checker7 As New System.Text.RegularExpressions.Regex("[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}:[0-9]{1,5}")
            Dim right7 As MatchCollection = checker7.Matches(readcode7)
            For Each itemcode7 As Match In right7
                ListBox1.Items.Add(itemcode7)
            Next

            Dim request8 As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://freesocks.blogspot.com/feeds/posts/default")
            Dim response8 As System.Net.HttpWebResponse = request8.GetResponse
            Dim reader8 As System.IO.StreamReader = New System.IO.StreamReader(response7.GetResponseStream)
            Dim readcode8 As String = reader7.ReadToEnd
            Dim checker8 As New System.Text.RegularExpressions.Regex("[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}:[0-9]{1,5}")
            Dim right8 As MatchCollection = checker8.Matches(readcode8)
            For Each itemcode8 As Match In right8
                ListBox1.Items.Add(itemcode8)
            Next
        End If



        MessageBox.Show("You got " + ListBox1.Items.Count.ToString + " Proxies")


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim S_W As IO.StreamWriter

        Dim itms() As String = {ListBox1.Items.ToString}

        Dim save As New SaveFileDialog
        Dim it As Integer
        save.Filter = "Proxy-List (*.txt)|*.txt|All Files (*.*)|*.*"
        save.CheckPathExists = True
        save.ShowDialog(Me)
        S_W = New IO.StreamWriter(save.FileName)
        For it = 0 To ListBox1.Items.Count - 1
            S_W.WriteLine(ListBox1.Items.Item(it))
        Next
        S_W.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
    End Sub
End Class
