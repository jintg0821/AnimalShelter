using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExplainTypingEffect : MonoBehaviour
{
    public Text text;
    private string n_text = "\n ����: �ֻ� ó�� \n ��Ż: �� ó�� \n ��â��: �ֻ� �� �� ó�� \n �����: �� ó��";

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
