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
            //red and yellow make orange
            new CraftRecipe(2,
            new int[] {
                1,3,0,0,0,0
            }),
            //yellow and blue make green
            new CraftRecipe(4,
            new int[] {
                6,3,0,0,0,0
            }),
            //blue and green make teal
            new CraftRecipe(5,
            new int[] {
                4,6,6,0,0,0
            }),
            //blue and red make purple
            new CraftRecipe(7,
            new int[]{
                1,6,0,0,0,0
            })
        };
    }
}