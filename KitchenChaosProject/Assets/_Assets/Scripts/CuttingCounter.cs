using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttingCounter : BaseCounter
{
    [SerializeField] private KitchenObjectScriptableObjects cutKitchenObjectSO;

    public override void Interact(PlayerController player)
    {

        if (!HasKitchenObject())
        {
            if (player.HasKitchenObject())
            {
                player.GetKitchenObject().SetKitchenObjectParent(this);
            }
            else
            {

            }
        }
        else
        {
            if (player.HasKitchenObject())
            {

            }
            else
            {
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
    }

    public override void InteractAlternate(PlayerController player)
    {
        if (HasKitchenObject())
        {
            GetKitchenObject().DestroySelf();
            //Transform kitchenObjectTransform = Instantiate(cutKitchenObjectSO.prefab);
            //kitchenObjectTransform.GetComponent<KitchenObject>().SetKitchenObjectParent(this);
            KitchenObject.SpawnKitchenObject(cutKitchenObjectSO, this);
        }
        else
        {

        }
    }
}
