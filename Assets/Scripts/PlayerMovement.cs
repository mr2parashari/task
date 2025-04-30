using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;           
    public float rotationSpeed = 100f;     

    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); 
        float vertical = Input.GetAxis("Vertical");     

        Vector3 moveDirection = transform.forward * vertical;
        controller.Move(moveDirection * moveSpeed * Time.deltaTime);
        transform.Rotate(0, horizontal * rotationSpeed * Time.deltaTime, 0);
    }
}
