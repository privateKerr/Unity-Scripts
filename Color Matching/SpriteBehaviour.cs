using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteBehaviour : MonoBehaviour
{
    private SpriteRenderer rendererObj;
    public SpriteData spriteData;

    private void Awake()
    {
        rendererObj = GetComponent<SpriteRenderer>();
        ChangeRendererSprite(spriteData);
    }

    public void ChangeRendererColor(ColorID obj)
    {
        rendererObj.color = obj.value;
    }

    public void ChangeRendererColor(ColorIDListData obj)
    {
        rendererObj.color = obj.currentColor.value;
    }

    public void ChangeRendererSprite(SpriteData obj)
    {
        rendererObj.sprite = obj.sprites[0];
    }
}
