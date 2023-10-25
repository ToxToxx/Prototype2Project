using UnityEngine;

public sealed class PlayerHealth : HealthLogic
{
    public static PlayerHealth Instance { get; set; }

    [SerializeField] private int _healAmount;
    [SerializeField] private int _healCount;

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        currentHealth = maxHealth;
        GameInput.Instance.OnHeal += GameInput_OnHeal;
    }

    private void OnDestroy()
    {
        GameInput.Instance.OnHeal -= GameInput_OnHeal;
    }

    private void GameInput_OnHeal(object sender, System.EventArgs e)
    {
        Heal();
    }

    private void Heal()
    {
        if(_healCount > 0 && currentHealth < maxHealth)
        {
            currentHealth += _healAmount;
            if(currentHealth > maxHealth)
            {
                currentHealth = maxHealth;
            }
            _healCount--;
        } else
        {
            Debug.Log("You can't heal");
        }
        
    }

    public int GetPotionsCount()
    {
        return _healCount;
    }


}
