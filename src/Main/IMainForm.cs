﻿using System;
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
    public interface IMainForm
    {
		void setPresenter(Presenter presenter);

        void updateActivityList(List<string> activities);
        void updateActivityInfo(string description);

        void updateChallengeList(List<string> challenges);
        void updateChallengeInfo(string description);

        void setupTimer(string time);
        void updateTimer(string time);
        void hideAndStopTimer();

        void createActivityPopUp();
        void createChallengePopUp();
        void createTrophyPopUp();
    }
}
