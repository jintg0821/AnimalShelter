using System.Collections;
using UnityEngine;
using UnityEngine.UI; // UI ����� ����ϱ� ���� �ʿ�

public class DogHealAndFadeOutController : MonoBehaviour
{
    public GameObject dogObject; // ������ ������Ʈ�� �巡���ؼ� ����
    public Button healButton; // UI ��ư�� �巡���ؼ� ����
    public float fadeDuration = 2f; // ���̵� �ƿ� �ð�

    private Renderer dogRenderer;

    void Start()
    {
        dogRenderer = dogObject.GetComponentInChildren<Renderer>();

        // ��ư Ŭ�� �̺�Ʈ�� �޼��� ����
        healButton.onClick.AddListener(HealAndFadeOut);
    }

    // "ġ���ϱ�" ��ư�� ������ �� ȣ��Ǵ� �޼���
    private void HealAndFadeOut()
    {
        StartCoroutine(FadeOutCoroutine());
    }

    private IEnumerator FadeOutCoroutine()
    {
        float currentTime = 0f;
        Color initialColor = dogRenderer.material.color;

        while (currentTime < fadeDuration)
        {
            currentTime += Time.deltaTime;
            float alphaValue = Mathf.Lerp(1f, 0f, currentTime / fadeDuration); // ���� �� ������ ����
            dogRenderer.material.color = new Color(initialColor.r, initialColor.g, initialColor.b, alphaValue);
            yield return null; // ���� �����ӱ��� ���
        }

        Destroy(dogObject); // ���̵� �ƿ��� �Ϸ�Ǹ� ������ ������Ʈ ����
    }
}
