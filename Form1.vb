Public Class Form1

    ' Number of kana
    Private Const KANA_SIZE As Integer = 46
    Private Const KANA_DAKUTEN_SIZE As Integer = 25
    Private Const KANA_COMBO_SIZE As Integer = 33

    ' Choice of kana
    Private Const HIRAGANA As Integer = 0
    Private Const HIRAGANA_DAKUTEN As Integer = 1
    Private Const HIRAGANA_COMBO As Integer = 2
    Private Const KATAKANA As Integer = 3
    Private Const KATAKANA_DAKUTEN As Integer = 4
    Private Const KATAKANA_COMBO As Integer = 5
    Private Const KATAKANA_EXTENDED As Integer = 6

    ' Current selection
    Dim kanaType As Integer = HIRAGANA

    ' Current kana used
    Private hiraganaEnabled As Boolean = False
    Private hiraganaDakutenEnabled As Boolean = False
    Private hiraganaComboEnabled As Boolean = False
    Private katakanaEnabled As Boolean = False
    Private katakanaDakutenEnabled As Boolean = False
    Private katakanaComboEnabled As Boolean = False
    Private katakanaExtendedEnabled As Boolean = False

    ' List of all hiragana
    ReadOnly hiraganaTable As New List(Of (Kana As String, Transcription As String, Success As Integer)) From {
        ("あ", "a", 0),
        ("い", "i", 0),
        ("う", "u", 0),
        ("え", "e", 0),
        ("お", "o", 0),
        ("か", "ka", 0),
        ("き", "ki", 0),
        ("く", "ku", 0),
        ("け", "ke", 0),
        ("こ", "ko", 0),
        ("さ", "sa", 0),
        ("し", "shi", 0),
        ("す", "su", 0),
        ("せ", "se", 0),
        ("そ", "so", 0),
        ("た", "ta", 0),
        ("ち", "chi", 0),
        ("つ", "tsu", 0),
        ("て", "te", 0),
        ("と", "to", 0),
        ("な", "na", 0),
        ("に", "ni", 0),
        ("ぬ", "nu", 0),
        ("ね", "ne", 0),
        ("の", "no", 0),
        ("は", "ha", 0),
        ("ひ", "hi", 0),
        ("ふ", "fu", 0),
        ("へ", "he", 0),
        ("ほ", "ho", 0),
        ("ま", "ma", 0),
        ("み", "mi", 0),
        ("む", "mu", 0),
        ("め", "me", 0),
        ("も", "mo", 0),
        ("や", "ya", 0),
        ("ゆ", "yu", 0),
        ("よ", "yo", 0),
        ("ら", "ra", 0),
        ("り", "ri", 0),
        ("る", "ru", 0),
        ("れ", "re", 0),
        ("ろ", "ro", 0),
        ("わ", "wa", 0),
        ("を", "wo", 0),
        ("ん", "n", 0)
    }
    ReadOnly hiraganaDakutenTable As New List(Of (Kana As String, Transcription As String, Success As Integer)) From {
        ("が", "ga", 0),
        ("ぎ", "gi", 0),
        ("ぐ", "gu", 0),
        ("げ", "ge", 0),
        ("ご", "go", 0),
        ("ざ", "za", 0),
        ("じ", "ji", 0),
        ("ず", "zu", 0),
        ("ぜ", "ze", 0),
        ("ぞ", "zo", 0),
        ("だ", "da", 0),
        ("ぢ", "ji", 0),
        ("づ", "zu", 0),
        ("で", "de", 0),
        ("ど", "do", 0),
        ("ば", "ba", 0),
        ("び", "bi", 0),
        ("ぶ", "bu", 0),
        ("べ", "be", 0),
        ("ぼ", "bo", 0),
        ("ぱ", "pa", 0),
        ("ぴ", "pi", 0),
        ("ぷ", "pu", 0),
        ("ぺ", "pe", 0),
        ("ぽ", "po", 0)
    }
    ReadOnly hiraganaComboTable As New List(Of (Kana As String, Transcription As String, Success As Integer)) From {
        ("きゃ", "kya", 0),
        ("きゅ", "kyu", 0),
        ("きょ", "kyo", 0),
        ("ぎゃ", "gya", 0),
        ("ぎゅ", "gyu", 0),
        ("ぎょ", "gyo", 0),
        ("しゃ", "sha", 0),
        ("しゅ", "shu", 0),
        ("しょ", "sho", 0),
        ("じゃ", "ja", 0),
        ("じゅ", "ju", 0),
        ("じょ", "jo", 0),
        ("ちゃ", "cha", 0),
        ("ちゅ", "chu", 0),
        ("ちょ", "cho", 0),
        ("にゃ", "nya", 0),
        ("にゅ", "nyu", 0),
        ("にょ", "nyo", 0),
        ("ひゃ", "hya", 0),
        ("ひゅ", "hyu", 0),
        ("ひょ", "hyo", 0),
        ("びゃ", "bya", 0),
        ("びゅ", "byu", 0),
        ("びょ", "byo", 0),
        ("ぴゃ", "pya", 0),
        ("ぴゅ", "pyu", 0),
        ("ぴょ", "pyo", 0),
        ("みゃ", "mya", 0),
        ("みゅ", "myu", 0),
        ("みょ", "myo", 0),
        ("りゃ", "rya", 0),
        ("りゅ", "ryu", 0),
        ("りょ", "ryo", 0)
    }

    ' List of all katakana
    ReadOnly katakanaTable As New List(Of (Kana As String, Transcription As String, Success As Integer)) From {
        ("ア", "a", 0),
        ("イ", "i", 0),
        ("ウ", "u", 0),
        ("エ", "e", 0),
        ("オ", "o", 0),
        ("カ", "ka", 0),
        ("キ", "ki", 0),
        ("ク", "ku", 0),
        ("ケ", "ke", 0),
        ("コ", "ko", 0),
        ("サ", "sa", 0),
        ("シ", "shi", 0),
        ("ス", "su", 0),
        ("セ", "se", 0),
        ("ソ", "so", 0),
        ("タ", "ta", 0),
        ("チ", "chi", 0),
        ("ツ", "tsu", 0),
        ("テ", "te", 0),
        ("ト", "to", 0),
        ("ナ", "na", 0),
        ("ニ", "ni", 0),
        ("ヌ", "nu", 0),
        ("ネ", "ne", 0),
        ("ノ", "no", 0),
        ("ハ", "ha", 0),
        ("ヒ", "hi", 0),
        ("フ", "fu", 0),
        ("ヘ", "he", 0),
        ("ホ", "ho", 0),
        ("マ", "ma", 0),
        ("ミ", "mi", 0),
        ("ム", "mu", 0),
        ("メ", "me", 0),
        ("モ", "mo", 0),
        ("ヤ", "ya", 0),
        ("ユ", "yu", 0),
        ("ヨ", "yo", 0),
        ("ラ", "ra", 0),
        ("リ", "ri", 0),
        ("ル", "ru", 0),
        ("レ", "re", 0),
        ("ロ", "ro", 0),
        ("ワ", "wa", 0),
        ("ヲ", "wo", 0),
        ("ン", "n", 0)
    }
    ReadOnly katakanaDakutenTable As New List(Of (Kana As String, Transcription As String, Success As Integer)) From {
        ("ガ", "ga", 0),
        ("ギ", "gi", 0),
        ("グ", "gu", 0),
        ("ゲ", "ge", 0),
        ("ゴ", "go", 0),
        ("ザ", "za", 0),
        ("ジ", "ji", 0),
        ("ズ", "zu", 0),
        ("ゼ", "zo", 0),
        ("ゾ", "zo", 0),
        ("ダ", "da", 0),
        ("ヂ", "ji", 0),
        ("ヅ", "zu", 0),
        ("デ", "de", 0),
        ("ド", "do", 0),
        ("バ", "ba", 0),
        ("ビ", "bi", 0),
        ("ブ", "bu", 0),
        ("ベ", "be", 0),
        ("ボ", "bo", 0),
        ("パ", "pa", 0),
        ("ピ", "pi", 0),
        ("プ", "pu", 0),
        ("ペ", "pe", 0),
        ("ポ", "po", 0)
    }
    ReadOnly katakanaComboTable As New List(Of (Kana As String, Transcription As String, Success As Integer)) From {
        ("キャ", "kya", 0),
        ("キュ", "kyu", 0),
        ("キョ", "kyo", 0),
        ("ギャ", "gya", 0),
        ("ギュ", "gyu", 0),
        ("ギョ", "gyo", 0),
        ("シャ", "sha", 0),
        ("シュ", "shu", 0),
        ("ショ", "sho", 0),
        ("ジャ", "ja", 0),
        ("ジュ", "ju", 0),
        ("ジョ", "jo", 0),
        ("チャ", "cha", 0),
        ("チュ", "chu", 0),
        ("チョ", "cho", 0),
        ("ニャ", "nya", 0),
        ("ニュ", "nyu", 0),
        ("ニョ", "nyo", 0),
        ("ヒャ", "hya", 0),
        ("ヒュ", "hyu", 0),
        ("ヒョ", "hyo", 0),
        ("ビャ", "bya", 0),
        ("ビュ", "byu", 0),
        ("ビョ", "byo", 0),
        ("ピャ", "pya", 0),
        ("ピュ", "pyu", 0),
        ("ピョ", "pyo", 0),
        ("ミャ", "mya", 0),
        ("ミュ", "myu", 0),
        ("ミョ", "myo", 0),
        ("リャ", "rya", 0),
        ("リュ", "ryu", 0),
        ("リョ", "ryo", 0)
    }

    ' Random choice of kana
    Dim rand As Integer

    Private Function GetKanaTable() As List(Of (Kana As String, Transcription As String, Success As Integer))

        Dim table As New List(Of (Kana As String, Transcription As String, Success As Integer))()

        If hiraganaEnabled Then
            table.AddRange(hiraganaTable)
        End If

        If hiraganaDakutenEnabled Then
            table.AddRange(hiraganaDakutenTable)
        End If

        If hiraganaComboEnabled Then
            table.AddRange(hiraganaComboTable)
        End If

        If katakanaEnabled Then
            table.AddRange(katakanaTable)
        End If

        If katakanaDakutenEnabled Then
            table.AddRange(katakanaDakutenTable)
        End If

        If katakanaComboEnabled Then
            table.AddRange(katakanaComboTable)
        End If

        If katakanaExtendedEnabled Then

        End If

        Return table

    End Function

    Private Sub RandomKana()

        Dim table = GetKanaTable()
        rand = Int(Rnd() * table.Count)
        KanaOutput.Text = table(rand).Kana

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set the default selector on hiragana
        KanaSelector.SetItemChecked(0, True)
        hiraganaEnabled = True

        ' Initialize the random-number generator
        Randomize()

        ' Generate the first kana
        RandomKana()

    End Sub

    Private Sub NextKana()

        ' Reset the timer
        TimerNextKana.Enabled = False

        ' Reset to default color
        AnswerInput.ForeColor = Color.Black
        KanaOutput.ForeColor = Color.Black

        ' Empty the input field
        AnswerInput.Text = ""

        ' Generate the next kana
        RandomKana()

    End Sub

    Private Sub DisplayCorrection()
        AnswerInput.Text = GetKanaTable(rand).Transcription
    End Sub

    Private Sub DisplaySuccessRate()
        Dim table = GetKanaTable()
        Dim successRate As Integer = table(rand).Success

        For index = 1 To successRate
            Controls.Find("Success" + index.ToString(), True)(0).BackColor = Color.Cyan
        Next

    End Sub

    Private Sub AnswerInput_KeyDown(sender As Object, e As KeyEventArgs) Handles AnswerInput.KeyDown

        ' Cannot valid if answer is empty
        If AnswerInput.Text = "" Then
            Exit Sub
        End If

        ' When Enter is press on the input field
        If e.KeyCode = Keys.Enter Then
            ' If the answer is correct
            If AnswerInput.Text = GetKanaTable(rand).Transcription Then
                AnswerInput.ForeColor = Color.Cyan
                KanaOutput.ForeColor = Color.Cyan

                ' Increase success
                Dim successRate = GetKanaTable(rand).Success
                GetKanaTable(rand) = (GetKanaTable(rand).Kana, GetKanaTable(rand).Transcription, successRate + 1)

            Else
                AnswerInput.ForeColor = Color.Salmon
                KanaOutput.ForeColor = Color.Salmon

                ' Decrease success
                Dim successRate = GetKanaTable(rand).Success
                GetKanaTable(rand) = (GetKanaTable(rand).Kana, GetKanaTable(rand).Transcription, successRate - 1)

                ' Show the correction 
                DisplayCorrection()

            End If

            ' Launch the delay of 500ms
            TimerNextKana.Enabled = True

        End If

    End Sub

    Private Sub TimerNextKana_Tick(sender As Object, e As EventArgs) Handles TimerNextKana.Tick

        ' Generate the next kana
        NextKana()

    End Sub

    Private Sub KanaSelector_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles KanaSelector.ItemCheck

        ' Cannot disable the last item
        If e.NewValue = CheckState.Unchecked Then
            If KanaSelector.CheckedItems.Count = 1 Then
                e.NewValue = e.CurrentValue
            End If
        End If

    End Sub

    Private Sub KanaSelector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KanaSelector.SelectedIndexChanged

        ' Hiragana without dakuten
        If KanaSelector.GetItemCheckState(HIRAGANA) = CheckState.Checked Then
            hiraganaEnabled = True
        Else
            hiraganaEnabled = False
        End If

        ' Dakuten hiragana
        If KanaSelector.GetItemCheckState(1) = CheckState.Checked Then
            hiraganaDakutenEnabled = True
        Else
            hiraganaDakutenEnabled = False
        End If

        ' Combo hiragana
        If KanaSelector.GetItemCheckState(HIRAGANA_COMBO) = CheckState.Checked Then
            hiraganaComboEnabled = True
        Else
            hiraganaComboEnabled = False
        End If

        ' Katakana without dakuten
        If KanaSelector.GetItemCheckState(KATAKANA) = CheckState.Checked Then
            katakanaEnabled = True
        Else
            katakanaEnabled = False
        End If

        ' Dakuten katakana
        If KanaSelector.GetItemCheckState(KATAKANA_DAKUTEN) = CheckState.Checked Then
            katakanaDakutenEnabled = True
        Else
            katakanaDakutenEnabled = False
        End If

        ' Combo katakana
        If KanaSelector.GetItemCheckState(KATAKANA_COMBO) = CheckState.Checked Then
            katakanaComboEnabled = True
        Else
            katakanaComboEnabled = False
        End If

        ' Katakana extended table
        If KanaSelector.GetItemCheckState(KATAKANA_EXTENDED) = CheckState.Checked Then
            katakanaExtendedEnabled = True
        Else
            katakanaExtendedEnabled = False
        End If

        NextKana()
        AnswerInput.Focus()
    End Sub
End Class
