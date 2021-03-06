using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialRoom_Key : MonoBehaviour
{

    private Inventory inventory;              // Inventory of player
    private Item item;                        // Item that connect with this button
    public GameObject target;
    public GameObject player;

    public GameObject inventoryPage;

    public void OnClick()
    {
        if (Vector3.Distance(target.transform.position, player.transform.position) < 5f)
        {
            inventory.UseItem(item);
            inventoryPage.SetActive(false);
        }
    }

    public void SetItem(Item item)
    {
        this.item = item;
    }

    public Item GetItem()
    {
        return item;
    }

    public void SetInventory(Inventory inventory)
    {
        this.inventory = inventory;
    }
}
