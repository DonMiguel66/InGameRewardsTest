using UnityEngine;

public class InstallView : MonoBehaviour
{
    [SerializeField]
    private DailyRewardView _dailyRewardView;

    [SerializeField]
    private WeeklyRewardView _weeklyRewardView;

    private RewardController _dailyRewardController;
    private RewardController _weeklyRewardController;

    private void Awake()
    {
        _dailyRewardController = new RewardController(_dailyRewardView);
        _weeklyRewardController = new RewardController(_weeklyRewardView);        
    }

    private void Start()
    {
        _dailyRewardController.RefreshView();
        _weeklyRewardController.RefreshView();
    }

}
