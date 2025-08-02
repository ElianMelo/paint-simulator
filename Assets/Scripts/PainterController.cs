using UnityEngine;

public class PainterController : MonoBehaviour
{
    public LayerMask layerMask;
    public Transform orientation;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            RaycastHit hit;
            if (Physics.Raycast(orientation.position, orientation.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask)) {
                PaintObject paintObject = hit.collider.GetComponent<PaintObject>();
                if (paintObject != null)
                {
                    paintObject.Paint();
                }
            }
        }
    }
}
