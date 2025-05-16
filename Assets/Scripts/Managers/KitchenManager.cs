using UnityEngine;

public class KitchenManager : MonoBehaviour
{
    public KitchenData kitchenData;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SaveKitchenData()
    {
        // Implement save logic here
        // For example, you can use PlayerPrefs or a file to save the kitchenData
        Debug.Log("Kitchen data saved.");
    }
    public void LoadKitchenData()
    {
        // Implement load logic here
        // For example, you can use PlayerPrefs or a file to load the kitchenData
        Debug.Log("Kitchen data loaded.");
    }
}
