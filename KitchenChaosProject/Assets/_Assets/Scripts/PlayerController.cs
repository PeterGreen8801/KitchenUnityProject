using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 7f;

    private bool isWalking;

    [SerializeField] private GameInput gameInput;

    private void Update()
    {

        Vector2 inputVector = gameInput.GetMovementVectorNormalized();
        Vector3 moveDirection = new Vector3(inputVector.x, 0f, inputVector.y);

        float rotateSpeed = 10f;
        transform.forward = Vector3.Slerp(transform.forward, moveDirection, Time.deltaTime * rotateSpeed);

        isWalking = moveDirection != Vector3.zero;

        transform.position += moveSpeed * Time.deltaTime * moveDirection;

    }

    public bool IsWalking()
    {
        return isWalking;
    }
}
