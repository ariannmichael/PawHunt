using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private GameObject[] animals;
    private bool active = false;
    private int randomIndex;
    
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (!active)
        {
            ShowAnimal();
        }
    }

    void ShowAnimal()
    {
        randomIndex = Random.Range(0, animals.Length);
        animals[randomIndex].gameObject.SetActive(true);
        active = true;
    }

    public void HideAnimal()
    {
        animals[randomIndex].gameObject.SetActive(false);
        active = false;
    }
}
