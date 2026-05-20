using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] InputAction thrust;
    [SerializeField] float thrustStrength = 1000f;
    Rigidbody rb;


    private void OnEnable()
    {
        thrust.Enable();
    }


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (thrust.IsPressed())
        {
            // 로컬 방향으로 힘을 가함
            // vector3.up은 실질적으론 0, 1, 0
            rb.AddRelativeForce(Vector3.up * thrustStrength * Time.fixedDeltaTime);
        }
    }
}
