using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] InputAction thrust;

    private void OnEnable()
    {
        thrust.Enable();
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (thrust.IsPressed())
        {
            Debug.Log("You Input Spacebar");
        }
    }
}
