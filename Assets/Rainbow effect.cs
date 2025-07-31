using UnityEngine;
using System.Collections;

public class RaibowEffect : MonoBehaviour
{
    [SerializeField] private Renderer targetRenderer;

    public float speed = 1f;
    
    void Start()
    {
               StartCoroutine(RainbowCycle());
    }
    IEnumerator RainbowCycle()
    {
        float hue = 0f;

        while (true)
        {
            Color rainbowColor = Color.HSVToRGB(hue, 1f, 1f);
            targetRenderer.material.color = rainbowColor;
            hue += Time.deltaTime * speed;
            if (hue > 1f) hue -= 1f;

            yield return null;
        }
    }
}
