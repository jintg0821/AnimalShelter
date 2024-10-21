using UnityEngine;
using UnityEngine.UI;  // UI ��Ҹ� ����ϱ� ���� �ʿ�

public class ButtonClickHandler : MonoBehaviour
{
    public Button warningButton;  // Unity �����Ϳ��� WarningBut ��ư�� ����

    void Start()
    {
        // ��ư�� Ŭ�� �̺�Ʈ ������ �߰�
        warningButton.onClick.AddListener(OnWarningButtonClick);
    }

    // WarningBut ��ư�� ������ �� ����Ǵ� �޼���
    void OnWarningButtonClick()
    {
        Debug.Log("WarningBut ��ư�� ���Ƚ��ϴ�!");
        // ���⿡ ��ư�� ������ �� ����� �ڵ带 �ۼ��ϼ���.
    }
}
