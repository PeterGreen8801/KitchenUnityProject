using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BaseCounter : MonoBehaviour
{
    public virtual void Interact(PlayerController playerController)
    {
        Debug.LogError("BaseCounter.Interact();");
    }
}
