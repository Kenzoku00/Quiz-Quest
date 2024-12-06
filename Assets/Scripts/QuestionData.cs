using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Question", menuName = "ScriptableObject/Question", order = 1)]

public class QuestionData : ScriptableObject
{
    public string question;
    public string category;
    [Tooltip("The correct answer should always be listed first, they are randomized later")]
    public string[] answers;
}
