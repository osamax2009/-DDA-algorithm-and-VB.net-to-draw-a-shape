Public Class Form1


    Private Sub drawLine(bmp As Bitmap, x1 As Double, y1 As Double, x2 As Double, y2 As Double)
        Dim ax, ay As Double
        ax = Math.Abs(x2 - x1)

        ay = Math.Abs(y2 - y1)

        Dim len As Double

        If ax > ay Then
            len = ax
        Else
            len = ay
        End If

        Console.WriteLine(("len is : {0}"), len)

        Dim xinc As Double = (ax / len)
        Dim yinc As Double = (ay / len)

        Dim x, y As Double
        x = x1
        y = y1

        bmp.SetPixel(Int(x), Int(y), Color.Blue)


        For i As Integer = 0 To len
            x = x + xinc
            y = y + yinc

            Console.WriteLine(("points x , y : {0}, {1}"), x, y)

            bmp.SetPixel(Int(x), Int(y), Color.Blue)

        Next







    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim btm = New System.Drawing.Bitmap(PictureBox1.Width, PictureBox1.Height)

        drawLine(btm, 100, 100, 150, 200)
        drawLine(btm, 150, 200, 200, 200)
        drawLine(btm, 100, 100, 200, 200)
        PictureBox1.Image = btm


    End Sub
End Class
