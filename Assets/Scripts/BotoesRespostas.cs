using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BotoesRespostas : MonoBehaviour
{
    private bool isCerto;
    [SerializeField] private TextMeshProUGUI textoResposta;

   // [SerializeField] private QuestionSetup questionSetup;

    public void SetAnswerText(string newText)
    {
        textoResposta.text = newText;
    }

    public void SetIsCorrect(bool newBool)
    {
        isCerto = newBool;
    }

    public void OnClick()
    {
        if (isCerto)
        {
            Debug.Log("Reposta certa");
        }
        else
        {
            Debug.Log("Errado");
        }

//        if (questionSetup.questions.Count > 0)
 //       {
   //         questionSetup.Start();
     //   }
    }
}