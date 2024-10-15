using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExplainTypingEffect : MonoBehaviour
{
    public Text text;
    private string n_text = "\n 감기: 주사 처방 \n 배탈: 약 처방 \n 고창증: 주사 및 약 처방 \n 진드기: 약 처방";

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(typing());
    }

    IEnumerator typing()
    {
        yield return new WaitForSeconds(0.3f);
        for (int i = 0; i <= n_text.Length; i++)
        {
            text.text = n_text.Substring(0, i);

            yield return new WaitForSeconds(0.15f);
        }
    }
}
