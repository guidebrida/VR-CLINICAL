using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Perguntas", menuName = "ScriptableObjects/Perguntas", order = 1)]
public class PerguntasData : ScriptableObject
{
public string perguntas;
[Tooltip("A resposta correta sempre deve ser inserida primeiro")]
public string[] respostas;
}