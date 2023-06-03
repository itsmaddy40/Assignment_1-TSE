/*this class represents a battery pickup object in a Unity game. 
When the player interacts with the battery pickup, it adds a specified number of batteries to the player's inventory and destroys the pickup object. The _batteryPickUpActivated flag ensures that the battery pickup can only be collected once.*/




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickUp : MonoBehaviour
{
    public int _addBatteriesToInventory = 1;
    public bool _batteryPickUpActivated;

    void start() {
      _batteryPickUpActivated = false;
    }

  public void PickUpBattery() {
    if (_batteryPickUpActivated == true) // Check if the battery pickup has already been activated
        return; // If so, exit the method

    // Find the player object and get the Inventory component attached to it
    Inventory temp = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

    // Add the specified number of batteries to the player's inventory
    temp.BatteryToInventory(_addBatteriesToInventory);

    Destroy(gameObject); // Destroy the battery pickup object
    _batteryPickUpActivated = true; // Mark the battery pickup as activated
}

}
