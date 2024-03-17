using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PerguntasSetup : MonoBehaviour
{
    [SerializeField]
    private List<PerguntasData> perguntas;
    private PerguntasData perguntaAtual;

    [SerializeField]
    private TextMeshProUGUI questionText;
    [SerializeField]
    private TextMeshProUGUI categoryText;
    [SerializeField]
    private BotoesRespostas[] botoesRespostas;

    [SerializeField]
    private int correctAnswerChoice;

    private void Awake()
    {
        GetQuestionAssets();
    }

    public void Start()
    {
        SelectNewQuestion();
        SetQuestionValues();
        SetAnswerValues();
    }

    void Update()
    {

    }

    private void GetQuestionAssets()
    {
        perguntas = new List<PerguntasData>(Resources.LoadAll<PerguntasData>("Perguntas"));
    }

    private void SelectNewQuestion()
    {
        int randomQuestionIndex = Random.Range(0, perguntas.Count);
        perguntaAtual = perguntas[randomQuestionIndex];
        perguntas.RemoveAt(randomQuestionIndex);
    }

    private void SetQuestionValues()
    {
        questionText.text = perguntaAtual.perguntas;
    }

    private void SetAnswerValues()
    {
        List<string> answers = RandomizeAnswers(new List<string>(perguntaAtual.respostas));
        for (int i = 0; i < botoesRespostas.Length; i++)
        {
            bool isCorrect = false;
            if (i == correctAnswerChoice)
            {
                isCorrect = true;
            }

            botoesRespostas[i].SetIsCorrect(isCorrect);
            botoesRespostas[i].SetAnswerText(answers[i]);
        }
    }

    private List<string> RandomizeAnswers(List<string> originalList)
    {
        bool correctAnswerChosen = false;

        List<string> newList = new List<string>();

        for (int i = 0; i < botoesRespostas.Length; i++)
        {
            int random = Random.Range(0, originalList.Count);
            if (random == 0 && !correctAnswerChosen)
            {
                correctAnswerChoice = i;
                correctAnswerChosen = true;
            }
            newList.Add(originalList[random]);
            originalList.RemoveAt(random);
        }


        return newList;
    }
}