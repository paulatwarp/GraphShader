using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Source : MonoBehaviour
{
    public RawImage image;
    Material material;
    Texture2D source;
    int position = 0;

    void Start()
    {
        material = image.material;
        image.material = material;
        source = new Texture2D(256, 1);
        image.texture = source;
    }

    void Update()
    {
        position += 1;
        int x = (position % source.width);
        Color y = Color.white * (Input.GetAxis("Mouse Y") + 1.0f) * 0.5f;
        source.SetPixel(x, 0, y);
        source.Apply();
        material.SetTextureOffset("_MainTex", new Vector2(((float)x + 1.0f) / (float)source.width, 0));
    }
}
