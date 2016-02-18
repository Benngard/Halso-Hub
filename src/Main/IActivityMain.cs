using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Anton Andrén
/// </summary>
namespace Halso_Hub
{
    /// <summary>
    /// Interface for the view (ActivityMain) used by the presenter.
    /// </summary>
    interface IActivityMain
    {
        void setPresenter(Presenter presenter);

        void updateMoodButtons(string one, string two, string three, string four, string title);
        void showAllMoodButtons();
        void showOneMoodButton();

        void updateActivityList(List<string> activities);
        void updateActivityInfo(string description);

        void setupTimer(string time);
        void updateTimer(string time);
        void hideAndStopTimer();

        void createActivityPopUp();
        void createChallengePopUp();
        void createTrophyPopUp();
    }
}
