using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceMngmnt : MonoBehaviour
{
    // Start is called before the first frame update
    private int health = 100;
    private int gold = 0;
    public GameObject inventoryCanvas;
    //public GameObject storeCanvas;

    private bool isGamePaused = false;
    private Inventory inventory;
    void Start()
    {
        this.inventory = Inventory.Instance;
    }

    
    void Update()
    {
        OpenInventory();
    }

    void TogglePause()
    {
        if (isGamePaused)
        {
            ResumeGame();
        }
        else
        {
            PauseGame();
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0f;
        isGamePaused = true;
        Debug.Log("Game Paused");
    }

    void ResumeGame()
    {
        Time.timeScale = 1f; 
        isGamePaused = false;
        Debug.Log("Game Resumed");
    }

    public void OpenInventory()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            TogglePause();
            inventoryCanvas.SetActive(!inventoryCanvas.activeSelf);
        }
    }
}
