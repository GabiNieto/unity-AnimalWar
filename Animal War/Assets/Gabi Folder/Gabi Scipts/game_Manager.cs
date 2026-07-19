using System.Data.SqlTypes;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class game_Manager : MonoBehaviour
{


    public int health = 20;
    public int gold = 0;

    public GameObject towerUI; //MAY BE CHANGE TO UI

    private constructionTower selectedTower;


    public TextMeshProUGUI goldText;


    public void getMoney(int money)
    {
        gold += money;
        Debug.Log("money money");
        UpdateGoldUI();
    }

    void UpdateGoldUI()
    {
        goldText.text = "Gold: " + gold;
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateGoldUI();
        towerUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            HandleClick();
        }
    }


    void HandleClick()
    {

        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            if (hit.collider.CompareTag("Player"))
            {
                Debug.Log("CLICKING");
                selectedTower = hit.collider.GetComponent<constructionTower>();
                towerUI.SetActive(true);
                return;
            }
        }

        // Clicked somewhere else hide UI
        towerUI.SetActive(false);
        selectedTower = null;
    }

    public bool SpendGold(int amount)
    {
        if (gold >= amount)
        {
            gold -= amount;
            UpdateGoldUI();
            return true;
        }

        return false;
    }

    public void BuildCannon()
    {
        Debug.Log("BuildCannon");
        if (selectedTower == null) return;

        if (SpendGold(selectedTower.cannonCost))
        {
            Instantiate(selectedTower.cannonPrefab, selectedTower.transform.position, Quaternion.identity);
            Destroy(selectedTower.gameObject);
            towerUI.SetActive(false);
            selectedTower = null;
        }
    }

    public void BuildCrossbow()
    {
        if (selectedTower == null) return;

        if (SpendGold(selectedTower.crossbowCost))
        {
            Instantiate(selectedTower.crossbowPrefab, selectedTower.transform.position, Quaternion.identity);
            Destroy(selectedTower.gameObject);
            towerUI.SetActive(false);
            selectedTower = null;
        }
    }







}
