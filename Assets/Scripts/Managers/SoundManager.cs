using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance { get; private set; }

    [SerializeField] private AudioClipRefsSO _audioClipRefsSO;

    private readonly float _volume = 1.0f;

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        GameInput.Instance.OnShoot += GameInput_OnShoot;
        GameInput.Instance.OnHeal += GameInput_OnHeal;
        DefensePoint.Instance.OnPlayerGetDamage += DefensePoint_OnPlayerGetDamage;
    }
    private void OnDestroy()
    {
        GameInput.Instance.OnShoot -= GameInput_OnShoot;
        GameInput.Instance.OnHeal -= GameInput_OnHeal;
        DefensePoint.Instance.OnPlayerGetDamage -= DefensePoint_OnPlayerGetDamage;
    }

    private void DefensePoint_OnPlayerGetDamage(object sender, System.EventArgs e)
    {
        PlaySound(_audioClipRefsSO.HitSound, Player.Instance.transform.position);
    }

    private void GameInput_OnHeal(object sender, System.EventArgs e)
    {
        PlaySound(_audioClipRefsSO.HealSound, Player.Instance.transform.position);
    }

    private void GameInput_OnShoot(object sender, System.EventArgs e)
    {
        PlaySound(_audioClipRefsSO.ShootSound, Player.Instance.transform.position);
    }

    private void PlaySound(AudioClip audioClip, Vector3 position, float volumeMultiplier = 50f)
    {
        AudioSource.PlayClipAtPoint(audioClip, position, volumeMultiplier * _volume);
    }


}
