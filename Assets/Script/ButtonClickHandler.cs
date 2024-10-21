using UnityEngine;
using UnityEngine.UI;  // UI 요소를 사용하기 위해 필요

public class ButtonClickHandler : MonoBehaviour
{
    public Button warningButton;  // Unity 에디터에서 WarningBut 버튼을 연결

    void Start()
    {
        // 버튼에 클릭 이벤트 리스너 추가
        warningButton.onClick.AddListener(OnWarningButtonClick);
    }

    // WarningBut 버튼을 눌렀을 때 실행되는 메서드
    void OnWarningButtonClick()
    {
        Debug.Log("WarningBut 버튼이 눌렸습니다!");
        // 여기에 버튼을 눌렀을 때 실행될 코드를 작성하세요.
    }
}
