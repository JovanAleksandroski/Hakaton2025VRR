using UnityEngine;

public class AutoHeadMove : MonoBehaviour
{
    public GameObject rigRoot;         // XR Rig или Player објект
    public Transform headTransform;    // Камера (телефон/главата)
    public float speed = 1.5f;

    void Update()
    {
        if (rigRoot == null || headTransform == null) return;

        Vector3 moveDirection = headTransform.forward;
        moveDirection.y = 0f; // само хоризонтално движење според поглед
        rigRoot.transform.position += moveDirection.normalized * speed * Time.deltaTime;
    }
}
