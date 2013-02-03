Public Class Form1
    Dim originaltext As String              'string az eredeti szövegnek
    Dim szokozesekezetnelkultext As String  'string a Replace(karaktercserék) utáni szövegnek
    Dim csupanagybetutext As String         'string a csupa nagy betűs szövegnek

    Dim csupanagybetutexttomb() As Char     'karaktertömb a "nyílt" szövegnek

    Dim kulcs As String                     'sztring a kulcsnak

    Dim kulcsszoveg As String               'sztring a kulcs segítségével előállított karaktersorozatnak ("kulcsszöveg")
    Dim kulcsszovegtomb() As Char           'karaktertömb a kulcsszövegnek
    Dim tablaszoveg As String               'sztring a Vigener táblának
    Dim tablaszovegtomb() As Char           'karaktertömn a Vigener táblának



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'a Vigener tábla beolvasása RichTextBox-ba, funkcionálisan több szerepe nincs
        RichTextBox1.LoadFile("vtabla.dat", RichTextBoxStreamType.PlainText)
        tablaszoveg = RichTextBox1.Text
        tabla123.Text = tablaszoveg

        tablaszovegtomb = tablaszoveg.ToCharArray 'a sztring átalakítása karaktertömbbe
        'tömb elemek ellenőrzése:
        pos.Text = tablaszovegtomb(0) + " " + tablaszovegtomb(27) + " " + tablaszovegtomb(54) + " " + tablaszovegtomb(81)

    End Sub

    Private Sub szokozesekezetnelkulButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles szokozesekezetnelkulButton.Click

        'a magyar ékezetes karakterek és a szóköz cseréje, más írásjelek használatát itt nem feltételezzük
        originaltext = originalTextBox.Text
        originaltext = Replace(originaltext, "á", "a")
        originaltext = Replace(originaltext, "é", "e")
        originaltext = Replace(originaltext, "í", "i")
        originaltext = Replace(originaltext, "ó", "o")
        originaltext = Replace(originaltext, "ö", "o")
        originaltext = Replace(originaltext, "ő", "o")
        originaltext = Replace(originaltext, "ú", "u")
        originaltext = Replace(originaltext, "ü", "u")
        originaltext = Replace(originaltext, "ű", "u")

        originaltext = Replace(originaltext, "Á", "a")
        originaltext = Replace(originaltext, "É", "e")
        originaltext = Replace(originaltext, "Í", "i")
        originaltext = Replace(originaltext, "Ó", "o")
        originaltext = Replace(originaltext, "Ö", "o")
        originaltext = Replace(originaltext, "Ő", "o")
        originaltext = Replace(originaltext, "Ú", "u")
        originaltext = Replace(originaltext, "Ü", "u")
        originaltext = Replace(originaltext, "Ű", "u")

        originaltext = Replace(originaltext, " ", "")

        'kiírás ékezetek és szóköz nélkül:
        szokozesekezetnelkultext = originaltext
        szokozesekezetnelkulTextBox.Text = szokozesekezetnelkultext

    End Sub

    Private Sub csupanagybetuButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles csupanagybetuButton.Click
        'átalakítás csupa nagybetűsre:
        csupanagybetutext = UCase(szokozesekezetnelkultext)
        csupanagybetuTextBox.Text = csupanagybetutext

        csupanagybetutexttomb = csupanagybetutext.ToCharArray 'nyílt szöveg

    End Sub

    Private Sub kulcsszovegButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kulcsszovegButton.Click

        'kulcsszöveg előállítása:
        Dim kulcshossza As Integer
        Dim csupanagybetutexthossza As Integer
        kulcs = kulcsTextBox.Text
        kulcshossza = kulcs.Length
        csupanagybetutext = csupanagybetuTextBox.Text
        csupanagybetutexthossza = csupanagybetutext.Length
        
        Dim i As Integer
        Dim e1, v1 As Integer

        e1 = Int(csupanagybetutexthossza / kulcshossza)
        v1 = csupanagybetutexthossza - (e1 * kulcshossza)

        For i = 1 To e1
            kulcsszovegTextBox.Text = kulcsszovegTextBox.Text + kulcs
        Next
        kulcsszovegTextBox.Text = kulcsszovegTextBox.Text + Mid(kulcs, 1, v1)

        kulcsszoveg = kulcsszovegTextBox.Text

        kulcsszovegtomb = kulcsszoveg.ToCharArray 'kulcsszöveg karaktertömbbe

    End Sub

    Private Sub kodolButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kodolButton.Click

        'Vigener kód előállítása:
        Dim nyiltszovegmeret As Integer
        Dim kulcsszovegmeret As Integer
        nyiltszovegmeret = csupanagybetutexttomb.Length
        kulcsszovegmeret = kulcsszovegtomb.Length
        Dim sorszamok(nyiltszovegmeret) As Integer
        Dim oszlopszamok(kulcsszovegmeret) As Integer

        For k = 0 To nyiltszovegmeret - 1
            For j = 0 To 701 Step 27 'az eredeti tábla 26 soros és 27 oszlopos: 26 db karakter + 1 karakter, ez a soremelés karakter
                If csupanagybetutexttomb(k) = tablaszovegtomb(j) Then
                    sorszamok(k) = Int(j / 27) 'hányadik sor?
                    kodoltTextBox1.Text = kodoltTextBox1.Text + CStr(sorszamok(k)) + " "
                End If
            Next

        Next

        For k1 = 0 To kulcsszovegmeret - 1
            For j1 = 0 To 26
                If kulcsszovegtomb(k1) = tablaszovegtomb(j1) Then
                    oszlopszamok(k1) = j1 'hányadik oszlop?
                    kodoltTextBox2.Text = kodoltTextBox2.Text + CStr(oszlopszamok(k1)) + " "
                End If
            Next

        Next

        'maga a kód eéőállítása
        For k2 = 0 To nyiltszovegmeret - 1
            kodoltszovegTextBox.Text = kodoltszovegTextBox.Text + tablaszovegtomb(oszlopszamok(k2) * 27 + sorszamok(k2))

        Next

    End Sub
End Class
