using UnityEngine;

public class PaintObject : MonoBehaviour
{
    public Texture paintTexture;
    public LayerMask newLayerMask;
    private Material myMaterial;

    private void Start()
    {
        myMaterial = GetComponent<Renderer>().material;
    }

    public void Paint()
    {
        myMaterial.SetTexture("_BaseMap", paintTexture);
        gameObject.layer = newLayerMask;
        Debug.Log("Paint!");
    }
}
