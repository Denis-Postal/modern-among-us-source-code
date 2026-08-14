using UnityEngine;

public class ColorChip : MonoBehaviour
{
    // Меняем старый SpriteRenderer на новый HatParent, как в актуальной версии
    public HatParent Inner;

    // Новые UI-элементы из свежих версий
    public GameObject PlayerEquippedForeground;
    public GameObject InUseForeground;
    public PassiveButton Button;
    public SpriteRenderer SelectionHighlight;
    public object Tag;

    private readonly Color unavailableColor = new Color(0.35f, 0.35f, 0.35f, 1f);

    // Поддержка ID продуктов для системы магазинов/косметики
    public string ProductId { get; set; }

    public string ProdId
    {
        get => ProductId;
        set => ProductId = value;
    }

    // Реализуем новые методы управления состоянием кнопки цвета
    public void ShowSelected()
    {
        if (SelectionHighlight != null)
        {
            SelectionHighlight.gameObject.SetActive(true);
        }
    }

    public void Deselect()
    {
        if (SelectionHighlight != null)
        {
            SelectionHighlight.gameObject.SetActive(false);
        }
    }

    public void SetUnavailable()
    {
        if (InUseForeground != null)
        {
            InUseForeground.SetActive(true);
        }

        // Старая логика окрашивания дочерних спрайтов в серый цвет
        SpriteRenderer[] componentsInChildren = GetComponentsInChildren<SpriteRenderer>(true);
        for (int i = 0; i < componentsInChildren.Length; i++)
        {
            componentsInChildren[i].color = unavailableColor;
        }

        if (Button != null)
        {
            Button.SetButtonEnableState(false);
        }
    }
}