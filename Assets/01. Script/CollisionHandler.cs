using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("friend");
                break;
            case "Fuel":
                Debug.Log("hungry");
                break;
            case "Finish":
                Debug.Log("end");
                break;
            default:
                break;
        }
    }
}
