using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttingCounter : BaseCounter
{
    [SerializeField] private CuttingRecipeSO[] cuttingRecipeSOArray;

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
            KitchenObjectScriptableObjects outputKitchenObjectSO = GetOutputForInput(GetKitchenObject().GetKitchenObjectScriptableObjects());
            GetKitchenObject().DestroySelf();
            //Transform kitchenObjectTransform = Instantiate(cutKitchenObjectSO.prefab);
            //kitchenObjectTransform.GetComponent<KitchenObject>().SetKitchenObjectParent(this);
            KitchenObject.SpawnKitchenObject(outputKitchenObjectSO, this);
        }
        else
        {

        }
    }

    private KitchenObjectScriptableObjects GetOutputForInput(KitchenObjectScriptableObjects inputKitchenObjectSO)
    {
        foreach (CuttingRecipeSO cuttingRecipeSO in cuttingRecipeSOArray)
        {
            if (cuttingRecipeSO.input == inputKitchenObjectSO)
            {
                return cuttingRecipeSO.output;
            }
        }
        return null;
    }
}
