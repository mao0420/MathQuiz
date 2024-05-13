Public Class Form1

    ' randomizerと呼ばれるRandomオブジェクトを作成し、乱数を生成する。
    Private randomizer As New Random

    ' この変数には足し算問題の数値が格納される。 
    Private addend1 As Integer
    Private addend2 As Integer

    ' この変数には引き算問題の数値が格納される。
    Private minuend As Integer
    Private subtrahend As Integer

    ' この変数には掛け算問題の数値が格納される。
    Private multiplicand As Integer
    Private multiplier As Integer

    ' この変数には割り算問題の数値が格納される。
    Private dividend As Integer
    Private divisor As Integer

    Public Sub StartTheQuiz()
        ' 足し算問題用に0～50の範囲で２つの乱数を生成する。
        ' それぞれ生成した値を変数 'addend1' と 'addend2' に格納する。
        addend1 = randomizer.Next(51)
        addend2 = randomizer.Next(51)

        ' 生成された２つの乱数を文字列に変換し、
        ' ラベルとして表示できるようにする。
        plusLeftLabel.Text = addend1.ToString()
        plusRightLabel.Text = addend2.ToString()

        ' 'sum'はNumericUpDownコントロールの名前である。
        ' 'sum'に0を代入し、初期化する。
        sum.Value = 0

        ' 引き算問題用に1～100の範囲で乱数を生成する。
        ' 答えが-の値にならないよう、1～上記で生成した乱数の値で乱数を生成。
        minuend = randomizer.Next(1, 101)
        subtrahend = randomizer.Next(1, minuend)

        ' 生成された２つの乱数を文字列に変換し、
        ' ラベルとして表示できるようにする。
        minusLeftLabel.Text = minuend.ToString()
        minusRightLabel.Text = subtrahend.ToString()

        ' 'difference'はNumericUpDownコントロールの名前である。
        ' 'difference'に0を代入し、初期化する。
        difference.Value = 0

        ' 掛け算問題用に2～10の範囲で２つの乱数を生成する。
        multiplicand = randomizer.Next(2, 11)
        multiplier = randomizer.Next(2, 11)

        ' 生成された２つの乱数を文字列に変換し、
        ' ラベルとして表示できるようにする。
        timesLeftLabel.Text = multiplicand.ToString()
        timesRightLabel.Text = multiplier.ToString()

        ' 'product'はNumericUpDownコントロールの名前である。
        ' 'product'に0を代入し、初期化する。
        product.Value = 0

        ' 割り算問題用に2～10の範囲で２つの乱数を生成する。
        ' 生成した２つの乱数を掛けた値が左辺の値となる。
        divisor = randomizer.Next(2, 11)
        Dim temporaryQuotient As Integer = randomizer.Next(2, 11)
        dividend = divisor * temporaryQuotient

        ' 生成された２つの値を文字列に変換し、
        ' ラベルとして表示できるようにする。
        dividedLeftLabel.Text = dividend.ToString()
        dividedRightLabel.Text = divisor.ToString()

        ' 'quotient'はNumericUpDownコントロールの名前である。
        ' 'quotient'に0を代入し、初期化する。
        quotient.Value = 0
    End Sub

    ' スタートボタンを押すと、StartTheQuiz()メソッドを呼び出す。
    Private Sub startButton_Click() Handles startButton.Click
        StartTheQuiz()
        startButton.Enabled = False
    End Sub

End Class
