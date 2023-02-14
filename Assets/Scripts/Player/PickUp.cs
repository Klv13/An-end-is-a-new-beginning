using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    [SerializeField] private LayerMask PickupMask;
    [SerializeField] private Camera PlayerCamera;
    [SerializeField] private Transform PickupTarget;
    [Space]
    [SerializeField] private float PickupRange;
    private Rigidbody CurrentObject;
    public float speed = 12f;
    public GameObject EtoPickub;
    private bool HasItem;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {

            if (CurrentObject)
            {
                CurrentObject.useGravity = true;
                CurrentObject = null;
                HasItem = false;
                return;
            }

            Ray CameraRay1 = PlayerCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
            if (Physics.Raycast(CameraRay1, out RaycastHit HitInfo1, PickupRange, PickupMask))
            {
                CurrentObject = HitInfo1.rigidbody;
                CurrentObject.useGravity = false;
                HasItem = true;
            }

        }


        Ray CameraRay = PlayerCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
        if (Physics.Raycast(CameraRay, out RaycastHit HitInfo, PickupRange, PickupMask) && !HasItem)
        {
            EtoPickub.active = true;
        }
        else
        {
            EtoPickub.active = false;
        }
    }

    private void FixedUpdate()
    {
        if (CurrentObject)
        {
            Vector3 DirectionToPoint = PickupTarget.position - CurrentObject.position;
            float DistanceToPoint = DirectionToPoint.magnitude;

            CurrentObject.velocity = DirectionToPoint * speed * DistanceToPoint;
        }
    }
}
