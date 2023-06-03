/*this class represents a battery boost pickup object in a Unity game. 
When the player interacts with the battery boost pickup, it adds a specified number of battery boosts to the player's inventory and destroys the pickup object. The _batteryBoostPickUpActivated flag ensures that the battery boost pickup can only be collected once.*/




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseBattery : MonoBehaviour
{

    public int _addBatteryBoostToInventory = 1;
    public bool _batteryBoostPickUpActivated;
    // Start is called before the first frame update
    void Start()
    {
        _batteryBoostPickUpActivated = false;
    }

   public void PickUpBatteryBoost() {
    if (_batteryBoostPickUpActivated == true) // Check if the battery boost pickup has already been activated
        return; // If so, exit the method

    // Find the player object and get the Inventory component attached to it
    Inventory temp = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

    // Add the specified number of battery boosts to the player's inventory
    temp.BatteryBoostToInventory(_addBatteryBoostToInventory);

    Destroy(gameObject); // Destroy the battery boost pickup object
    _batteryBoostPickUpActivated = true; // Mark the battery boost pickup as activated
}

}
