using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MaterialCycle : MonoBehaviour
{
    private TextMeshProUGUI text;
    private float offset;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        offset += 0.1f * Time.deltaTime;
        if (text.fontMaterial.GetTextureOffset("_FaceTex").x >= 1f)
        {
            offset = 0f;
            text.fontMaterial.SetTextureOffset("_FaceTex", new Vector2(0f, 0f));
        }
        else
        {
            text.fontMaterial.SetTextureOffset("_FaceTex", new Vector2(offset, 0f));
        }
        
    }
}
