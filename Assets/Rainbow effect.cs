using UnityEngine;
using System.Collections;

public class RaibowEffect : MonoBehaviour
{
    public float speed = 1f;
    private Material material;
    void Start()
    {
        material = GetComponent<Renderer>().material;
        StartCoroutine(RainbowCycle());
    }
    IEnumerator RainbowCycle()
    {
        float hue = 0f;

        while (true)
        {
            Color rainbowColor = Color.HSVToRGB(hue, 1f, 1f);
            material.color = rainbowColor;
            hue += Time.deltaTime * speed;
            if (hue > 1f) hue -= 1f;

            yield return null;
        }
    }
}
