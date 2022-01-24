using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ContainerSlotRewardView : MonoBehaviour
{
    [SerializeField]
    private Image _backgroundSelect;

    [SerializeField]
    private Image _iconCurrency;

    [SerializeField]
    private TMP_Text _textDays;

    [SerializeField]
    private TMP_Text _countReward;

    [SerializeField]
    RewardTimePeriodType RewardTimePeriodType;

    public void SetData(Reward reward, int counter, bool isSelect, RewardTimePeriodType timePeriod)
    {
        _iconCurrency.sprite = reward.IconCurrency;
        _textDays.text = $"{timePeriod} {counter}";
        _countReward.text = reward.CountCurrency.ToString();
        _backgroundSelect.gameObject.SetActive(isSelect);
    }
}
