using UnityEngine;
using UnityEngine.UIElements;

public class UIHandler : MonoBehaviour
{
    private VisualElement m_Health;
    public static UIHandler instance { get; private set; }

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        UIDocument uIDocument = GetComponent<UIDocument>();
        m_Health = uIDocument.rootVisualElement.Q<VisualElement>("Health");
        SetHealthValue(1.0f);
    }

    public void SetHealthValue(float percentage)
    {
        m_Health.style.width = Length.Percent(100 * percentage);
    }
}
