using System.Collections;
using UnityEngine;

public class ShinyMaker : MonoBehaviour
{
    Renderer rendererer;
    Material mat;
    void Start()
    {
        rendererer = GetComponent<Renderer>();
        mat = rendererer.material;
        StartCoroutine(SwapColor());
    }
    private IEnumerator SwapColor()
    {
        while(true){
            yield return new WaitForSeconds(.25f);
            mat.color = Random.ColorHSV();
        }
    }
}
