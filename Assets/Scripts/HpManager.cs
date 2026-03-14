using UnityEngine;

public class HpManager : MonoBehaviour
{
    [SerializeField] protected int hp = 3;
    [SerializeField] int maxHp = 5;
    [SerializeField] GameObject heartPrefab;
    [SerializeField] GameObject emptyHeartPrefab;
    [SerializeField] Transform heartsContainer;

    GameObject[] fullHearts;
    GameObject[] emptyHearts;

    void Start()
    {
        spawnPrefabs();
        updateHearts();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D)) takeDmg();
        if (Input.GetKeyDown(KeyCode.H)) heal();
        if (Input.GetKeyDown(KeyCode.U)) upgradeMaxHp();
    }

    public void spawnPrefabs()
    {
        foreach (Transform child in heartsContainer)
            Destroy(child.gameObject);

        fullHearts = new GameObject[maxHp];
        emptyHearts = new GameObject[maxHp];

        int heartsPerRow = 4;
        int index = 0;
        int rows = (maxHp + heartsPerRow - 1) / heartsPerRow;

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < heartsPerRow && index < maxHp; col++)
            {
                Vector3 pos = new Vector3(col * 1.25f, -row * 1.25f, 0f);

                emptyHearts[index] = Instantiate(emptyHeartPrefab, heartsContainer);
                emptyHearts[index].transform.localPosition = pos;

                fullHearts[index] = Instantiate(heartPrefab, heartsContainer);
                fullHearts[index].transform.localPosition = pos;

                index++;
            }
        }
    }

    public void updateHearts()
    {
        for (int i = 0; i < fullHearts.Length; i++)
        {
            fullHearts[i].SetActive(i < hp);
        }
    }

    public void upgradeMaxHp()
    {
        maxHp++;
        hp++;          
        spawnPrefabs();
        updateHearts();
    }

    public void takeDmg()
    {
        if (hp > 0)
        {
            hp--;
        }
            updateHearts();
    }

    public void heal()
    {
        if (hp < maxHp) {
            hp++;
    }
        updateHearts();
    }
}


