using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CraftRecipeDatabase : MonoBehaviour {
    public List<CraftRecipe> recipes = new List<CraftRecipe>();
    private ItemDatabase itemDatabase;

    private void Awake()
    {
        itemDatabase = GetComponent<ItemDatabase>();
        BuildCraftRecipeDatabase();
    }

    public Item CheckRecipe(int[] recipe)
    {
        foreach(CraftRecipe craftRecipe in recipes)
        {
            if (craftRecipe.requiredItems.OrderBy(i => i).SequenceEqual(recipe.OrderBy(i=>i)))
            {
                return itemDatabase.GetItem(craftRecipe.itemToCraft);
            }
        }
        return null;
    }

    void BuildCraftRecipeDatabase()
    {
        //ROYGTBV
        //1234567
        recipes = new List<CraftRecipe>()
        {
            //tea
            new CraftRecipe(13,
            new int[] {
                2,10,0,0,0,0
            }),
            //sight vial
            new CraftRecipe(14,
            new int[] {
                2,3,0,0,0,0
            }),
            //purification potion
            new CraftRecipe(15,
            new int[] {
                10,8,5,0,0,0
            }),
            //healing flask
            new CraftRecipe(16,
            new int[]{
                3,4,15,0,0,0
            }),
            //philter of strength
            new CraftRecipe(17,
            new int[]{
                12,12,6,0,0,0
            }),
            //vial of vitality
            new CraftRecipe(18,
            new int[]{
                3,3,3,1,1,7
            }),
            //potion of growth
            new CraftRecipe(19,
            new int[]{
                17,18,11,11,11,11
            })
        };
    }
}