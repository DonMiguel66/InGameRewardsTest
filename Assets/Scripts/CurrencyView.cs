using TMPro;
using UnityEngine;

public class CurrencyView : MonoBehaviour
{
    private const string CandyKey = nameof(CandyKey);
    private const string DiamondKey = nameof(DiamondKey);
    public static CurrencyView Instance { get; private set; }

    [SerializeField]
    private TMP_Text _currentCountCandy;

    [SerializeField]
    private TMP_Text _currentCountDiamond;

    private void Awake()
    {
        Instance = this;
        _currentCountCandy.text = PlayerPrefs.GetInt(CandyKey).ToString();
        _currentCountCandy.text = PlayerPrefs.GetInt(DiamondKey).ToString();
    }

    public void AddCandy(int value)
    {
        SaveNewCountInPlayerPrefs(CandyKey, value);
        _currentCountCandy.text = PlayerPrefs.GetInt(CandyKey, 0).ToString();
    }

    public void AddDiamond(int value)
    {
        SaveNewCountInPlayerPrefs(DiamondKey, value);
        _currentCountDiamond.text = PlayerPrefs.GetInt(DiamondKey, 0).ToString();
    }

    private void SaveNewCountInPlayerPrefs(string key, int value)
    {
        var currentCount = PlayerPrefs.GetInt(key, 0);
        var newCount = currentCount + value;
        PlayerPrefs.SetInt(key, newCount);
    }

}
