using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class KitchenObject : MonoBehaviour
{
    [SerializeField] private KitchenObjectScriptableObjects kitchenObjectScriptableObjects;

    private ClearCounter clearCounter;

    public KitchenObjectScriptableObjects GetKitchenObjectScriptableObjects()
    {
        return kitchenObjectScriptableObjects;
    }

    public void SetClearCounter(ClearCounter clearCounter)
    {
        this.clearCounter = clearCounter;
    }

    public ClearCounter GetClearCounter()
    {
        return clearCounter;
    }
}
