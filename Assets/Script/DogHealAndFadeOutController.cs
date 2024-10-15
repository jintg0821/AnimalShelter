using System.Collections;
using UnityEngine;
using UnityEngine.UI; // UI 기능을 사용하기 위해 필요

public class DogHealAndFadeOutController : MonoBehaviour
{
    public GameObject dogObject; // 강아지 오브젝트를 드래그해서 연결
    public Button healButton; // UI 버튼을 드래그해서 연결
    public float fadeDuration = 2f; // 페이드 아웃 시간

    private Renderer dogRenderer;

    void Start()
    {
        dogRenderer = dogObject.GetComponentInChildren<Renderer>();

        // 버튼 클릭 이벤트에 메서드 연결
        healButton.onClick.AddListener(HealAndFadeOut);
    }

    // "치료하기" 버튼이 눌렸을 때 호출되는 메서드
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
            float alphaValue = Mathf.Lerp(1f, 0f, currentTime / fadeDuration); // 알파 값 점진적 감소
            dogRenderer.material.color = new Color(initialColor.r, initialColor.g, initialColor.b, alphaValue);
            yield return null; // 다음 프레임까지 대기
        }

        Destroy(dogObject); // 페이드 아웃이 완료되면 강아지 오브젝트 삭제
    }
}
