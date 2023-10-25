using UnityEngine;

public class SetDifficultyManager : MonoBehaviour
{
    public static SetDifficultyManager Instance;

    public int EasyMaxScore;
    public int MediumMaxScore;
    public int HardMaxScore;

    public float EasyMaxTime;
    public float MediumMaxTime;
    public float HardMaxTime;

    public float EasySpawnerTime;
    public float MediumSpawnerTime;
    public float HardSpawnerTime;

    public float EasyScoreCoef;
    public float MediumScoreCoef;
    public float HardScoreCoef;

    private void Awake()
    {
        Instance = this;
    }
}
