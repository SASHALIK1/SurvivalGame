using UnityEngine;
using DG.Tweening;

public class ChangeAlpha : MonoBehaviour
{
    private float targetAlpha = 1f; 

    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        ChangeAlphaWithDOTween();
    }

    private void ChangeAlphaWithDOTween()
    {
        Color currentColor = spriteRenderer.color;
        currentColor.a = targetAlpha;
        spriteRenderer.DOColor(currentColor, 1.5f);
    }
}
