using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class TextHighlightLogic : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private TextMeshProUGUI originalText;
    private Color originalColor;
    [SerializeField] private Color highlightColor; 

    private void Start()
    {
        originalText = GetComponent<TextMeshProUGUI>();
        originalColor = originalText.color;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        originalText.color = highlightColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        originalText.color = originalColor;
    }
}
