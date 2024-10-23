using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class QuizDisplayManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textOriginal; // �I���W�i�����͗p
    [SerializeField] private TextMeshProUGUI _textJapanese; // �������p
    [SerializeField] private TextMeshProUGUI _textRoman;    // ���[�}���p

    [SerializeField] private Color yetInputedCharColor = Color.white;
    [SerializeField] private Color doneInputedCharColor = Color.white;
    

    private void ChangeDisplayOriginal(string original)
    {
        _textOriginal.text = original;
    }

    private void ChangeDisplayJapanese(string japanese)
    {
        _textJapanese.text = japanese;
    }

    private void ChangeDisplayRoman(string roman)
    {
        _textRoman.text = "<color=#" + ColorUtility.ToHtmlStringRGB(yetInputedCharColor) + ">" + roman + "</color>";
    }

    public void ChangeDisplayRoman(Quiz nowQuiz, int doneInputIndex)
    {
        Debug.Log(doneInputIndex);

        // ���͂��������Ă��镶��

        string roman = nowQuiz.roman;

        string displayRoman = "";

        displayRoman += "<color=#" + ColorUtility.ToHtmlStringRGB(doneInputedCharColor) + ">";
        for (int i = 0; i < roman.Length; i++)
        {
            if (i == doneInputIndex)
            {
                displayRoman += "</color><color=#" + ColorUtility.ToHtmlStringRGB(yetInputedCharColor) + ">";
            }

            displayRoman += roman[i];
        }
        displayRoman += "</color>";

        ChangeDisplayRoman(displayRoman);
    }

    public void ChangeDisplayQuizText(Quiz nowQuiz)
    {
        ChangeDisplayOriginal(nowQuiz.original);
        ChangeDisplayJapanese(nowQuiz.japanese);
        ChangeDisplayRoman(nowQuiz.roman);
    }
}